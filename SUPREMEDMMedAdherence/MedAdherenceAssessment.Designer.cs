namespace MC.MCRF.NLP.PROSPECT
{
   partial class MedAdherenceAssessment
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtDocumentReview = new System.Windows.Forms.TextBox();
         this.txtSentenceReview = new System.Windows.Forms.TextBox();
         this.chkDocumentReview = new System.Windows.Forms.CheckBox();
         this.chkSentenceReview = new System.Windows.Forms.CheckBox();
         this.txtNotes = new System.Windows.Forms.TextBox();
         this.chkAdherenceBarriers = new System.Windows.Forms.CheckBox();
         this.txtOther = new System.Windows.Forms.TextBox();
         this.chkOther = new System.Windows.Forms.CheckBox();
         this.chkAmbiguous = new System.Windows.Forms.CheckBox();
         this.chkStatedNonAdherence = new System.Windows.Forms.CheckBox();
         this.chkStatedAdherence = new System.Windows.Forms.CheckBox();
         this.chkAdherenceAssistance = new System.Windows.Forms.CheckBox();
         label1 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(2, 176);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(200, 13);
         label1.TabIndex = 15;
         label1.Text = "Notes (Comments/Reminders/Questions)";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtDocumentReview);
         this.groupBox1.Controls.Add(this.txtSentenceReview);
         this.groupBox1.Controls.Add(this.chkDocumentReview);
         this.groupBox1.Controls.Add(this.chkSentenceReview);
         this.groupBox1.Location = new System.Drawing.Point(340, 2);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(295, 158);
         this.groupBox1.TabIndex = 17;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Review Request";
         // 
         // txtDocumentReview
         // 
         this.txtDocumentReview.Enabled = false;
         this.txtDocumentReview.Location = new System.Drawing.Point(25, 105);
         this.txtDocumentReview.Multiline = true;
         this.txtDocumentReview.Name = "txtDocumentReview";
         this.txtDocumentReview.Size = new System.Drawing.Size(252, 37);
         this.txtDocumentReview.TabIndex = 3;
         // 
         // txtSentenceReview
         // 
         this.txtSentenceReview.Enabled = false;
         this.txtSentenceReview.Location = new System.Drawing.Point(25, 39);
         this.txtSentenceReview.Multiline = true;
         this.txtSentenceReview.Name = "txtSentenceReview";
         this.txtSentenceReview.Size = new System.Drawing.Size(252, 37);
         this.txtSentenceReview.TabIndex = 1;
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
         // txtNotes
         // 
         this.txtNotes.Location = new System.Drawing.Point(3, 192);
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.Size = new System.Drawing.Size(632, 53);
         this.txtNotes.TabIndex = 16;
         // 
         // chkAdherenceBarriers
         // 
         this.chkAdherenceBarriers.AutoSize = true;
         this.chkAdherenceBarriers.Location = new System.Drawing.Point(3, 49);
         this.chkAdherenceBarriers.Name = "chkAdherenceBarriers";
         this.chkAdherenceBarriers.Size = new System.Drawing.Size(131, 17);
         this.chkAdherenceBarriers.TabIndex = 11;
         this.chkAdherenceBarriers.Text = "&3 - Adherence Barriers";
         this.chkAdherenceBarriers.UseVisualStyleBackColor = true;
         // 
         // txtOther
         // 
         this.txtOther.Enabled = false;
         this.txtOther.Location = new System.Drawing.Point(61, 118);
         this.txtOther.Multiline = true;
         this.txtOther.Name = "txtOther";
         this.txtOther.Size = new System.Drawing.Size(256, 45);
         this.txtOther.TabIndex = 14;
         // 
         // chkOther
         // 
         this.chkOther.AutoSize = true;
         this.chkOther.Location = new System.Drawing.Point(3, 118);
         this.chkOther.Name = "chkOther";
         this.chkOther.Size = new System.Drawing.Size(52, 17);
         this.chkOther.TabIndex = 13;
         this.chkOther.Text = "&Other";
         this.chkOther.UseVisualStyleBackColor = true;
         this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
         // 
         // chkAmbiguous
         // 
         this.chkAmbiguous.AutoSize = true;
         this.chkAmbiguous.Location = new System.Drawing.Point(3, 95);
         this.chkAmbiguous.Name = "chkAmbiguous";
         this.chkAmbiguous.Size = new System.Drawing.Size(93, 17);
         this.chkAmbiguous.TabIndex = 12;
         this.chkAmbiguous.Text = "&5 - Ambiguous";
         this.chkAmbiguous.UseVisualStyleBackColor = true;
         // 
         // chkStatedNonAdherence
         // 
         this.chkStatedNonAdherence.AutoSize = true;
         this.chkStatedNonAdherence.Location = new System.Drawing.Point(3, 26);
         this.chkStatedNonAdherence.Name = "chkStatedNonAdherence";
         this.chkStatedNonAdherence.Size = new System.Drawing.Size(149, 17);
         this.chkStatedNonAdherence.TabIndex = 10;
         this.chkStatedNonAdherence.Text = "&2 - Stated Non-adherence";
         this.chkStatedNonAdherence.UseVisualStyleBackColor = true;
         // 
         // chkStatedAdherence
         // 
         this.chkStatedAdherence.AutoSize = true;
         this.chkStatedAdherence.Location = new System.Drawing.Point(3, 3);
         this.chkStatedAdherence.Name = "chkStatedAdherence";
         this.chkStatedAdherence.Size = new System.Drawing.Size(127, 17);
         this.chkStatedAdherence.TabIndex = 9;
         this.chkStatedAdherence.Text = "&1 - Stated Adherence";
         this.chkStatedAdherence.UseVisualStyleBackColor = true;
         // 
         // chkAdherenceAssistance
         // 
         this.chkAdherenceAssistance.AutoSize = true;
         this.chkAdherenceAssistance.Location = new System.Drawing.Point(3, 72);
         this.chkAdherenceAssistance.Name = "chkAdherenceAssistance";
         this.chkAdherenceAssistance.Size = new System.Drawing.Size(147, 17);
         this.chkAdherenceAssistance.TabIndex = 18;
         this.chkAdherenceAssistance.Text = "&4 - Adherence Assistance";
         this.chkAdherenceAssistance.UseVisualStyleBackColor = true;
         // 
         // MedAdherenceAssessment
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.chkAdherenceAssistance);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(label1);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.chkAdherenceBarriers);
         this.Controls.Add(this.txtOther);
         this.Controls.Add(this.chkOther);
         this.Controls.Add(this.chkAmbiguous);
         this.Controls.Add(this.chkStatedNonAdherence);
         this.Controls.Add(this.chkStatedAdherence);
         this.Name = "MedAdherenceAssessment";
         this.Size = new System.Drawing.Size(642, 251);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtDocumentReview;
      private System.Windows.Forms.TextBox txtSentenceReview;
      private System.Windows.Forms.CheckBox chkDocumentReview;
      private System.Windows.Forms.CheckBox chkSentenceReview;
      private System.Windows.Forms.TextBox txtNotes;
      private System.Windows.Forms.CheckBox chkAdherenceBarriers;
      private System.Windows.Forms.TextBox txtOther;
      private System.Windows.Forms.CheckBox chkOther;
      private System.Windows.Forms.CheckBox chkAmbiguous;
      private System.Windows.Forms.CheckBox chkStatedNonAdherence;
      private System.Windows.Forms.CheckBox chkStatedAdherence;
      private System.Windows.Forms.CheckBox chkAdherenceAssistance;
   }
}
