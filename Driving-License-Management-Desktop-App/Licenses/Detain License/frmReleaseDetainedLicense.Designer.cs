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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlFilterByLicenceID1
            // 
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
            this.ctlDriverLicenseInfo1.Location = new System.Drawing.Point(13, 138);
            this.ctlDriverLicenseInfo1.Name = "ctlDriverLicenseInfo1";
            this.ctlDriverLicenseInfo1.Size = new System.Drawing.Size(773, 244);
            this.ctlDriverLicenseInfo1.TabIndex = 2;
            // 
            // ctlDetainInfo1
            // 
            this.ctlDetainInfo1.Location = new System.Drawing.Point(13, 389);
            this.ctlDetainInfo1.Name = "ctlDetainInfo1";
            this.ctlDetainInfo1.Size = new System.Drawing.Size(778, 119);
            this.ctlDetainInfo1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Release";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}