namespace Driving_License_Management_Desktop_App.Licenses
{
    partial class frmShowLicenseInfo
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
            this.ctlDriverLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlDriverLicenseInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlDriverLicenseInfo1
            // 
            this.ctlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctlDriverLicenseInfo1.LicenseID = -1;
            this.ctlDriverLicenseInfo1.Location = new System.Drawing.Point(13, 13);
            this.ctlDriverLicenseInfo1.Name = "ctlDriverLicenseInfo1";
            this.ctlDriverLicenseInfo1.Size = new System.Drawing.Size(773, 244);
            this.ctlDriverLicenseInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(695, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctlDriverLicenseInfo1);
            this.Name = "frmShowLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show License Info";
            this.Load += new System.EventHandler(this.frmShowLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlDriverLicenseInfo ctlDriverLicenseInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}