namespace VTEClinical
{
    partial class VTEAssessment
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
            System.Windows.Forms.Label label4;
            this.txtDocumentReview = new System.Windows.Forms.TextBox();
            this.radConfirmed = new System.Windows.Forms.RadioButton();
            this.radNegative = new System.Windows.Forms.RadioButton();
            this.radUnsure = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(264, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 13);
            label1.TabIndex = 1;
            label1.Text = "Notes/Comments:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(3, 4);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 13);
            label4.TabIndex = 7;
            label4.Text = "Overall Assessment:";
            // 
            // txtDocumentReview
            // 
            this.txtDocumentReview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentReview.Location = new System.Drawing.Point(267, 20);
            this.txtDocumentReview.Multiline = true;
            this.txtDocumentReview.Name = "txtDocumentReview";
            this.txtDocumentReview.Size = new System.Drawing.Size(262, 84);
            this.txtDocumentReview.TabIndex = 0;
            // 
            // radConfirmed
            // 
            this.radConfirmed.AutoSize = true;
            this.radConfirmed.Location = new System.Drawing.Point(6, 21);
            this.radConfirmed.Name = "radConfirmed";
            this.radConfirmed.Size = new System.Drawing.Size(240, 17);
            this.radConfirmed.TabIndex = 8;
            this.radConfirmed.TabStop = true;
            this.radConfirmed.Text = "Confirmed (positive) mention of qualifying VTE";
            this.radConfirmed.UseVisualStyleBackColor = true;
            // 
            // radNegative
            // 
            this.radNegative.AutoSize = true;
            this.radNegative.Location = new System.Drawing.Point(6, 38);
            this.radNegative.Name = "radNegative";
            this.radNegative.Size = new System.Drawing.Size(234, 17);
            this.radNegative.TabIndex = 9;
            this.radNegative.TabStop = true;
            this.radNegative.Text = "No mention of VTE, or negated mention only";
            this.radNegative.UseVisualStyleBackColor = true;
            // 
            // radUnsure
            // 
            this.radUnsure.AutoSize = true;
            this.radUnsure.Location = new System.Drawing.Point(6, 55);
            this.radUnsure.Name = "radUnsure";
            this.radUnsure.Size = new System.Drawing.Size(148, 17);
            this.radUnsure.TabIndex = 10;
            this.radUnsure.TabStop = true;
            this.radUnsure.Text = "Unsure / unclear of status";
            this.radUnsure.UseVisualStyleBackColor = true;
            // 
            // VTEAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radUnsure);
            this.Controls.Add(this.radNegative);
            this.Controls.Add(this.radConfirmed);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtDocumentReview);
            this.Controls.Add(label1);
            this.Name = "VTEAssessment";
            this.Size = new System.Drawing.Size(532, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumentReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMention;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExclusion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExplicitNegated;
        private System.Windows.Forms.RadioButton radConfirmed;
        private System.Windows.Forms.RadioButton radNegative;
        private System.Windows.Forms.RadioButton radUnsure;
    }
}
