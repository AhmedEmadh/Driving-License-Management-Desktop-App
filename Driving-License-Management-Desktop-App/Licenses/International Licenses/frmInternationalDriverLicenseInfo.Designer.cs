namespace Driving_License_Management_Desktop_App
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
            this.ctlInternationalDrivingLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlInternationalDrivingLicenseInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(532, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 51);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlInternationalDrivingLicenseInfo1
            // 
            this.ctlInternationalDrivingLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctlInternationalDrivingLicenseInfo1.InternationalID = -1;
            this.ctlInternationalDrivingLicenseInfo1.Location = new System.Drawing.Point(12, 48);
            this.ctlInternationalDrivingLicenseInfo1.Name = "ctlInternationalDrivingLicenseInfo1";
            this.ctlInternationalDrivingLicenseInfo1.Size = new System.Drawing.Size(641, 194);
            this.ctlInternationalDrivingLicenseInfo1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(122, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 36);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Driver International License Info";
            // 
            // frmInternationalDriverLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(662, 308);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctlInternationalDrivingLicenseInfo1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmInternationalDriverLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Driver License Info";
            this.Load += new System.EventHandler(this.frmInternationalDriverLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private ctlInternationalDrivingLicenseInfo ctlInternationalDrivingLicenseInfo1;
        private System.Windows.Forms.Label lblTitle;
    }
}