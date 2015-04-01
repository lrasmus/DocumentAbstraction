using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MC.MCRF.NLP.DocumentAbstraction;
using System.Configuration;
using System.IO;

namespace ColonoscopyAbstraction
{
    public partial class ColonoscopyAssessment : UserControl, IAssessmentControl
    {
        public TermDictionary Terms { get; set; }
        public List<TermMatch> HighlightedSentenceTerms { get; set; }
        public List<TermMatch> HighlightedDocumentTerms { get; set; }
        public string StudyName { get { return "Colonoscopy Assessment Abstraction"; } }

        public event EventHandler<TextEventArgs> HighlightText;

        public ColonoscopyAssessment()
        {
            InitializeComponent();
        }

        public void LoadDocumentAnnotations(Document document)
        {
            cboCompleteness.SelectedIndex = -1;
            cboScreeningIndication.SelectedIndex = -1;
            cboPolypCount.SelectedIndex = -1;
            cboPolypSize.SelectedIndex = -1;
            cboPrepQuality.SelectedIndex = -1;

            if (document.Annotations.Count > 0)
            {
                txtDocumentReview.Text = document.Annotations[ColonoscopyAnnotation.DocumentReviewNotesTag].ToString();
                cboCompleteness.SelectedItem = document.Annotations[ColonoscopyAnnotation.DocumentCompletenessTag].ToString();
                cboScreeningIndication.SelectedItem = document.Annotations[ColonoscopyAnnotation.DocumentScreeningIndicationTag].ToString();
                cboPolypCount.SelectedItem = document.Annotations[ColonoscopyAnnotation.DocumentPolypCountTag].ToString();
                cboPolypSize.SelectedItem = document.Annotations[ColonoscopyAnnotation.DocumentPolypSizeTag].ToString();
                cboPrepQuality.SelectedItem = document.Annotations[ColonoscopyAnnotation.DocumentPrepQualityTag].ToString();
            }
        }

        public void SaveDocumentAnnotations(Document document)
        {
            document.Annotations[ColonoscopyAnnotation.DocumentReviewNotesTag] = txtDocumentReview.Text;
            document.Annotations[ColonoscopyAnnotation.DocumentCompletenessTag] = cboCompleteness.Text;
            document.Annotations[ColonoscopyAnnotation.DocumentScreeningIndicationTag] = cboScreeningIndication.Text;
            document.Annotations[ColonoscopyAnnotation.DocumentPolypCountTag] = cboPolypCount.Text;
            document.Annotations[ColonoscopyAnnotation.DocumentPolypSizeTag] = cboPolypSize.Text;
            document.Annotations[ColonoscopyAnnotation.DocumentPrepQualityTag] = cboPrepQuality.Text;
        }

        public void LoadSentenceAnnotations(Sentence sentence)
        {
        }

        public void SaveSentenceAnnotations(Sentence sentence)
        {
        }
    }
}
