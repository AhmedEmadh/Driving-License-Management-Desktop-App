namespace Driving_License_Management_Desktop_App
{
    partial class frmRenewDrivingLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlDriverLicenseInfoWithFilter1 = new Driving_License_Management_Desktop_App.Licenses.Controls.ctlDriverLicenseInfoWithFilter();
            this.ctlApplicationNewLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlApplicationNewLicenseInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew License Application";
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(517, 684);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(92, 42);
            this.btnRenew.TabIndex = 4;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(635, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 42);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // ctlDriverLicenseInfoWithFilter1
            // 
            this.ctlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(17, 49);
            this.ctlDriverLicenseInfoWithFilter1.Name = "ctlDriverLicenseInfoWithFilter1";
            this.ctlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(766, 328);
            this.ctlDriverLicenseInfoWithFilter1.TabIndex = 7;
            // 
            // ctlApplicationNewLicenseInfo1
            // 
            this.ctlApplicationNewLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctlApplicationNewLicenseInfo1.Location = new System.Drawing.Point(17, 400);
            this.ctlApplicationNewLicenseInfo1.Name = "ctlApplicationNewLicenseInfo1";
            this.ctlApplicationNewLicenseInfo1.Size = new System.Drawing.Size(766, 278);
            this.ctlApplicationNewLicenseInfo1.TabIndex = 2;
            // 
            // frmRenewDrivingLicense
            // 
            this.AcceptButton = this.btnRenew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1005, 732);
            this.Controls.Add(this.ctlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.ctlApplicationNewLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewDrivingLicense";
            this.Text = "frmRenewDrivingLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctlApplicationNewLicenseInfo ctlApplicationNewLicenseInfo1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private Licenses.Controls.ctlDriverLicenseInfoWithFilter ctlDriverLicenseInfoWithFilter1;
    }
}