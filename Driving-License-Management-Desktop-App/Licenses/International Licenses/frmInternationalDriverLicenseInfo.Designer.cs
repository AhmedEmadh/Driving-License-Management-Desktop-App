﻿namespace Driving_License_Management_Desktop_App
{
    partial class frmInternationalDriverLicenseInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlInternationalDrivingLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlInternationalDrivingLicenseInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(535, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 51);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driver International License Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ctlInternationalDrivingLicenseInfo1
            // 
            this.ctlInternationalDrivingLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctlInternationalDrivingLicenseInfo1.Location = new System.Drawing.Point(12, 88);
            this.ctlInternationalDrivingLicenseInfo1.Name = "ctlInternationalDrivingLicenseInfo1";
            this.ctlInternationalDrivingLicenseInfo1.Size = new System.Drawing.Size(673, 207);
            this.ctlInternationalDrivingLicenseInfo1.TabIndex = 3;
            // 
            // frmInternationalDriverLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(676, 384);
            this.Controls.Add(this.ctlInternationalDrivingLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmInternationalDriverLicenseInfo";
            this.Text = "frmInternationalDriverLicenseInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private ctlInternationalDrivingLicenseInfo ctlInternationalDrivingLicenseInfo1;
    }
}