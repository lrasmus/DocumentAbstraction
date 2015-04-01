namespace ColonPolypAbstraction
{
    partial class ColonPolypAssessment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txtDocumentReview = new System.Windows.Forms.TextBox();
            this.dgvFindings = new System.Windows.Forms.DataGridView();
            this.cxtGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colLocation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindings)).BeginInit();
            this.cxtGridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(493, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 13);
            label1.TabIndex = 1;
            label1.Text = "Notes/Comments:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 13);
            label2.TabIndex = 3;
            label2.Text = "Colon Polyp Findings:";
            // 
            // txtDocumentReview
            // 
            this.txtDocumentReview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentReview.Location = new System.Drawing.Point(496, 20);
            this.txtDocumentReview.Multiline = true;
            this.txtDocumentReview.Name = "txtDocumentReview";
            this.txtDocumentReview.Size = new System.Drawing.Size(355, 187);
            this.txtDocumentReview.TabIndex = 0;
            // 
            // dgvFindings
            // 
            this.dgvFindings.AllowUserToResizeRows = false;
            this.dgvFindings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFindings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocation,
            this.colType});
            this.dgvFindings.ContextMenuStrip = this.cxtGridMenu;
            this.dgvFindings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFindings.Location = new System.Drawing.Point(3, 20);
            this.dgvFindings.Name = "dgvFindings";
            this.dgvFindings.RowHeadersWidth = 20;
            this.dgvFindings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindings.ShowCellErrors = false;
            this.dgvFindings.ShowCellToolTips = false;
            this.dgvFindings.ShowRowErrors = false;
            this.dgvFindings.Size = new System.Drawing.Size(487, 187);
            this.dgvFindings.TabIndex = 2;
            this.dgvFindings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindings_CellContentClick);
            // 
            // cxtGridMenu
            // 
            this.cxtGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cxtGridMenu.Name = "cxtGridMenu";
            this.cxtGridMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 200;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 200;
            // 
            // ColonPolypAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label2);
            this.Controls.Add(this.dgvFindings);
            this.Controls.Add(this.txtDocumentReview);
            this.Controls.Add(label1);
            this.Name = "ColonPolypAssessment";
            this.Size = new System.Drawing.Size(854, 210);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindings)).EndInit();
            this.cxtGridMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumentReview;
        private System.Windows.Forms.DataGridView dgvFindings;
        private System.Windows.Forms.ContextMenuStrip cxtGridMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
    }
}
