using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MC.MCRF.NLP.DocumentAbstraction;

namespace ColonPolypAbstraction
{
    public partial class ColonPolypAssessment : UserControl, IAssessmentControl
   {
      public TermDictionary Terms { get; set; }
      public List<TermMatch> HighlightedSentenceTerms { get; set; }
      public List<TermMatch> HighlightedDocumentTerms { get; set; }
      public string StudyName { get { return "eMERGE Colyn Polyp Abstraction"; } }

      public event EventHandler<TextEventArgs> HighlightText;

      public ColonPolypAssessment()
      {
         InitializeComponent();

         var column = dgvFindings.Columns["colLocation"] as DataGridViewComboBoxColumn;
         column.DataSource = new string[] { "", "NA", "Left", "Right", "Rectum", "Sigmoid", "Descending", "Splenic Flexure", "Transverse", "Hepatic Flexure", "Ascending", "Cecum", "Ileum" };
         column = dgvFindings.Columns["colType"] as DataGridViewComboBoxColumn;
         column.DataSource = new string[] { "", "Serrated polyp", "Adenoma", "Hyperplastic polyp", "Traditional serrated adenoma" };
      }

      public void LoadDocumentAnnotations(Document document)
      {
         txtDocumentReview.Text = "";
         dgvFindings.Rows.Clear();
          if (document.Annotations.Count > 0) {
            txtDocumentReview.Text = document.Annotations[ColonPolypAnnotation.DocumentReviewNotesTag].ToString();

            List<ColonPolypAnnotation.Finding> findings = document.Annotations[ColonPolypAnnotation.DocumentPolypFindingsTag] as List<ColonPolypAnnotation.Finding>;
            foreach (var finding in findings)
            {
                dgvFindings.Rows.Add(new object[] { finding.Location, finding.Type });
            }
          }
      }

      public void SaveDocumentAnnotations(Document document)
      {
          document.Annotations[ColonPolypAnnotation.DocumentReviewNotesTag] = txtDocumentReview.Text;
          if (!document.Annotations.ContainsKey(ColonPolypAnnotation.DocumentPolypFindingsTag))
          {
              document.Annotations.Add(ColonPolypAnnotation.DocumentPolypFindingsTag, new List<ColonPolypAnnotation.Finding>());
          }

          List<ColonPolypAnnotation.Finding> findings = document.Annotations[ColonPolypAnnotation.DocumentPolypFindingsTag] as List<ColonPolypAnnotation.Finding>;
          findings.Clear();
          foreach (DataGridViewRow row in dgvFindings.Rows)
          {
              string location = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
              string type = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString();
              if (!string.IsNullOrEmpty(location) || !string.IsNullOrEmpty(type))
              {
                  findings.Add(new ColonPolypAnnotation.Finding()
                  {
                      Location = location,
                      Type = type
                  });
              }
          }
      }

      public void LoadSentenceAnnotations(Sentence sentence)
      {
      }

      public void SaveSentenceAnnotations(Sentence sentence)
      {
      }

      private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
      {
          foreach (DataGridViewRow row in dgvFindings.SelectedRows)
          {
              if (!row.IsNewRow)
              {
                  dgvFindings.Rows.Remove(row);
              }
          }
      }

      private void dgvFindings_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
