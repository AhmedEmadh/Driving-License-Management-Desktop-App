namespace Driving_License_Management_Desktop_App
{
    partial class frmReleaseDetainedLicense
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
            this.ctlFilterByLicenceID1 = new Driving_License_Management_Desktop_App.ctlFilterByLicenceID();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlDriverLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlDriverLicenseInfo();
            this.ctlDetainInfo1 = new Driving_License_Management_Desktop_App.ctlDetainInfo();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlFilterByLicenceID1
            // 
            this.ctlFilterByLicenceID1.BackColor = System.Drawing.Color.White;
            this.ctlFilterByLicenceID1.Location = new System.Drawing.Point(12, 60);
            this.ctlFilterByLicenceID1.Name = "ctlFilterByLicenceID1";
            this.ctlFilterByLicenceID1.Size = new System.Drawing.Size(415, 82);
            this.ctlFilterByLicenceID1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Detained License";
            // 
            // ctlDriverLicenseInfo1
            // 
            this.ctlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctlDriverLicenseInfo1.Location = new System.Drawing.Point(13, 138);
            this.ctlDriverLicenseInfo1.Name = "ctlDriverLicenseInfo1";
            this.ctlDriverLicenseInfo1.Size = new System.Drawing.Size(773, 244);
            this.ctlDriverLicenseInfo1.TabIndex = 2;
            // 
            // ctlDetainInfo1
            // 
            this.ctlDetainInfo1.BackColor = System.Drawing.Color.White;
            this.ctlDetainInfo1.Location = new System.Drawing.Point(13, 389);
            this.ctlDetainInfo1.Name = "ctlDetainInfo1";
            this.ctlDetainInfo1.Size = new System.Drawing.Size(778, 119);
            this.ctlDetainInfo1.TabIndex = 3;
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(561, 514);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(100, 39);
            this.btnRelease.TabIndex = 4;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(678, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AcceptButton = this.btnRelease;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.ctlDetainInfo1);
            this.Controls.Add(this.ctlDriverLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlFilterByLicenceID1);
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlFilterByLicenceID ctlFilterByLicenceID1;
        private System.Windows.Forms.Label label1;
        private ctlDriverLicenseInfo ctlDriverLicenseInfo1;
        private ctlDetainInfo ctlDetainInfo1;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
    }
}