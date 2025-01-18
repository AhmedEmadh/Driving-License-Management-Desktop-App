namespace Driving_License_Management_Desktop_App
{
    partial class frmDetainLicense
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
            this.ctlFilterByLicenceID1 = new Driving_License_Management_Desktop_App.ctlFilterByLicenceID();
            this.ctlDriverLicenseInfo1 = new Driving_License_Management_Desktop_App.ctlDriverLicenseInfo();
            this.ctlDetainInfo1 = new Driving_License_Management_Desktop_App.ctlDetainInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain License";
            // 
            // ctlFilterByLicenceID1
            // 
            this.ctlFilterByLicenceID1.Location = new System.Drawing.Point(13, 63);
            this.ctlFilterByLicenceID1.Name = "ctlFilterByLicenceID1";
            this.ctlFilterByLicenceID1.Size = new System.Drawing.Size(415, 82);
            this.ctlFilterByLicenceID1.TabIndex = 1;
            // 
            // ctlDriverLicenseInfo1
            // 
            this.ctlDriverLicenseInfo1.Location = new System.Drawing.Point(13, 138);
            this.ctlDriverLicenseInfo1.Name = "ctlDriverLicenseInfo1";
            this.ctlDriverLicenseInfo1.Size = new System.Drawing.Size(775, 244);
            this.ctlDriverLicenseInfo1.TabIndex = 2;
            // 
            // ctlDetainInfo1
            // 
            this.ctlDetainInfo1.Location = new System.Drawing.Point(13, 389);
            this.ctlDetainInfo1.Name = "ctlDetainInfo1";
            this.ctlDetainInfo1.Size = new System.Drawing.Size(775, 117);
            this.ctlDetainInfo1.TabIndex = 3;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.ctlDetainInfo1);
            this.Controls.Add(this.ctlDriverLicenseInfo1);
            this.Controls.Add(this.ctlFilterByLicenceID1);
            this.Controls.Add(this.label1);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctlFilterByLicenceID ctlFilterByLicenceID1;
        private ctlDriverLicenseInfo ctlDriverLicenseInfo1;
        private ctlDetainInfo ctlDetainInfo1;
    }
}