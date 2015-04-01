using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public partial class MainForm : Form
   {
      protected const string DefaultFieldDelimiter = "|";
      protected const string DefaultDocumentPattern = "*.txt";
   
      protected readonly Font m_selectedFont = new Font("Arial", 9.0F, FontStyle.Bold);
      protected string[] m_fileList = null;
      protected List<Document> m_documents = new List<Document>();
      protected Document m_currentDocument = null;
      protected int m_currentSentence = 0;
      protected TermDictionary m_dictionary = null;
      protected Annotation m_annotation = null;
      protected IAssessmentControl m_assessmentControl = null;
   
      public MainForm()
      {
         InitializeComponent();
      }

      private void Form1_Shown(object sender, EventArgs e)
      {
         string assemblyPath = ConfigurationManager.AppSettings["AssessmentAssemblyLocation"];
         if (assemblyPath != null && assemblyPath.Trim() != string.Empty) {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            
            string assessmentClass = ConfigurationManager.AppSettings["AssessmentClass"];
            if (assessmentClass != null && assessmentClass.Trim() != string.Empty) {
               Type cls = assembly.GetType(assessmentClass);
               if (cls == null) {
                  MessageBox.Show(
                     this, 
                     "Unable to load the assessment data manager module.", 
                     Application.ProductName, 
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                  DisableInterface();
                  return;
                  }

               m_annotation = Activator.CreateInstance(cls) as Annotation;
               }
               
            string assessmentControl = ConfigurationManager.AppSettings["AssessmentControl"];
            if (assessmentControl != null && assessmentControl.Trim() != string.Empty) {
               Type cls = assembly.GetType(assessmentControl);
               if (cls == null) {
                  MessageBox.Show(
                     this, 
                     "Unable to load the assessment collection form.", 
                     Application.ProductName, 
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                  DisableInterface();
                  return;
                  }
                  
               m_assessmentControl = Activator.CreateInstance(cls) as IAssessmentControl;
               }
            }
            
         if (m_assessmentControl != null) {
             string title = m_assessmentControl.StudyName;
             if (!string.IsNullOrEmpty(title))
             {
                 this.Text = title;
             }

            ((Control)m_assessmentControl).Top = pnlAssessment.Top;
            ((Control)m_assessmentControl).Left = pnlAssessment.Left;
            if (((Control)m_assessmentControl).Height > pnlAssessment.Height) {
               this.Height += ((Control)m_assessmentControl).Height - pnlAssessment.Height;
               }
            else {
               ((Control)m_assessmentControl).Height = pnlAssessment.Height;
               }
               
            if (((Control)m_assessmentControl).Width > pnlAssessment.Width) {
               this.Width += ((Control)m_assessmentControl).Width - pnlAssessment.Width;
               }
            else {
               ((Control)m_assessmentControl).Width = pnlAssessment.Width;
               }

            ((Control)m_assessmentControl).Visible = true;
            ((Control)m_assessmentControl).Anchor = pnlAssessment.Anchor;
            pnlAssessment.Visible = false;
            this.Controls.Add(((Control)m_assessmentControl));

            m_assessmentControl.HighlightText += new EventHandler<TextEventArgs>(OnRequestHighlightText);
            }
      
         string dictionaryLocation = ConfigurationManager.AppSettings["Dictionary"];
         cmdDictionaryAddWord.Enabled = (dictionaryLocation != null);
         if (cmdDictionaryAddWord.Enabled) {
            string fieldDelimiter = ConfigurationManager.AppSettings["FieldDelimiter"];
            if (fieldDelimiter == null || fieldDelimiter == string.Empty) {
               fieldDelimiter = DefaultFieldDelimiter;
               }
               
            m_dictionary = new TermDictionary(dictionaryLocation, fieldDelimiter);
            }
         
         string documentsPath = ConfigurationManager.AppSettings["DocumentRepository"];
         if (documentsPath != null) {
            }
            
         string documentPattern = ConfigurationManager.AppSettings["DocumentFilePattern"];
         if (documentPattern == null || documentPattern == string.Empty) {
            documentPattern = DefaultDocumentPattern;
            }

         string sentenceAnnotations = ConfigurationManager.AppSettings["SentenceAnnotations"];
         if (sentenceAnnotations != null && !sentenceAnnotations.Equals("true", StringComparison.CurrentCultureIgnoreCase))
         {
             pnlSentence.Height = 0;
             pnlSentence.Visible = false;
             rtbDocument.Height = pnlAssessment.Top - rtbDocument.Top - 30;

             cmdJumpSelection.Visible = false;
         }
            
         // Load all of the documents
         if (Directory.Exists(documentsPath)) {
            m_fileList = Directory.GetFiles(documentsPath, documentPattern);
            foreach (string file in m_fileList) {
               m_documents.Add(new Document(file));
               }
            }
            
         // Load the annotations for the documents
         string annotationLocation = ConfigurationManager.AppSettings["Annotations"];
         if (annotationLocation != null && m_annotation != null) {
            m_annotation.LoadAnnotations(annotationLocation, m_documents);
            }
         
         if (m_fileList != null && m_fileList.Length > 0) {
            //LoadNextDocument();
            LoadNextIncompleteDocument();
            }
      }

      private void OnRequestHighlightText(object sender, TextEventArgs e)
      {
          if (e.Match != null)
          {
              HighlightTextInDocument(e.Match.StartIndex, e.Match.Term, Color.White, Color.Blue, true);
          }
      }
      
      /// <summary>
      /// Disabled the entire UI, usually in response to an error when the application loads
      /// </summary>
      private void DisableInterface()
      {
         rtbDocument.Enabled = false;
         rtbSentence.Enabled = false;
         cmdPrevious.Enabled = false;
         cmdNext.Enabled = false;
         cmdGoTo.Enabled = false;
         cmdJumpSelection.Enabled = false;
         cmdSentenceNext.Enabled = false;
         cmdSentencePrevious.Enabled = false;
         cmdDictionaryAddWord.Enabled = false;
      }
      
      private void UpdateProgress()
      {
         lblDocument.Text = string.Format("Document {0} of {1}", 
            m_documents.IndexOf(m_currentDocument) + 1, 
            m_fileList.Length);
      }
      
      private void LoadNextIncompleteDocument()
      {
         if (m_documents == null) {
            return;
            }
            
         foreach (Document doc in m_documents) {
            if (doc.Annotations.Count == 0 
            || (doc.Annotations.Count > 0
               && (bool)doc.Annotations[Annotation.DocumentCompletedTag] == false)) {
               m_currentDocument = doc;
               break;
               }
            }
            
         // Default to the last document if they are all done
         if (m_currentDocument == null) {
            m_currentDocument = m_documents[m_documents.Count - 1];
            }
            
         if (m_currentDocument != null) {
            LoadDocument(m_currentDocument);
            cmdPrevious.Enabled = (m_currentDocument != m_documents[0]);
            cmdNext.Enabled = (m_currentDocument != m_documents[m_documents.Count - 1]);
            }
      }
      
      private void LoadNextDocument()
      {
         // If there are no files, we can't load a document
         if (m_fileList.Length == 0) {
            return;
            }
            
         SaveDocumentAnnotations();
      
         cmdPrevious.Enabled = true;
         
         // If we're not on a document, load the first document
         if (m_currentDocument == null) {
            if (m_documents == null || m_documents.Count == 0) {
               Document doc = new Document(m_fileList[0]);
               m_documents.Add(doc);
               m_currentDocument = doc;
               }
            else {
               m_currentDocument = m_documents[0];
               }
               
            LoadDocument(m_currentDocument);
            }
         else {
            // Determine which document we're on
            int index = m_documents.IndexOf(m_currentDocument);
            
            // If we're at the last loaded document, we need to pull the next one
            // from the file system.
            if (index == m_documents.Count-1) {
               for (int fileIndex = 0; fileIndex < m_fileList.Length; fileIndex++) {
                  // If we find a match and it's not the last document in the list (which
                  // means we're all done), load the document and add it to our list.
                  if (m_currentDocument.FilePath == m_fileList[fileIndex]) {
                     if (fileIndex >= m_fileList.Length-2) {
                        cmdNext.Enabled = false;
                        }
                        
                     if (fileIndex < m_fileList.Length-1) {
                        Document doc = new Document(m_fileList[fileIndex+1]);
                        m_documents.Add(doc);
                        LoadDocument(doc);
                        }
                        
                     break;
                     }
                  }
               }
            else if (index < m_documents.Count - 1) {
               if (index == m_documents.Count - 2) {
                  cmdNext.Enabled = false;
                  }
                  
               LoadDocument(m_documents[index+1]);
               }
            }
      }
      
      private void LoadPreviousDocument()
      {
         // If there are no files, we can't load a document
         if (m_fileList.Length == 0) {
            return;
            }
            
         SaveDocumentAnnotations();
      
         cmdNext.Enabled = true;
         
         // We must currently be on a document to move backwards.
         if (m_currentDocument == null) {
            // This is in case we have missed disabling the Previous button
            // elsewhere.
            cmdPrevious.Enabled = false;
            }
         else {
            // Determine which document we're on
            int index = m_documents.IndexOf(m_currentDocument);
            
            // If we're at the first loaded document, we should ensure the
            // Previous button gets disabled.
            if (index <= 1) {
               cmdPrevious.Enabled = false;
               }
               
            if (index > 0) {
               LoadDocument(m_documents[index-1]);
               }
            }
      }
      
      private void LoadDocument(Document document)
      {
         cmdSentenceNext.Enabled = true;
         cmdSentencePrevious.Enabled = false;
      
         m_currentDocument = document;
         rtbDocument.ResetText();
         rtbDocument.Text = document.Text;
         
         UpdateProgress();

         m_currentSentence = 0;
         if (document.Sentences.Count > 0)
         {
             HighlightCurrentSentence();
         }

         string highlightTerms = ConfigurationManager.AppSettings["HighlightTermsInDocument"];
         if (highlightTerms != null && highlightTerms.Equals("true", StringComparison.CurrentCultureIgnoreCase))
         {
             HighlightTermsInDocument();
         }
         
         if (m_assessmentControl != null) {
            m_assessmentControl.LoadDocumentAnnotations(document);
            }
            
         // Each document will be given the completion annotation.  Any other
         // annotations will be loaded from the control.
         if (document.Annotations.Count == 0) {
            chkCompleted.Checked = false;
            }
         else {
            chkCompleted.Checked = 
               (bool)document.Annotations[Annotation.DocumentCompletedTag];
            }
      }

      private void HighlightTermsInDocument()
      {
          List<TermMatch> termList = new List<TermMatch>();
          if (m_assessmentControl != null)
          {
              m_assessmentControl.HighlightedDocumentTerms = new List<TermMatch>();
          }

          if (m_dictionary != null && m_dictionary.Terms != null)
          {
              bool firstHighlight = true;
              foreach (var term in m_dictionary.Terms)
              {
                  MatchCollection matches = Regex.Matches(rtbDocument.Text, 
                    string.Format("\\b{0}\\b", Regex.Escape(term.Key), 
                    RegexOptions.IgnoreCase | RegexOptions.Multiline));
                  for (int index = 0; index < matches.Count; index++)
                  {
                      Match match = matches[index];
                      HighlightTextInDocument(match.Index, term.Key, Color.White, Color.Blue, firstHighlight);
                      termList.Add(new TermMatch(match.Index, term.Key));
                      firstHighlight = false;
                  }

                  //int startIndex = rtbDocument.Text.IndexOf(term.Key, 0);
                  //while (startIndex >= 0)
                  //{
                  //    HighlightTextInDocument(startIndex, term.Key, Color.White, Color.Blue, firstHighlight);
                  //    termList.Add(new TermMatch(startIndex, term.Key));
                  //    startIndex = rtbDocument.Text.IndexOf(term.Key, startIndex + term.Key.Length);
                  //    firstHighlight = false;
                  //}
              }

              if (m_assessmentControl != null)
              {
                  m_assessmentControl.HighlightedDocumentTerms.AddRange(termList);
              }
          }

          m_assessmentControl.HighlightedDocumentTerms.Sort(new TermMatch.Comparer());

          rtbDocument.Select(0, 0);
          rtbDocument.ScrollToCaret();
      }
      
      private bool HighlightCurrentSentence()
      {
         HighlightSentenceInDocument(
            m_currentDocument.Sentences[m_currentSentence]);
            
         return LoadSentence(m_currentDocument.Sentences[m_currentSentence]);
      }
      
      private void HighlightSentenceInDocument(Sentence sentence)
      {
         string highlightSentences = ConfigurationManager.AppSettings["SentenceAnnotations"];
         if (highlightSentences != null && !highlightSentences.Equals("true", StringComparison.CurrentCultureIgnoreCase))
         {
             return;
         }

         int beginAt = (sentence.Begin == 0 ? 0 : sentence.Begin - 1);
         int index = rtbDocument.Text.IndexOf(sentence.Text.Replace("\r\n", "\n").Replace("\v", "\n"), beginAt);
         //if (index >= 0) {
         //   //rtbDocument.SelectionFont = rtbDocument.Font;
         //   //rtbDocument.SelectionColor = rtbDocument.ForeColor;
         //   //rtbDocument.SelectionBackColor = rtbDocument.BackColor;
            
         //   rtbDocument.SelectAll();
         //   rtbDocument.SelectionFont = rtbSentence.Font;
         //   rtbDocument.SelectionColor = rtbSentence.ForeColor;
         //   rtbDocument.SelectionBackColor = rtbSentence.BackColor;
         
         //   rtbDocument.Select(index, sentence.Text.Length);
         //   rtbDocument.SelectionFont = m_selectedFont;
         //   rtbDocument.SelectionColor = Color.White;
         //   rtbDocument.SelectionBackColor = Color.Black;
         //   rtbDocument.ScrollToCaret();
         //   }
          HighlightTextInDocument(index, sentence.Text, Color.White, Color.Black, true);
          rtbDocument.ScrollToCaret();
      }

      private void HighlightTextInDocument(int index, string text, Color textColor, Color backColor, bool resetDocument)
      {
          //int index = rtbDocument.Text.IndexOf(text.Replace("\r\n", "\n").Replace("\v", "\n"), rawTextIndex);
          if (index >= 0)
          {
              if (resetDocument)
              {
                  rtbDocument.SelectAll();
                  rtbDocument.SelectionFont = rtbSentence.Font;
                  rtbDocument.SelectionColor = rtbSentence.ForeColor;
                  rtbDocument.SelectionBackColor = rtbSentence.BackColor;
              }

              rtbDocument.Select(index, text.Length);
              rtbDocument.SelectionFont = m_selectedFont;
              rtbDocument.SelectionColor = textColor;
              rtbDocument.SelectionBackColor = backColor;
          }
      }
      
      /// <summary>
      /// Loads a sentence for display, including the higlighting of any terms
      /// found in the document.
      /// </summary>
      /// <param name="sentence"></param>
      /// <returns></returns>
      private bool LoadSentence(Sentence sentence)
      {
         rtbSentence.Text = sentence.Text;
         
         // Reset any existing highlighting
         rtbSentence.SelectAll();
         rtbSentence.SelectionFont = rtbSentence.Font;
         rtbSentence.SelectionColor = rtbSentence.ForeColor;
         rtbSentence.SelectionBackColor = rtbSentence.BackColor;
         
         bool foundTerms = false;
         List<TermMatch> termList = new List<TermMatch>();
         if (m_dictionary != null) {
            foreach (var term in m_dictionary.Terms) {
               MatchCollection matches = Regex.Matches(rtbSentence.Text, string.Format(@"\b{0}\b", term.Key), RegexOptions.IgnoreCase);
               foreach (Match match in matches) {
                  rtbSentence.Select(match.Index, match.Length);
                  rtbSentence.SelectionFont = m_selectedFont;
                  rtbSentence.SelectionColor = Color.White;
                  rtbSentence.SelectionBackColor = Color.Black;
                  termList.Add(new TermMatch(match.Index, match.Value));
                  foundTerms = true;
                  }
               }
            }
         
         if (m_assessmentControl != null) {
            m_assessmentControl.HighlightedSentenceTerms = termList;
            m_assessmentControl.LoadSentenceAnnotations(sentence);
            }
            
         return foundTerms;
      }

      private void cmdSentencePrevious_Click(object sender, EventArgs e)
      {
         if (m_assessmentControl != null) {
            m_assessmentControl.SaveSentenceAnnotations(
               m_currentDocument.Sentences[m_currentSentence]);
            }
            
         cmdSentenceNext.Enabled = true;
         
         if (m_currentSentence > 0) {
            m_currentSentence--;
            HighlightCurrentSentence();
            }
      
         if (m_currentSentence == 0) {
            cmdSentencePrevious.Enabled = false;
            }
      }

      private void cmdSentenceNext_Click(object sender, EventArgs e)
      {
         if (m_assessmentControl != null) {
            m_assessmentControl.SaveSentenceAnnotations(
               m_currentDocument.Sentences[m_currentSentence]);
            }
               
         cmdSentencePrevious.Enabled = true;
      
         if (m_currentSentence < m_currentDocument.Sentences.Count-1) {
            m_currentSentence++;
            HighlightCurrentSentence();
            }
      
         if (m_currentSentence == m_currentDocument.Sentences.Count-1) {
            cmdSentenceNext.Enabled = false;
            }
      }

      private void cmdJumpSelection_Click(object sender, EventArgs e)
      {
         int selectStart = rtbDocument.SelectionStart;
         foreach (Sentence sentence in m_currentDocument.Sentences) {
            if (sentence.Begin <= selectStart && sentence.End >= selectStart) {
               m_currentSentence = m_currentDocument.Sentences.IndexOf(sentence);
               HighlightCurrentSentence();
               break;
               }
            }
      }

      private void cmdDictionaryAddWord_Click(object sender, EventArgs e)
      {
         DictionaryForm form = new DictionaryForm();
         form.Dictionary = m_dictionary;
         form.ShowDialog(this);
         if (form.DialogResult == DialogResult.OK) {
            string dictionaryLocation = ConfigurationManager.AppSettings["Dictionary"];
            string fieldDelimiter = ConfigurationManager.AppSettings["FieldDelimiter"];
            if (fieldDelimiter == null || fieldDelimiter == string.Empty) {
               fieldDelimiter = DefaultFieldDelimiter;
               }
               
            m_dictionary.SaveFile(dictionaryLocation, fieldDelimiter);
            LoadSentence(m_currentDocument.Sentences[m_currentSentence]);
            HighlightTermsInDocument();
            }
      }

      private void cmdNext_Click(object sender, EventArgs e)
      {
         LoadNextDocument();
      }

      private void cmdPrevious_Click(object sender, EventArgs e)
      {
         LoadPreviousDocument();
      }

      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         SaveDocumentAnnotations();
      
         if (m_annotation != null) {
            string annotationLocation = ConfigurationManager.AppSettings["Annotations"];
            m_annotation.SaveAnnotations(annotationLocation, m_documents);
            }
      }
      
      private void SaveDocumentAnnotations()
      {
         if (m_currentDocument != null) {
            // Prior to saving a document we also want to save the state of the current
            // sentence tied to that document
            SaveSentenceAnnotations();
            if (m_assessmentControl != null) {
               m_assessmentControl.SaveDocumentAnnotations(m_currentDocument);
               }
               
            // Save the standard annotations for all documents, such as the
            // completion flag.
            m_currentDocument.Annotations[Annotation.DocumentCompletedTag] = 
               chkCompleted.Checked;
            }
      }
      
      private void SaveSentenceAnnotations()
      {
         if (m_currentDocument != null
         && m_currentSentence < m_currentDocument.Sentences.Count
         && m_assessmentControl != null) {
            m_assessmentControl.SaveSentenceAnnotations(
               m_currentDocument.Sentences[m_currentSentence]);
            }
      }

      private void cmdGoTo_Click(object sender, EventArgs e)
      {
         if (m_currentDocument == null || m_documents == null) {
            cmdGoTo.Enabled = false;
            }
            
         JumpToForm form = new JumpToForm();
         form.Item = m_documents.IndexOf(m_currentDocument) + 1;
         form.ShowDialog();
         if (form.DialogResult == DialogResult.OK) {
            if ((form.Item-1) >= m_documents.Count) {
               return;
               }
               
            m_currentDocument = m_documents[form.Item - 1];
            LoadDocument(m_currentDocument);
            }
      }
   }
}
