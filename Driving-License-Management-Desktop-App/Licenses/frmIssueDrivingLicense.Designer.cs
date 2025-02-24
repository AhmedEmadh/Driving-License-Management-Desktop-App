namespace Driving_License_Management_Desktop_App.Licenses
{
    partial class frmIssueDrivingLicense
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
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.ctlApplicationBasicInfo1 = new Driving_License_Management_Desktop_App.Applications.ctlApplicationBasicInfo();
            this.ctlDrivingLicenseApplicationInfo1 = new Driving_License_Management_Desktop_App.Applications.ctlDrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(13, 277);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 16);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes:";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(66, 277);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(722, 84);
            this.tbNotes.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(598, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(703, 367);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(85, 36);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctlApplicationBasicInfo1
            // 
            this.ctlApplicationBasicInfo1.ApplicationID = 0;
            this.ctlApplicationBasicInfo1.Location = new System.Drawing.Point(13, 109);
            this.ctlApplicationBasicInfo1.Name = "ctlApplicationBasicInfo1";
            this.ctlApplicationBasicInfo1.Size = new System.Drawing.Size(785, 161);
            this.ctlApplicationBasicInfo1.TabIndex = 1;
            // 
            // ctlDrivingLicenseApplicationInfo1
            // 
            this.ctlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = -1;
            this.ctlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 1);
            this.ctlDrivingLicenseApplicationInfo1.Name = "ctlDrivingLicenseApplicationInfo1";
            this.ctlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(789, 112);
            this.ctlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // frmIssueDrivingLicense
            // 
            this.AcceptButton = this.btnIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.ctlApplicationBasicInfo1);
            this.Controls.Add(this.ctlDrivingLicenseApplicationInfo1);
            this.Name = "frmIssueDrivingLicense";
            this.Text = "frmIssueDrivingLicense";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.ctlDrivingLicenseApplicationInfo ctlDrivingLicenseApplicationInfo1;
        private Applications.ctlApplicationBasicInfo ctlApplicationBasicInfo1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
    }
}