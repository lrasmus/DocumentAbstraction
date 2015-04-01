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

namespace VTEClinical
{
    public partial class VTEAssessment : UserControl, IAssessmentControl
    {
        public TermDictionary Terms { get; set; }
        public List<TermMatch> HighlightedSentenceTerms { get; set; }
        public List<TermMatch> HighlightedDocumentTerms { get; set; }
        public string StudyName { get { return "eMERGE VTE Abstraction"; } }

        public event EventHandler<TextEventArgs> HighlightText;

        public VTEAssessment()
        {
            InitializeComponent();
        }

        public void LoadDocumentAnnotations(Document document)
        {
            radConfirmed.Checked = false;
            radNegative.Checked = false;
            radUnsure.Checked = false;

            if (document.Annotations.Count > 0)
            {
                txtDocumentReview.Text = document.Annotations[VTEAnnotation.DocumentReviewNotesTag].ToString();
                int assessment = int.Parse(document.Annotations[VTEAnnotation.DocumentAssessmentTag].ToString());
                switch (assessment)
                {
                    case 1:
                        radConfirmed.Checked = true;
                        break;
                    case 2:
                         radNegative.Checked = true;
                         break;
                    case 3:
                         radUnsure.Checked = true;
                         break;
                }
            }
        }

        public void SaveDocumentAnnotations(Document document)
        {
            document.Annotations[VTEAnnotation.DocumentReviewNotesTag] = txtDocumentReview.Text;

            int assessment = 0;
            if (radConfirmed.Checked) 
            {
                assessment = 1;
            }
            else if (radNegative.Checked)
            {
                assessment = 2;
            }
            else if (radUnsure.Checked)
            {
                assessment = 3;
            }
                
            document.Annotations[VTEAnnotation.DocumentAssessmentTag] = assessment;
        }

        public void LoadSentenceAnnotations(Sentence sentence)
        {
        }

        public void SaveSentenceAnnotations(Sentence sentence)
        {
        }
    }
}
