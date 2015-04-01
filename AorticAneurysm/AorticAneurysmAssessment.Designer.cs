namespace MC.MCRF.NLP.DocumentAbstraction
{
   partial class AorticAneurysmAssessment
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
         this.chkInvalidKeywords = new System.Windows.Forms.CheckBox();
         this.chkNegation = new System.Windows.Forms.CheckBox();
         this.chkMeasurementDescriptors = new System.Windows.Forms.CheckBox();
         this.chkLocation = new System.Windows.Forms.CheckBox();
         this.chkMeasurement = new System.Windows.Forms.CheckBox();
         this.chkExplicitMention = new System.Windows.Forms.CheckBox();
         this.chkKeywordsRelated = new System.Windows.Forms.CheckBox();
         this.lstUnrelatedTerms = new System.Windows.Forms.ListBox();
         this.lblUnrelated = new System.Windows.Forms.Label();
         this.cmdClearSelection = new System.Windows.Forms.Button();
         this.radSubjectPatient = new System.Windows.Forms.RadioButton();
         this.lblSubject = new System.Windows.Forms.Label();
         this.radSubjectFamilyMember = new System.Windows.Forms.RadioButton();
         this.radSubjectNone = new System.Windows.Forms.RadioButton();
         this.SuspendLayout();
         // 
         // chkInvalidKeywords
         // 
         this.chkInvalidKeywords.AutoSize = true;
         this.chkInvalidKeywords.Enabled = false;
         this.chkInvalidKeywords.Location = new System.Drawing.Point(318, 67);
         this.chkInvalidKeywords.Name = "chkInvalidKeywords";
         this.chkInvalidKeywords.Size = new System.Drawing.Size(294, 17);
         this.chkInvalidKeywords.TabIndex = 27;
         this.chkInvalidKeywords.Text = "Not &all of the keywords are related to the aortic aneurysm";
         this.chkInvalidKeywords.UseVisualStyleBackColor = true;
         this.chkInvalidKeywords.CheckedChanged += new System.EventHandler(this.chkInvalidKeywords_CheckedChanged);
         // 
         // chkNegation
         // 
         this.chkNegation.AutoSize = true;
         this.chkNegation.Enabled = false;
         this.chkNegation.Location = new System.Drawing.Point(18, 67);
         this.chkNegation.Name = "chkNegation";
         this.chkNegation.Size = new System.Drawing.Size(294, 17);
         this.chkNegation.TabIndex = 23;
         this.chkNegation.Text = "The aortic aneurysm is negated (does not e&xist/ruled out)";
         this.chkNegation.UseVisualStyleBackColor = true;
         // 
         // chkMeasurementDescriptors
         // 
         this.chkMeasurementDescriptors.AutoSize = true;
         this.chkMeasurementDescriptors.Enabled = false;
         this.chkMeasurementDescriptors.Location = new System.Drawing.Point(318, 44);
         this.chkMeasurementDescriptors.Name = "chkMeasurementDescriptors";
         this.chkMeasurementDescriptors.Size = new System.Drawing.Size(311, 17);
         this.chkMeasurementDescriptors.TabIndex = 26;
         this.chkMeasurementDescriptors.Text = "&Descriptors about the aneurysm measurement are mentioned";
         this.chkMeasurementDescriptors.UseVisualStyleBackColor = true;
         // 
         // chkLocation
         // 
         this.chkLocation.AutoSize = true;
         this.chkLocation.Enabled = false;
         this.chkLocation.Location = new System.Drawing.Point(18, 44);
         this.chkLocation.Name = "chkLocation";
         this.chkLocation.Size = new System.Drawing.Size(225, 17);
         this.chkLocation.TabIndex = 24;
         this.chkLocation.Text = "The &location of the aneurysm is mentioned";
         this.chkLocation.UseVisualStyleBackColor = true;
         // 
         // chkMeasurement
         // 
         this.chkMeasurement.AutoSize = true;
         this.chkMeasurement.Enabled = false;
         this.chkMeasurement.Location = new System.Drawing.Point(318, 23);
         this.chkMeasurement.Name = "chkMeasurement";
         this.chkMeasurement.Size = new System.Drawing.Size(287, 17);
         this.chkMeasurement.TabIndex = 25;
         this.chkMeasurement.Text = "A n&umerical measurement of the aneurysm is mentioned";
         this.chkMeasurement.UseVisualStyleBackColor = true;
         // 
         // chkExplicitMention
         // 
         this.chkExplicitMention.AutoSize = true;
         this.chkExplicitMention.Enabled = false;
         this.chkExplicitMention.Location = new System.Drawing.Point(18, 23);
         this.chkExplicitMention.Name = "chkExplicitMention";
         this.chkExplicitMention.Size = new System.Drawing.Size(205, 17);
         this.chkExplicitMention.TabIndex = 22;
         this.chkExplicitMention.Text = "Aortic aneurysm is explicitly &mentioned";
         this.chkExplicitMention.UseVisualStyleBackColor = true;
         // 
         // chkKeywordsRelated
         // 
         this.chkKeywordsRelated.AutoSize = true;
         this.chkKeywordsRelated.Location = new System.Drawing.Point(0, 0);
         this.chkKeywordsRelated.Name = "chkKeywordsRelated";
         this.chkKeywordsRelated.Size = new System.Drawing.Size(367, 17);
         this.chkKeywordsRelated.TabIndex = 21;
         this.chkKeywordsRelated.Text = "&Keywords are related to aortic aneurysm (description, measurement, etc.)";
         this.chkKeywordsRelated.UseVisualStyleBackColor = true;
         this.chkKeywordsRelated.CheckedChanged += new System.EventHandler(this.chkKeywordsRelated_CheckedChanged);
         // 
         // lstUnrelatedTerms
         // 
         this.lstUnrelatedTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)));
         this.lstUnrelatedTerms.Enabled = false;
         this.lstUnrelatedTerms.FormattingEnabled = true;
         this.lstUnrelatedTerms.Location = new System.Drawing.Point(423, 90);
         this.lstUnrelatedTerms.Name = "lstUnrelatedTerms";
         this.lstUnrelatedTerms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
         this.lstUnrelatedTerms.Size = new System.Drawing.Size(206, 82);
         this.lstUnrelatedTerms.TabIndex = 29;
         // 
         // lblUnrelated
         // 
         this.lblUnrelated.AutoSize = true;
         this.lblUnrelated.Enabled = false;
         this.lblUnrelated.Location = new System.Drawing.Point(337, 91);
         this.lblUnrelated.Name = "lblUnrelated";
         this.lblUnrelated.Size = new System.Drawing.Size(84, 13);
         this.lblUnrelated.TabIndex = 30;
         this.lblUnrelated.Text = "Unrelated terms:";
         // 
         // cmdClearSelection
         // 
         this.cmdClearSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.cmdClearSelection.Enabled = false;
         this.cmdClearSelection.Location = new System.Drawing.Point(362, 149);
         this.cmdClearSelection.Name = "cmdClearSelection";
         this.cmdClearSelection.Size = new System.Drawing.Size(55, 23);
         this.cmdClearSelection.TabIndex = 31;
         this.cmdClearSelection.Text = "&Reset";
         this.cmdClearSelection.UseVisualStyleBackColor = true;
         this.cmdClearSelection.Click += new System.EventHandler(this.cmdClearSelection_Click);
         // 
         // radSubjectPatient
         // 
         this.radSubjectPatient.AutoSize = true;
         this.radSubjectPatient.Checked = true;
         this.radSubjectPatient.Enabled = false;
         this.radSubjectPatient.Location = new System.Drawing.Point(31, 113);
         this.radSubjectPatient.Name = "radSubjectPatient";
         this.radSubjectPatient.Size = new System.Drawing.Size(58, 17);
         this.radSubjectPatient.TabIndex = 32;
         this.radSubjectPatient.TabStop = true;
         this.radSubjectPatient.Text = "Patient";
         this.radSubjectPatient.UseVisualStyleBackColor = true;
         // 
         // lblSubject
         // 
         this.lblSubject.AutoSize = true;
         this.lblSubject.Enabled = false;
         this.lblSubject.Location = new System.Drawing.Point(15, 97);
         this.lblSubject.Name = "lblSubject";
         this.lblSubject.Size = new System.Drawing.Size(150, 13);
         this.lblSubject.TabIndex = 33;
         this.lblSubject.Text = "Subject of the aortic aneurysm";
         // 
         // radSubjectFamilyMember
         // 
         this.radSubjectFamilyMember.AutoSize = true;
         this.radSubjectFamilyMember.Enabled = false;
         this.radSubjectFamilyMember.Location = new System.Drawing.Point(31, 130);
         this.radSubjectFamilyMember.Name = "radSubjectFamilyMember";
         this.radSubjectFamilyMember.Size = new System.Drawing.Size(95, 17);
         this.radSubjectFamilyMember.TabIndex = 34;
         this.radSubjectFamilyMember.Text = "Family Member";
         this.radSubjectFamilyMember.UseVisualStyleBackColor = true;
         // 
         // radSubjectNone
         // 
         this.radSubjectNone.AutoSize = true;
         this.radSubjectNone.Enabled = false;
         this.radSubjectNone.Location = new System.Drawing.Point(31, 146);
         this.radSubjectNone.Name = "radSubjectNone";
         this.radSubjectNone.Size = new System.Drawing.Size(115, 17);
         this.radSubjectNone.TabIndex = 35;
         this.radSubjectNone.Text = "None/Hypothetical";
         this.radSubjectNone.UseVisualStyleBackColor = true;
         // 
         // AorticAneurysmAssessment
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.radSubjectNone);
         this.Controls.Add(this.radSubjectFamilyMember);
         this.Controls.Add(this.lblSubject);
         this.Controls.Add(this.radSubjectPatient);
         this.Controls.Add(this.cmdClearSelection);
         this.Controls.Add(this.lblUnrelated);
         this.Controls.Add(this.lstUnrelatedTerms);
         this.Controls.Add(this.chkInvalidKeywords);
         this.Controls.Add(this.chkNegation);
         this.Controls.Add(this.chkMeasurementDescriptors);
         this.Controls.Add(this.chkLocation);
         this.Controls.Add(this.chkMeasurement);
         this.Controls.Add(this.chkExplicitMention);
         this.Controls.Add(this.chkKeywordsRelated);
         this.Name = "AorticAneurysmAssessment";
         this.Size = new System.Drawing.Size(644, 181);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.CheckBox chkInvalidKeywords;
      private System.Windows.Forms.CheckBox chkNegation;
      private System.Windows.Forms.CheckBox chkMeasurementDescriptors;
      private System.Windows.Forms.CheckBox chkLocation;
      private System.Windows.Forms.CheckBox chkMeasurement;
      private System.Windows.Forms.CheckBox chkExplicitMention;
      private System.Windows.Forms.CheckBox chkKeywordsRelated;
      private System.Windows.Forms.ListBox lstUnrelatedTerms;
      private System.Windows.Forms.Label lblUnrelated;
      private System.Windows.Forms.Button cmdClearSelection;
      private System.Windows.Forms.RadioButton radSubjectPatient;
      private System.Windows.Forms.Label lblSubject;
      private System.Windows.Forms.RadioButton radSubjectFamilyMember;
      private System.Windows.Forms.RadioButton radSubjectNone;
   }
}
