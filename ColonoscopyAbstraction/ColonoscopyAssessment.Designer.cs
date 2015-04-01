namespace ColonoscopyAbstraction
{
    partial class ColonoscopyAssessment
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.txtDocumentReview = new System.Windows.Forms.TextBox();
            this.cboScreeningIndication = new System.Windows.Forms.ComboBox();
            this.cboCompleteness = new System.Windows.Forms.ComboBox();
            this.cboPolypCount = new System.Windows.Forms.ComboBox();
            this.cboPolypSize = new System.Windows.Forms.ComboBox();
            this.cboPrepQuality = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(380, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 13);
            label1.TabIndex = 1;
            label1.Text = "Notes/Comments:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 13);
            label2.TabIndex = 2;
            label2.Text = "Screening indication:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(3, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(179, 13);
            label3.TabIndex = 3;
            label3.Text = "Completeness of colonoscopy:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(3, 66);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 13);
            label4.TabIndex = 4;
            label4.Text = ">= 3 polyps";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(3, 96);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 13);
            label5.TabIndex = 5;
            label5.Text = "Any polyp >= 1cm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(3, 125);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 13);
            label6.TabIndex = 6;
            label6.Text = "Prep quality:";
            // 
            // txtDocumentReview
            // 
            this.txtDocumentReview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentReview.Location = new System.Drawing.Point(383, 20);
            this.txtDocumentReview.Multiline = true;
            this.txtDocumentReview.Name = "txtDocumentReview";
            this.txtDocumentReview.Size = new System.Drawing.Size(253, 118);
            this.txtDocumentReview.TabIndex = 0;
            // 
            // cboScreeningIndication
            // 
            this.cboScreeningIndication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScreeningIndication.FormattingEnabled = true;
            this.cboScreeningIndication.Items.AddRange(new object[] {
            "(Unknown)",
            "Screening",
            "Not screening"});
            this.cboScreeningIndication.Location = new System.Drawing.Point(183, 1);
            this.cboScreeningIndication.Name = "cboScreeningIndication";
            this.cboScreeningIndication.Size = new System.Drawing.Size(181, 21);
            this.cboScreeningIndication.TabIndex = 7;
            // 
            // cboCompleteness
            // 
            this.cboCompleteness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompleteness.FormattingEnabled = true;
            this.cboCompleteness.Items.AddRange(new object[] {
            "(Unknown)",
            "Complete",
            "Not Complete"});
            this.cboCompleteness.Location = new System.Drawing.Point(183, 31);
            this.cboCompleteness.Name = "cboCompleteness";
            this.cboCompleteness.Size = new System.Drawing.Size(181, 21);
            this.cboCompleteness.TabIndex = 8;
            // 
            // cboPolypCount
            // 
            this.cboPolypCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPolypCount.FormattingEnabled = true;
            this.cboPolypCount.Items.AddRange(new object[] {
            "(Unknown)",
            "Yes",
            "No"});
            this.cboPolypCount.Location = new System.Drawing.Point(183, 63);
            this.cboPolypCount.Name = "cboPolypCount";
            this.cboPolypCount.Size = new System.Drawing.Size(181, 21);
            this.cboPolypCount.TabIndex = 9;
            // 
            // cboPolypSize
            // 
            this.cboPolypSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPolypSize.FormattingEnabled = true;
            this.cboPolypSize.Items.AddRange(new object[] {
            "(Unknown)",
            "Yes",
            "No"});
            this.cboPolypSize.Location = new System.Drawing.Point(183, 93);
            this.cboPolypSize.Name = "cboPolypSize";
            this.cboPolypSize.Size = new System.Drawing.Size(181, 21);
            this.cboPolypSize.TabIndex = 10;
            // 
            // cboPrepQuality
            // 
            this.cboPrepQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrepQuality.FormattingEnabled = true;
            this.cboPrepQuality.Items.AddRange(new object[] {
            "(Unknown)",
            "Excellent",
            "Good",
            "Fair",
            "Poor",
            "Inadequate",
            "Adequate"});
            this.cboPrepQuality.Location = new System.Drawing.Point(183, 122);
            this.cboPrepQuality.Name = "cboPrepQuality";
            this.cboPrepQuality.Size = new System.Drawing.Size(181, 21);
            this.cboPrepQuality.TabIndex = 11;
            // 
            // ColonoscopyAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboPrepQuality);
            this.Controls.Add(this.cboPolypSize);
            this.Controls.Add(this.cboPolypCount);
            this.Controls.Add(this.cboCompleteness);
            this.Controls.Add(this.cboScreeningIndication);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtDocumentReview);
            this.Controls.Add(label1);
            this.Name = "ColonoscopyAssessment";
            this.Size = new System.Drawing.Size(639, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumentReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMention;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExclusion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExplicitNegated;
        private System.Windows.Forms.ComboBox cboScreeningIndication;
        private System.Windows.Forms.ComboBox cboCompleteness;
        private System.Windows.Forms.ComboBox cboPolypCount;
        private System.Windows.Forms.ComboBox cboPolypSize;
        private System.Windows.Forms.ComboBox cboPrepQuality;
    }
}
