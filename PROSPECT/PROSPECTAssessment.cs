using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MC.MCRF.NLP.DocumentAbstraction;

namespace MC.MCRF.NLP.PROSPECT
{
   public partial class PROSPECTAssessment : UserControl, IAssessmentControl
   {
      public TermDictionary Terms { get; set; }
      public List<string> HighlightedSentenceTerms { get; set; }
      public List<string> HighlightedDocumentTerms { get; set; }
      public string StudyName { get { return "Obesity Counseling Abstraction"; } }
      
      public PROSPECTAssessment()
      {
         InitializeComponent();
      }

      public void LoadDocumentAnnotations(Document document)
      {
         txtDocumentReview.Text = "";
         if (document.Annotations.Count == 0) {
            chkDocumentReview.Checked = false;
            }
         else {
            chkDocumentReview.Checked = (bool)document.Annotations[PROSPECTAnnotation.DocumentReviewTag];
            txtDocumentReview.Text = document.Annotations[PROSPECTAnnotation.DocumentReviewNotesTag].ToString();
            }
      }

      public void SaveDocumentAnnotations(Document document)
      {
         document.Annotations[PROSPECTAnnotation.DocumentReviewTag] = chkDocumentReview.Checked;
         document.Annotations[PROSPECTAnnotation.DocumentReviewNotesTag] = txtDocumentReview.Text;
      }

      public void LoadSentenceAnnotations(Sentence sentence)
      {
         txtOther.Text = "";
         txtNotes.Text = "";
         txtSentenceReview.Text = "";
         
         if (sentence.Annotations.Count == 0) {
            chkAdvise.Checked = false;
            chkPsychAssess.Checked = false;
            chkAssist.Checked = false;
            chkArrange.Checked = false;
            chkOther.Checked = false;
            chkSentenceReview.Checked = false;
            }
         else {
            chkAdvise.Checked = (bool)sentence.Annotations[PROSPECTAnnotation.SentenceAdviseTag];
            chkPsychAssess.Checked = (bool)sentence.Annotations[PROSPECTAnnotation.SentencePsychAssessTag];
            chkAssist.Checked = (bool)sentence.Annotations[PROSPECTAnnotation.SentenceAssistTag];
            chkArrange.Checked = (bool)sentence.Annotations[PROSPECTAnnotation.SentenceArrangeTag];
            chkOther.Checked = (bool)sentence.Annotations[PROSPECTAnnotation.SentenceOtherTag];
            txtOther.Text = sentence.Annotations[PROSPECTAnnotation.SentenceOtherNotesTag].ToString();
            txtNotes.Text = sentence.Annotations[PROSPECTAnnotation.SentenceNotesTag].ToString();
            chkSentenceReview.Checked = (bool)sentence.Annotations[PROSPECTAnnotation.SentenceReviewTag];
            txtSentenceReview.Text = sentence.Annotations[PROSPECTAnnotation.SentenceReviewNotesTag].ToString();
            }
      }

      public void SaveSentenceAnnotations(Sentence sentence)
      {
         sentence.Annotations[PROSPECTAnnotation.SentencePsychAssessTag] = chkPsychAssess.Checked;
         sentence.Annotations[PROSPECTAnnotation.SentenceAdviseTag] = chkAdvise.Checked;
         sentence.Annotations[PROSPECTAnnotation.SentenceAssistTag] = chkAssist.Checked;
         sentence.Annotations[PROSPECTAnnotation.SentenceArrangeTag] = chkArrange.Checked;
         sentence.Annotations[PROSPECTAnnotation.SentenceOtherTag] = chkOther.Checked;
         sentence.Annotations[PROSPECTAnnotation.SentenceOtherNotesTag] = txtOther.Text;
         sentence.Annotations[PROSPECTAnnotation.SentenceNotesTag] = txtNotes.Text;
         sentence.Annotations[PROSPECTAnnotation.SentenceReviewTag] = chkSentenceReview.Checked;
         sentence.Annotations[PROSPECTAnnotation.SentenceReviewNotesTag] = txtSentenceReview.Text;
      }

      private void chkOther_CheckedChanged(object sender, EventArgs e)
      {
         txtOther.Enabled = chkOther.Checked;
      }

      private void chkSentenceReview_CheckedChanged(object sender, EventArgs e)
      {
         txtSentenceReview.Enabled = chkSentenceReview.Checked;
      }

      private void chkDocumentReview_CheckedChanged(object sender, EventArgs e)
      {
         txtDocumentReview.Enabled = chkDocumentReview.Checked;
      }
   }
}
