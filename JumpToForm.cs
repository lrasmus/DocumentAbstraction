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
   public partial class JumpToForm : Form
   {
      public int Item { get; set; }
   
      public JumpToForm()
      {
         InitializeComponent();
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         int item = 0;
         if (int.TryParse(txtItem.Text, out item)) {
            Item = item;
            }
      }

      private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == (char)Keys.Return) {
            cmdOK_Click(cmdOK, new EventArgs());
            }
      }      
   }
}
