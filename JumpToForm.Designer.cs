﻿namespace MC.MCRF.NLP.DocumentAbstraction
{
   partial class JumpToForm
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
         this.txtItem = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // cmdOK
         // 
         this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.cmdOK.Location = new System.Drawing.Point(19, 47);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 23);
         this.cmdOK.TabIndex = 1;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // cmdCancel
         // 
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(125, 47);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 23);
         this.cmdCancel.TabIndex = 2;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(66, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Jump to item";
         // 
         // txtItem
         // 
         this.txtItem.Location = new System.Drawing.Point(85, 10);
         this.txtItem.Name = "txtItem";
         this.txtItem.Size = new System.Drawing.Size(112, 20);
         this.txtItem.TabIndex = 0;
         this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
         // 
         // JumpToForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(218, 81);
         this.Controls.Add(this.txtItem);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "JumpToForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Jump To";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button cmdOK;
      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtItem;
   }
}