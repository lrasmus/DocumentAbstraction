namespace MC.MCRF.NLP.PROSPECT
{
   partial class PROSPECTAssessment
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.Label label1;
         this.chkAdvise = new System.Windows.Forms.CheckBox();
         this.chkPsychAssess = new System.Windows.Forms.CheckBox();
         this.chkArrange = new System.Windows.Forms.CheckBox();
         this.chkOther = new System.Windows.Forms.CheckBox();
         this.txtOther = new System.Windows.Forms.TextBox();
         this.chkAssist = new System.Windows.Forms.CheckBox();
         this.txtNotes = new System.Windows.Forms.TextBox();
         this.chkSentenceReview = new System.Windows.Forms.CheckBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.chkDocumentReview = new System.Windows.Forms.CheckBox();
         this.txtSentenceReview = new System.Windows.Forms.TextBox();
         this.txtDocumentReview = new System.Windows.Forms.TextBox();
         label1 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // chkAdvise
         // 
         this.chkAdvise.AutoSize = true;
         this.chkAdvise.Location = new System.Drawing.Point(4, 4);
         this.chkAdvise.Name = "chkAdvise";
         this.chkAdvise.Size = new System.Drawing.Size(295, 17);
         this.chkAdvise.TabIndex = 0;
         this.chkAdvise.Text = "&1 - Advise (Generic statements advising pt to lose weight)";
         this.chkAdvise.UseVisualStyleBackColor = true;
         // 
         // chkPsychAssess
         // 
         this.chkPsychAssess.AutoSize = true;
         this.chkPsychAssess.Location = new System.Drawing.Point(4, 27);
         this.chkPsychAssess.Name = "chkPsychAssess";
         this.chkPsychAssess.Size = new System.Drawing.Size(277, 17);
         this.chkPsychAssess.TabIndex = 1;
         this.chkPsychAssess.Text = "&2 - Psych Assess (Reflect pt readiness to lose weight)";
         this.chkPsychAssess.UseVisualStyleBackColor = true;
         // 
         // chkArrange
         // 
         this.chkArrange.AutoSize = true;
         this.chkArrange.Location = new System.Drawing.Point(4, 73);
         this.chkArrange.Name = "chkArrange";
         this.chkArrange.Size = new System.Drawing.Size(262, 17);
         this.chkArrange.TabIndex = 3;
         this.chkArrange.Text = "&4 - Arrange (Follow-up w/ pt regarding weight loss)";
         this.chkArrange.UseVisualStyleBackColor = true;
         // 
         // chkOther
         // 
         this.chkOther.AutoSize = true;
         this.chkOther.Location = new System.Drawing.Point(4, 96);
         this.chkOther.Name = "chkOther";
         this.chkOther.Size = new System.Drawing.Size(52, 17);
         this.chkOther.TabIndex = 4;
         this.chkOther.Text = "&Other";
         this.chkOther.UseVisualStyleBackColor = true;
         this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
         // 
         // txtOther
         // 
         this.txtOther.Enabled = false;
         this.txtOther.Location = new System.Drawing.Point(62, 96);
         this.txtOther.Multiline = true;
         this.txtOther.Name = "txtOther";
         this.txtOther.Size = new System.Drawing.Size(256, 45);
         this.txtOther.TabIndex = 5;
         // 
         // chkAssist
         // 
         this.chkAssist.AutoSize = true;
         this.chkAssist.Location = new System.Drawing.Point(4, 50);
         this.chkAssist.Name = "chkAssist";
         this.chkAssist.Size = new System.Drawing.Size(288, 17);
         this.chkAssist.TabIndex = 2;
         this.chkAssist.Text = "&3 - Assist (Address commitment to a weight loss method)";
         this.chkAssist.UseVisualStyleBackColor = true;
         // 
         // txtNotes
         // 
         this.txtNotes.Location = new System.Drawing.Point(4, 191);
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.Size = new System.Drawing.Size(632, 53);
         this.txtNotes.TabIndex = 7;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(3, 175);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(200, 13);
         label1.TabIndex = 6;
         label1.Text = "Notes (Comments/Reminders/Questions)";
         // 
         // chkSentenceReview
         // 
         this.chkSentenceReview.AutoSize = true;
         this.chkSentenceReview.Location = new System.Drawing.Point(6, 19);
         this.chkSentenceReview.Name = "chkSentenceReview";
         this.chkSentenceReview.Size = new System.Drawing.Size(145, 17);
         this.chkSentenceReview.TabIndex = 0;
         this.chkSentenceReview.Text = "&Sentence review needed";
         this.chkSentenceReview.UseVisualStyleBackColor = true;
         this.chkSentenceReview.CheckedChanged += new System.EventHandler(this.chkSentenceReview_CheckedChanged);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtDocumentReview);
         this.groupBox1.Controls.Add(this.txtSentenceReview);
         this.groupBox1.Controls.Add(this.chkDocumentReview);
         this.groupBox1.Controls.Add(this.chkSentenceReview);
         this.groupBox1.Location = new System.Drawing.Point(341, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(295, 158);
         this.groupBox1.TabIndex = 8;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Review Request";
         // 
         // chkDocumentReview
         // 
         this.chkDocumentReview.AutoSize = true;
         this.chkDocumentReview.Location = new System.Drawing.Point(6, 82);
         this.chkDocumentReview.Name = "chkDocumentReview";
         this.chkDocumentReview.Size = new System.Drawing.Size(148, 17);
         this.chkDocumentReview.TabIndex = 2;
         this.chkDocumentReview.Text = "&Document review needed";
         this.chkDocumentReview.UseVisualStyleBackColor = true;
         this.chkDocumentReview.CheckedChanged += new System.EventHandler(this.chkDocumentReview_CheckedChanged);
         // 
         // txtSentenceReview
         // 
         this.txtSentenceReview.Location = new System.Drawing.Point(25, 39);
         this.txtSentenceReview.Multiline = true;
         this.txtSentenceReview.Name = "txtSentenceReview";
         this.txtSentenceReview.Size = new System.Drawing.Size(252, 37);
         this.txtSentenceReview.TabIndex = 1;
         // 
         // txtDocumentReview
         // 
         this.txtDocumentReview.Location = new System.Drawing.Point(25, 105);
         this.txtDocumentReview.Multiline = true;
         this.txtDocumentReview.Name = "txtDocumentReview";
         this.txtDocumentReview.Size = new System.Drawing.Size(252, 37);
         this.txtDocumentReview.TabIndex = 3;
         // 
         // PROSPECTAssessment
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(label1);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.chkAssist);
         this.Controls.Add(this.txtOther);
         this.Controls.Add(this.chkOther);
         this.Controls.Add(this.chkArrange);
         this.Controls.Add(this.chkPsychAssess);
         this.Controls.Add(this.chkAdvise);
         this.Name = "PROSPECTAssessment";
         this.Size = new System.Drawing.Size(646, 248);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.CheckBox chkAdvise;
      private System.Windows.Forms.CheckBox chkPsychAssess;
      private System.Windows.Forms.CheckBox chkArrange;
      private System.Windows.Forms.CheckBox chkOther;
      private System.Windows.Forms.TextBox txtOther;
      private System.Windows.Forms.CheckBox chkAssist;
      private System.Windows.Forms.TextBox txtNotes;
      private System.Windows.Forms.CheckBox chkSentenceReview;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.CheckBox chkDocumentReview;
      private System.Windows.Forms.TextBox txtDocumentReview;
      private System.Windows.Forms.TextBox txtSentenceReview;
   }
}
