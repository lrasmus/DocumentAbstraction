using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MC.MCRF.NLP.DocumentAbstraction
{
   public partial class DictionaryForm : Form
   {
      public TermDictionary Dictionary  { get; set; }
   
      public DictionaryForm()
      {
         InitializeComponent();
      }

      private void DictionaryForm_Load(object sender, EventArgs e)
      {
         if (Dictionary != null && Dictionary.Terms != null) {
            foreach (string term in Dictionary.Terms.Keys) {
               txtTerms.Text += term + "\r\n";
               }
            }
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         if (Dictionary == null) {
            Dictionary = new TermDictionary();
            }

         string[] existingTerms = Dictionary.Terms.Keys.Select(x => x.ToString()).ToArray<string>();
         string[] terms = txtTerms.Text.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
         foreach (string term in terms) {
            Dictionary.AddSimpleTerm(term);
            }
         foreach (string existingTerm in existingTerms)
         {
             if (!terms.Contains(existingTerm))
             {
                 Dictionary.RemoveTerm(existingTerm);
             }
         }
      }
   }
}
