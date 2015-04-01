namespace eMERGEVTE
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
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.dgvFindings = new System.Windows.Forms.DataGridView();
            this.dgvStandalone = new System.Windows.Forms.DataGridView();
            this.txtDocumentReview = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radDocumentNegative = new System.Windows.Forms.RadioButton();
            this.radUnsure = new System.Windows.Forms.RadioButton();
            this.colSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisorder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMentionNegated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFindingUnrelated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStandalone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExclusions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colStandaloneNegated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStandaloneUnrelated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label1 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandalone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(602, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 13);
            label1.TabIndex = 1;
            label1.Text = "Notes/Comments:";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(this.dgvFindings);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.dgvStandalone);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new System.Drawing.Size(596, 303);
            splitContainer1.SplitterDistance = 151;
            splitContainer1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(6, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(175, 13);
            label2.TabIndex = 10;
            label2.Text = "Disorder and Anatomical Site:";
            // 
            // dgvFindings
            // 
            this.dgvFindings.AllowUserToAddRows = false;
            this.dgvFindings.AllowUserToDeleteRows = false;
            this.dgvFindings.AllowUserToResizeRows = false;
            this.dgvFindings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFindings.CausesValidation = false;
            this.dgvFindings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSite,
            this.colDisorder,
            this.colMentionNegated,
            this.colFindingUnrelated});
            this.dgvFindings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFindings.Location = new System.Drawing.Point(9, 20);
            this.dgvFindings.MultiSelect = false;
            this.dgvFindings.Name = "dgvFindings";
            this.dgvFindings.RowHeadersWidth = 20;
            this.dgvFindings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindings.ShowCellErrors = false;
            this.dgvFindings.ShowCellToolTips = false;
            this.dgvFindings.ShowRowErrors = false;
            this.dgvFindings.Size = new System.Drawing.Size(581, 128);
            this.dgvFindings.TabIndex = 9;
            this.dgvFindings.SelectionChanged += new System.EventHandler(this.dgvFindings_SelectionChanged);
            // 
            // dgvStandalone
            // 
            this.dgvStandalone.AllowUserToAddRows = false;
            this.dgvStandalone.AllowUserToDeleteRows = false;
            this.dgvStandalone.AllowUserToResizeRows = false;
            this.dgvStandalone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStandalone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandalone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStandalone,
            this.colExclusions,
            this.colStandaloneNegated,
            this.colStandaloneUnrelated});
            this.dgvStandalone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvStandalone.Location = new System.Drawing.Point(9, 19);
            this.dgvStandalone.Name = "dgvStandalone";
            this.dgvStandalone.RowHeadersWidth = 20;
            this.dgvStandalone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandalone.ShowCellErrors = false;
            this.dgvStandalone.ShowCellToolTips = false;
            this.dgvStandalone.ShowRowErrors = false;
            this.dgvStandalone.Size = new System.Drawing.Size(581, 126);
            this.dgvStandalone.TabIndex = 11;
            this.dgvStandalone.SelectionChanged += new System.EventHandler(this.dgvFindings_SelectionChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(6, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(180, 13);
            label3.TabIndex = 12;
            label3.Text = "Explicit Stand-Alone Mentions:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(605, 192);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 13);
            label4.TabIndex = 7;
            label4.Text = "Overall Assessment:";
            // 
            // txtDocumentReview
            // 
            this.txtDocumentReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentReview.Location = new System.Drawing.Point(605, 20);
            this.txtDocumentReview.Multiline = true;
            this.txtDocumentReview.Name = "txtDocumentReview";
            this.txtDocumentReview.Size = new System.Drawing.Size(262, 155);
            this.txtDocumentReview.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(608, 209);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(240, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Confirmed (positive) mention of qualifying VTE";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radDocumentNegative
            // 
            this.radDocumentNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radDocumentNegative.AutoSize = true;
            this.radDocumentNegative.Location = new System.Drawing.Point(608, 226);
            this.radDocumentNegative.Name = "radDocumentNegative";
            this.radDocumentNegative.Size = new System.Drawing.Size(234, 17);
            this.radDocumentNegative.TabIndex = 9;
            this.radDocumentNegative.TabStop = true;
            this.radDocumentNegative.Text = "No mention of VTE, or negated mention only";
            this.radDocumentNegative.UseVisualStyleBackColor = true;
            // 
            // radUnsure
            // 
            this.radUnsure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radUnsure.AutoSize = true;
            this.radUnsure.Location = new System.Drawing.Point(608, 243);
            this.radUnsure.Name = "radUnsure";
            this.radUnsure.Size = new System.Drawing.Size(148, 17);
            this.radUnsure.TabIndex = 10;
            this.radUnsure.TabStop = true;
            this.radUnsure.Text = "Unsure / unclear of status";
            this.radUnsure.UseVisualStyleBackColor = true;
            // 
            // colSite
            // 
            this.colSite.HeaderText = "Site";
            this.colSite.Name = "colSite";
            this.colSite.ReadOnly = true;
            this.colSite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSite.Width = 200;
            // 
            // colDisorder
            // 
            this.colDisorder.HeaderText = "Disorder";
            this.colDisorder.Name = "colDisorder";
            this.colDisorder.Width = 200;
            // 
            // colMentionNegated
            // 
            this.colMentionNegated.HeaderText = "Negated";
            this.colMentionNegated.Name = "colMentionNegated";
            this.colMentionNegated.Width = 60;
            // 
            // colFindingUnrelated
            // 
            this.colFindingUnrelated.HeaderText = "Unrelated";
            this.colFindingUnrelated.Name = "colFindingUnrelated";
            this.colFindingUnrelated.Width = 60;
            // 
            // colStandalone
            // 
            this.colStandalone.HeaderText = "Stand-Alone Mention";
            this.colStandalone.Name = "colStandalone";
            this.colStandalone.ReadOnly = true;
            this.colStandalone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStandalone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStandalone.Width = 250;
            // 
            // colExclusions
            // 
            this.colExclusions.HeaderText = "Exclusion Location";
            this.colExclusions.Name = "colExclusions";
            this.colExclusions.Width = 160;
            // 
            // colStandaloneNegated
            // 
            this.colStandaloneNegated.HeaderText = "Negated";
            this.colStandaloneNegated.Name = "colStandaloneNegated";
            this.colStandaloneNegated.Width = 60;
            // 
            // colStandaloneUnrelated
            // 
            this.colStandaloneUnrelated.HeaderText = "Unrelated";
            this.colStandaloneUnrelated.Name = "colStandaloneUnrelated";
            this.colStandaloneUnrelated.Width = 60;
            // 
            // VTEAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radUnsure);
            this.Controls.Add(this.radDocumentNegative);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(label4);
            this.Controls.Add(splitContainer1);
            this.Controls.Add(this.txtDocumentReview);
            this.Controls.Add(label1);
            this.Name = "VTEAssessment";
            this.Size = new System.Drawing.Size(870, 306);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandalone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumentReview;
        private System.Windows.Forms.DataGridView dgvFindings;
        private System.Windows.Forms.DataGridView dgvStandalone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMention;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExclusion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExplicitNegated;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radDocumentNegative;
        private System.Windows.Forms.RadioButton radUnsure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSite;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDisorder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMentionNegated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFindingUnrelated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStandalone;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExclusions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStandaloneNegated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStandaloneUnrelated;
    }
}
