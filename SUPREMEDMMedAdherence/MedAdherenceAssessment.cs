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
   public partial class MedAdherenceAssessment : UserControl, IAssessmentControl
   {
      public TermDictionary Terms { get; set; }
      public List<string> HighlightedSentenceTerms { get; set; }
      public List<string> HighlightedDocumentTerms { get; set; }
      public string StudyName { get { return "Medication Adherence"; } }
      
      public MedAdherenceAssessment()
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
            chkDocumentReview.Checked = (bool)document.Annotations[MedAdherenceAnnotation.DocumentReviewTag];
            txtDocumentReview.Text = document.Annotations[MedAdherenceAnnotation.DocumentReviewNotesTag].ToString();
            }
      }

      public void SaveDocumentAnnotations(Document document)
      {
         document.Annotations[MedAdherenceAnnotation.DocumentReviewTag] = chkDocumentReview.Checked;
         document.Annotations[MedAdherenceAnnotation.DocumentReviewNotesTag] = txtDocumentReview.Text;
      }

      public void LoadSentenceAnnotations(Sentence sentence)
      {
         txtOther.Text = "";
         txtNotes.Text = "";
         txtSentenceReview.Text = "";
         
         if (sentence.Annotations.Count == 0) {
            chkStatedAdherence.Checked = false;
            chkStatedNonAdherence.Checked = false;
            chkAdherenceBarriers.Checked = false;
            chkAmbiguous.Checked = false;
            chkOther.Checked = false;
            chkSentenceReview.Checked = false;
            }
         else {
            chkStatedAdherence.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceAdherenceTag];
            chkStatedNonAdherence.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceNonAdherenceTag];
            chkAdherenceBarriers.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceBarriersTag];
            chkAdherenceAssistance.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceAssistanceTag];
            chkAmbiguous.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceAmbiguousTag];
            chkOther.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceOtherTag];
            txtOther.Text = sentence.Annotations[MedAdherenceAnnotation.SentenceOtherNotesTag].ToString();
            txtNotes.Text = sentence.Annotations[MedAdherenceAnnotation.SentenceNotesTag].ToString();
            chkSentenceReview.Checked = (bool)sentence.Annotations[MedAdherenceAnnotation.SentenceReviewTag];
            txtSentenceReview.Text = sentence.Annotations[MedAdherenceAnnotation.SentenceReviewNotesTag].ToString();
            }
      }

      public void SaveSentenceAnnotations(Sentence sentence)
      {
         sentence.Annotations[MedAdherenceAnnotation.SentenceAdherenceTag] = chkStatedAdherence.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceNonAdherenceTag] = chkStatedNonAdherence.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceBarriersTag] = chkAdherenceBarriers.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceAssistanceTag] = chkAdherenceAssistance.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceAmbiguousTag] = chkAmbiguous.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceOtherTag] = chkOther.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceOtherNotesTag] = txtOther.Text;
         sentence.Annotations[MedAdherenceAnnotation.SentenceNotesTag] = txtNotes.Text;
         sentence.Annotations[MedAdherenceAnnotation.SentenceReviewTag] = chkSentenceReview.Checked;
         sentence.Annotations[MedAdherenceAnnotation.SentenceReviewNotesTag] = txtSentenceReview.Text;
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
