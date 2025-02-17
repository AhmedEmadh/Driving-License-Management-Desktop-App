namespace Driving_License_Management_Desktop_App
{
    partial class ctlApplicationInfo
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
            this.ctlDrivingLicenseApplicationInfo1 = new Driving_License_Management_Desktop_App.Applications.ctlDrivingLicenseApplicationInfo();
            this.ctlApplicationBasicInfo1 = new Driving_License_Management_Desktop_App.Applications.ctlApplicationBasicInfo();
            this.SuspendLayout();
            // 
            // ctlDrivingLicenseApplicationInfo1
            // 
            this.ctlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = -1;
            this.ctlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctlDrivingLicenseApplicationInfo1.Name = "ctlDrivingLicenseApplicationInfo1";
            this.ctlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(789, 112);
            this.ctlDrivingLicenseApplicationInfo1.TabIndex = 6;
            // 
            // ctlApplicationBasicInfo1
            // 
            this.ctlApplicationBasicInfo1.ApplicationID = 0;
            this.ctlApplicationBasicInfo1.Location = new System.Drawing.Point(3, 112);
            this.ctlApplicationBasicInfo1.Name = "ctlApplicationBasicInfo1";
            this.ctlApplicationBasicInfo1.Size = new System.Drawing.Size(785, 161);
            this.ctlApplicationBasicInfo1.TabIndex = 6;
            this.ctlApplicationBasicInfo1.OnLinkClick += new System.Action<object>(this.ctlApplicationBasicInfo1_OnLinkClick);
            // 
            // ctlApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.ctlApplicationBasicInfo1);
            this.Name = "ctlApplicationInfo";
            this.Size = new System.Drawing.Size(795, 279);
            this.Load += new System.EventHandler(this.ctlApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Applications.ctlDrivingLicenseApplicationInfo ctlDrivingLicenseApplicationInfo1;
        private Applications.ctlApplicationBasicInfo ctlApplicationBasicInfo1;
    }
}
