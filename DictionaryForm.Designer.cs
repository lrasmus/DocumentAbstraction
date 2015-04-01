namespace MC.MCRF.NLP.DocumentAbstraction
{
   partial class DictionaryForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.cmdOK = new System.Windows.Forms.Button();
         this.cmdCancel = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtTerms = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // cmdOK
         // 
         this.cmdOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.cmdOK.Location = new System.Drawing.Point(90, 306);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 23);
         this.cmdOK.TabIndex = 1;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // cmdCancel
         // 
         this.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(216, 306);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 23);
         this.cmdCancel.TabIndex = 2;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(53, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Term List:";
         // 
         // txtTerms
         // 
         this.txtTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.txtTerms.Location = new System.Drawing.Point(15, 26);
         this.txtTerms.Multiline = true;
         this.txtTerms.Name = "txtTerms";
         this.txtTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtTerms.Size = new System.Drawing.Size(354, 254);
         this.txtTerms.TabIndex = 4;
         // 
         // DictionaryForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(381, 341);
         this.Controls.Add(this.txtTerms);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.Name = "DictionaryForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Dictionary";
         this.Load += new System.EventHandler(this.DictionaryForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button cmdOK;
      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtTerms;
   }
}