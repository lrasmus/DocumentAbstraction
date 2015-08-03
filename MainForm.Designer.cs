namespace MC.MCRF.NLP.DocumentAbstraction
{
   partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.rtbDocument = new System.Windows.Forms.RichTextBox();
            this.cmdPrevious = new System.Windows.Forms.Button();
            this.cmdGoTo = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.lblDocument = new System.Windows.Forms.Label();
            this.cmdJumpSelection = new System.Windows.Forms.Button();
            this.pnlAssessment = new System.Windows.Forms.Panel();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.pnlSentence = new System.Windows.Forms.Panel();
            this.cmdSentenceNext = new System.Windows.Forms.Button();
            this.cmdSentencePrevious = new System.Windows.Forms.Button();
            this.rtbSentence = new System.Windows.Forms.RichTextBox();
            this.cmdDictionaryAddWord = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.pnlSentence.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(9, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 13);
            label1.TabIndex = 0;
            label1.Text = "Document:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(9, 402);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 13);
            label3.TabIndex = 12;
            label3.Text = "Assessment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(9, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 13);
            label2.TabIndex = 12;
            label2.Text = "Sentence:";
            // 
            // rtbDocument
            // 
            this.rtbDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDocument.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDocument.Location = new System.Drawing.Point(12, 29);
            this.rtbDocument.Name = "rtbDocument";
            this.rtbDocument.Size = new System.Drawing.Size(686, 188);
            this.rtbDocument.TabIndex = 1;
            this.rtbDocument.Text = "";
            // 
            // cmdPrevious
            // 
            this.cmdPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrevious.Enabled = false;
            this.cmdPrevious.Location = new System.Drawing.Point(704, 29);
            this.cmdPrevious.Name = "cmdPrevious";
            this.cmdPrevious.Size = new System.Drawing.Size(96, 23);
            this.cmdPrevious.TabIndex = 3;
            this.cmdPrevious.Text = "&Previous Doc";
            this.cmdPrevious.UseVisualStyleBackColor = true;
            this.cmdPrevious.Click += new System.EventHandler(this.cmdPrevious_Click);
            // 
            // cmdGoTo
            // 
            this.cmdGoTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGoTo.Location = new System.Drawing.Point(704, 95);
            this.cmdGoTo.Name = "cmdGoTo";
            this.cmdGoTo.Size = new System.Drawing.Size(96, 23);
            this.cmdGoTo.TabIndex = 5;
            this.cmdGoTo.Text = "&Go To Doc";
            this.cmdGoTo.UseVisualStyleBackColor = true;
            this.cmdGoTo.Click += new System.EventHandler(this.cmdGoTo_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNext.Location = new System.Drawing.Point(704, 58);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(96, 23);
            this.cmdNext.TabIndex = 4;
            this.cmdNext.Text = "&Next Doc";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // lblDocument
            // 
            this.lblDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocument.Location = new System.Drawing.Point(680, 9);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(122, 13);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "Document 0 of 0";
            this.lblDocument.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdJumpSelection
            // 
            this.cmdJumpSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdJumpSelection.Location = new System.Drawing.Point(704, 124);
            this.cmdJumpSelection.Name = "cmdJumpSelection";
            this.cmdJumpSelection.Size = new System.Drawing.Size(96, 23);
            this.cmdJumpSelection.TabIndex = 6;
            this.cmdJumpSelection.Text = "&Jump To Sent.";
            this.cmdJumpSelection.UseVisualStyleBackColor = true;
            this.cmdJumpSelection.Click += new System.EventHandler(this.cmdJumpSelection_Click);
            // 
            // pnlAssessment
            // 
            this.pnlAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAssessment.Location = new System.Drawing.Point(12, 418);
            this.pnlAssessment.Name = "pnlAssessment";
            this.pnlAssessment.Size = new System.Drawing.Size(788, 129);
            this.pnlAssessment.TabIndex = 13;
            // 
            // chkCompleted
            // 
            this.chkCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(709, 200);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(91, 17);
            this.chkCompleted.TabIndex = 14;
            this.chkCompleted.Text = "Review Done";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // pnlSentence
            // 
            this.pnlSentence.Controls.Add(this.cmdSentenceNext);
            this.pnlSentence.Controls.Add(this.cmdSentencePrevious);
            this.pnlSentence.Controls.Add(label2);
            this.pnlSentence.Controls.Add(this.rtbSentence);
            this.pnlSentence.Location = new System.Drawing.Point(0, 223);
            this.pnlSentence.Name = "pnlSentence";
            this.pnlSentence.Size = new System.Drawing.Size(811, 174);
            this.pnlSentence.TabIndex = 15;
            // 
            // cmdSentenceNext
            // 
            this.cmdSentenceNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSentenceNext.Location = new System.Drawing.Point(704, 61);
            this.cmdSentenceNext.Name = "cmdSentenceNext";
            this.cmdSentenceNext.Size = new System.Drawing.Size(96, 23);
            this.cmdSentenceNext.TabIndex = 15;
            this.cmdSentenceNext.Text = "&Forward";
            this.cmdSentenceNext.UseVisualStyleBackColor = true;
            this.cmdSentenceNext.Click += new System.EventHandler(this.cmdSentenceNext_Click);
            // 
            // cmdSentencePrevious
            // 
            this.cmdSentencePrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSentencePrevious.Enabled = false;
            this.cmdSentencePrevious.Location = new System.Drawing.Point(704, 32);
            this.cmdSentencePrevious.Name = "cmdSentencePrevious";
            this.cmdSentencePrevious.Size = new System.Drawing.Size(96, 23);
            this.cmdSentencePrevious.TabIndex = 14;
            this.cmdSentencePrevious.Text = "&Back";
            this.cmdSentencePrevious.UseVisualStyleBackColor = true;
            this.cmdSentencePrevious.Click += new System.EventHandler(this.cmdSentencePrevious_Click);
            // 
            // rtbSentence
            // 
            this.rtbSentence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSentence.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSentence.Location = new System.Drawing.Point(12, 32);
            this.rtbSentence.Name = "rtbSentence";
            this.rtbSentence.Size = new System.Drawing.Size(686, 119);
            this.rtbSentence.TabIndex = 13;
            this.rtbSentence.Text = "";
            // 
            // cmdDictionaryAddWord
            // 
            this.cmdDictionaryAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDictionaryAddWord.Location = new System.Drawing.Point(704, 161);
            this.cmdDictionaryAddWord.Name = "cmdDictionaryAddWord";
            this.cmdDictionaryAddWord.Size = new System.Drawing.Size(96, 23);
            this.cmdDictionaryAddWord.TabIndex = 17;
            this.cmdDictionaryAddWord.Text = "&Dictionary";
            this.cmdDictionaryAddWord.UseVisualStyleBackColor = true;
            this.cmdDictionaryAddWord.Click += new System.EventHandler(this.cmdDictionaryAddWord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 559);
            this.Controls.Add(this.cmdDictionaryAddWord);
            this.Controls.Add(this.pnlSentence);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.pnlAssessment);
            this.Controls.Add(label3);
            this.Controls.Add(this.cmdJumpSelection);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.cmdGoTo);
            this.Controls.Add(this.cmdPrevious);
            this.Controls.Add(label1);
            this.Controls.Add(this.rtbDocument);
            this.Name = "MainForm";
            this.Text = "Document Annotation Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnlSentence.ResumeLayout(false);
            this.pnlSentence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.RichTextBox rtbDocument;
      private System.Windows.Forms.Button cmdPrevious;
      private System.Windows.Forms.Button cmdGoTo;
      private System.Windows.Forms.Button cmdNext;
      private System.Windows.Forms.Label lblDocument;
      private System.Windows.Forms.Button cmdJumpSelection;
      private System.Windows.Forms.Panel pnlAssessment;
      private System.Windows.Forms.CheckBox chkCompleted;
      private System.Windows.Forms.Panel pnlSentence;
      private System.Windows.Forms.Button cmdSentenceNext;
      private System.Windows.Forms.Button cmdSentencePrevious;
      private System.Windows.Forms.RichTextBox rtbSentence;
      private System.Windows.Forms.Button cmdDictionaryAddWord;
   }
}

