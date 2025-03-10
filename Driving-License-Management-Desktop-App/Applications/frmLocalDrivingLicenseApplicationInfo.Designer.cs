namespace Driving_License_Management_Desktop_App.Applications
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            this.ctlApplicationInfo1 = new Driving_License_Management_Desktop_App.ctlApplicationInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlApplicationInfo1
            // 
            this.ctlApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctlApplicationInfo1.LocalDrivingLicenseApplicationID = 0;
            this.ctlApplicationInfo1.Location = new System.Drawing.Point(11, 12);
            this.ctlApplicationInfo1.Name = "ctlApplicationInfo1";
            this.ctlApplicationInfo1.Size = new System.Drawing.Size(789, 284);
            this.ctlApplicationInfo1.TabIndex = 0;
            this.ctlApplicationInfo1.OnLinkClicked += new System.Action<object>(this.ctlApplicationInfo1_OnLinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(853, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(801, 293);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctlApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalDrivingLicenseApplicationInfo";
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlApplicationInfo ctlApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}