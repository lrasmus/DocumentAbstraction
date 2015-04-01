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

namespace eMERGEVTE
{
    public partial class VTEAssessment : UserControl, IAssessmentControl
   {
      public TermDictionary Terms { get; set; }
      public List<TermMatch> HighlightedSentenceTerms { get; set; }
      public List<TermMatch> HighlightedDocumentTerms { get; set; }
      public string StudyName { get { return "eMERGE VTE Abstraction"; } }
      public List<string> AnatomicalSites = new List<string>();
      public List<string> DisorderMentions = new List<string>();
      public List<string> StandaloneMentions = new List<string>();
      public List<string> ExclusionSites = new List<string>();

      public event EventHandler<TextEventArgs> HighlightText;

      public VTEAssessment()
      {
         InitializeComponent();

         AnatomicalSites = new List<string>(LoadDictionary("AnatomicalSites"));
         StandaloneMentions = new List<string>(LoadDictionary("StandaloneMentions"));

         var column = dgvFindings.Columns["colDisorder"] as DataGridViewComboBoxColumn;
         DisorderMentions = new List<string>(LoadDictionary("Disorders"));
         column.DataSource = DisorderMentions.ToArray();
         column = dgvStandalone.Columns["colExclusions"] as DataGridViewComboBoxColumn;
         ExclusionSites = new List<string>(LoadDictionary("ExclusionLocations"));
         column.DataSource = ExclusionSites.ToArray();
      }

      private string[] LoadDictionary(string fileParamKey)
      {
          string fileName = ConfigurationManager.AppSettings[fileParamKey];
          if (fileName == null || !File.Exists(fileName))
          {
              return new string[] { "ERROR" };
          }

          return File.ReadAllLines(fileName);
      }

      public void LoadDocumentAnnotations(Document document)
      {
         txtDocumentReview.Text = "";
         dgvFindings.Rows.Clear();
         dgvStandalone.Rows.Clear();

         if (HighlightedDocumentTerms != null)
         {
             foreach (var term in HighlightedDocumentTerms)
             {
                 DataGridView grid = null;
                 if (AnatomicalSites.Contains(term.Term))
                 {
                     grid = dgvFindings;
                 }
                 else if (StandaloneMentions.Contains(term.Term))
                 {
                     grid = dgvStandalone;
                 }

                 if (grid != null)
                 {
                     int index = grid.Rows.Add(new object[] { term.Term });
                     grid.Rows[index].Tag = term;
                 }
             }
         }

         dgvFindings.ClearSelection();
         dgvStandalone.ClearSelection();
          //if (document.Annotations.Count > 0) {
          //  txtDocumentReview.Text = document.Annotations[VTEAnnotation.DocumentReviewNotesTag].ToString();

          //  List<VTEAnnotation.Finding> findings = document.Annotations[VTEAnnotation.DocumentPolypFindingsTag] as List<VTEAnnotation.Finding>;
          //  foreach (var finding in findings)
          //  {
          //      dgvFindings.Rows.Add(new object[] { finding.Location, finding.Type });
          //  }
          //}
      }

      public void SaveDocumentAnnotations(Document document)
      {
          //document.Annotations[VTEAnnotation.DocumentReviewNotesTag] = txtDocumentReview.Text;
          //if (!document.Annotations.ContainsKey(VTEAnnotation.DocumentPolypFindingsTag))
          //{
          //    document.Annotations.Add(VTEAnnotation.DocumentPolypFindingsTag, new List<VTEAnnotation.Finding>());
          //}

          //List<VTEAnnotation.Finding> findings = document.Annotations[VTEAnnotation.DocumentPolypFindingsTag] as List<VTEAnnotation.Finding>;
          //findings.Clear();
          //foreach (DataGridViewRow row in dgvFindings.Rows)
          //{
          //    string location = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
          //    string type = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString();
          //    if (!string.IsNullOrEmpty(location) || !string.IsNullOrEmpty(type))
          //    {
          //        findings.Add(new VTEAnnotation.Finding()
          //        {
          //            Location = location,
          //            Type = type
          //        });
          //    }
          //}
      }

      public void LoadSentenceAnnotations(Sentence sentence)
      {
      }

      public void SaveSentenceAnnotations(Sentence sentence)
      {
      }

      private void dgvFindings_SelectionChanged(object sender, EventArgs e)
      {
          DataGridView grid = sender as DataGridView;
          if (grid == null)
          {
              return;
          }

          if (grid == dgvFindings)
          {
              dgvStandalone.ClearSelection();
          }
          else if (grid == dgvStandalone)
          {
              dgvFindings.ClearSelection();
          }

          if (HighlightText != null && grid.SelectedRows.Count > 0)
          {
              DataGridViewRow row = grid.SelectedRows[0];
              if (HighlightedDocumentTerms != null && row != null && row.Tag != null)
              {
                  HighlightText(this, new TextEventArgs() { Match = row.Tag as TermMatch });
              }
          }
      }
   }
}
