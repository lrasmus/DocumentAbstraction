using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public partial class AorticAneurysmAssessment : UserControl, IAssessmentControl
   {
      public TermDictionary Terms { get; set; }
      public List<string> HighlightedSentenceTerms { get; set; }
      public List<string> HighlightedDocumentTerms { get; set; }
      public string StudyName { get { return "Aortic Aneurysm Abstraction"; } }
   
      public AorticAneurysmAssessment()
      {
         InitializeComponent();
      }
      
      private void chkKeywordsRelated_CheckedChanged(object sender, EventArgs e)
      {
         chkExplicitMention.Enabled = chkKeywordsRelated.Checked;
         chkLocation.Enabled = chkKeywordsRelated.Checked;
         chkMeasurement.Enabled = chkKeywordsRelated.Checked;
         chkMeasurementDescriptors.Enabled = chkKeywordsRelated.Checked;
         chkNegation.Enabled = chkKeywordsRelated.Checked;
         chkInvalidKeywords.Enabled = chkKeywordsRelated.Checked;
         lblUnrelated.Enabled = chkKeywordsRelated.Checked;
         lblSubject.Enabled = chkKeywordsRelated.Checked;
         radSubjectFamilyMember.Enabled = chkKeywordsRelated.Checked;
         radSubjectNone.Enabled = chkKeywordsRelated.Checked;
         radSubjectPatient.Enabled = chkKeywordsRelated.Checked;
         
         if (chkKeywordsRelated.Checked) {
            SetRelatedKeywordControlState();
            }
         else {
            lstUnrelatedTerms.Enabled = false;
            cmdClearSelection.Enabled = false;
            lblUnrelated.Enabled = false;
            }
      }

      public void LoadDocumentAnnotations(Document document)
      {
      }
      
      public void SaveDocumentAnnotations(Document document)
      {
      }
      
      public void LoadSentenceAnnotations(Sentence sentence)
      {
         lstUnrelatedTerms.Items.Clear();
         if (HighlightedSentenceTerms != null) {
            foreach (string term in HighlightedSentenceTerms) {
               lstUnrelatedTerms.Items.Add(term);
               }
            }
      
         if (sentence.Annotations.Count == 0) {
            chkKeywordsRelated.Checked = false;
            chkExplicitMention.Checked = false;
            chkLocation.Checked = false;
            chkMeasurement.Checked = false;
            chkMeasurementDescriptors.Checked = false;
            chkNegation.Checked = false;
            chkInvalidKeywords.Checked = false;
            radSubjectPatient.Checked = true;
            radSubjectFamilyMember.Checked = false;
            radSubjectNone.Checked = false;
            }
         else {
            chkKeywordsRelated.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceRelatedTag];
            chkExplicitMention.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceExplicitTag];
            chkLocation.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceLocationTag];
            chkMeasurement.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceMeasurementTag];
            chkMeasurementDescriptors.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceMeasurementDescrTag];
            chkNegation.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceNegatedTag];
            chkInvalidKeywords.Checked = (bool)sentence.Annotations[AorticAneurysmAnnotation.SentenceNotAllRelatedTag];            
            SetUnrelatedTerms(sentence.Annotations[AorticAneurysmAnnotation.SentenceUnrelatedTermTag].ToString());
            SetSubject(sentence.Annotations[AorticAneurysmAnnotation.SentenceSubjectTag].ToString());
            }
      }
      
      public void SaveSentenceAnnotations(Sentence sentence)
      {
         sentence.Annotations[AorticAneurysmAnnotation.SentenceRelatedTag] = chkKeywordsRelated.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceExplicitTag] = chkExplicitMention.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceLocationTag] = chkLocation.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceMeasurementTag] = chkMeasurement.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceMeasurementDescrTag] = chkMeasurementDescriptors.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceNegatedTag] = chkNegation.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceNotAllRelatedTag] = chkInvalidKeywords.Checked;
         sentence.Annotations[AorticAneurysmAnnotation.SentenceUnrelatedTermTag] = GetUnrelatedTerms();
         sentence.Annotations[AorticAneurysmAnnotation.SentenceSubjectTag] = GetSubject();
      }
      
      private string GetSubject()
      {
         if (radSubjectFamilyMember.Checked) {
            return AorticAneurysmAnnotation.FamilyMember;
            }
         else if (radSubjectNone.Checked) {
            return AorticAneurysmAnnotation.NoneOrHypothetical;
            }
         else if (radSubjectPatient.Checked) {
            return AorticAneurysmAnnotation.Patient;
            }
            
         return "";
      }
      
      private void SetSubject(string subject)
      {
         radSubjectFamilyMember.Checked = (subject == AorticAneurysmAnnotation.FamilyMember);
         radSubjectNone.Checked = (subject == AorticAneurysmAnnotation.NoneOrHypothetical);
         radSubjectPatient.Checked = (subject == AorticAneurysmAnnotation.Patient);
      }
      
      private string GetUnrelatedTerms()
      {
         if (!lstUnrelatedTerms.Enabled) {
            return "";
            }
      
         string selectedTerms = "";
         foreach (string item in lstUnrelatedTerms.SelectedItems) {
            selectedTerms += item + AorticAneurysmAnnotation.UnrelatedTermDelimiter;
            }
         return selectedTerms;
      }
      
      private void SetUnrelatedTerms(string termString)
      {
         string[] terms = termString.Split(
            new char[] { AorticAneurysmAnnotation.UnrelatedTermDelimiter }, 
            StringSplitOptions.RemoveEmptyEntries);
         
         foreach (string term in terms) {
            lstUnrelatedTerms.SelectedItems.Add(term);
            }
      }

      private void chkInvalidKeywords_CheckedChanged(object sender, EventArgs e)
      {
         SetRelatedKeywordControlState();
      }
      
      private void SetRelatedKeywordControlState()
      {
         lstUnrelatedTerms.Enabled = chkInvalidKeywords.Checked;
         lblUnrelated.Enabled = chkInvalidKeywords.Checked;
         cmdClearSelection.Enabled = chkInvalidKeywords.Checked;
      }

      private void cmdClearSelection_Click(object sender, EventArgs e)
      {
         lstUnrelatedTerms.SelectedItems.Clear();
      }
   }
}
