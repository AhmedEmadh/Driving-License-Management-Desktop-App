namespace Driving_License_Management_Desktop_App.Licenses.Controls
{
    partial class ctlDriverLicenseInfoWithFilter
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
            this.ctlDriverLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlDriverLicenseInfo();
            this.ctlFilterByLicenceID1 = new Driving_License_Management_Desktop_App.ctlFilterByLicenceID();
            this.SuspendLayout();
            // 
            // ctlDriverLicenseInfo1
            // 
            this.ctlDriverLicenseInfo1.Location = new System.Drawing.Point(0, 83);
            this.ctlDriverLicenseInfo1.Name = "ctlDriverLicenseInfo1";
            this.ctlDriverLicenseInfo1.Size = new System.Drawing.Size(775, 244);
            this.ctlDriverLicenseInfo1.TabIndex = 0;
            // 
            // ctlFilterByLicenceID1
            // 
            this.ctlFilterByLicenceID1.Location = new System.Drawing.Point(3, 3);
            this.ctlFilterByLicenceID1.Name = "ctlFilterByLicenceID1";
            this.ctlFilterByLicenceID1.Size = new System.Drawing.Size(415, 82);
            this.ctlFilterByLicenceID1.TabIndex = 1;
            // 
            // ctlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctlFilterByLicenceID1);
            this.Controls.Add(this.ctlDriverLicenseInfo1);
            this.Name = "ctlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(775, 330);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlDriverLicenseInfo ctlDriverLicenseInfo1;
        private ctlFilterByLicenceID ctlFilterByLicenceID1;
    }
}
