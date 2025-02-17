namespace Driving_License_Management_Desktop_App.Applications
{
    partial class ctlDrivingLicenseApplicationInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.lblAppliedForLicense = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPassedTests);
            this.groupBox1.Controls.Add(this.lblAppliedForLicense);
            this.groupBox1.Controls.Add(this.lblDLAppID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Location = new System.Drawing.Point(378, 55);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(14, 16);
            this.lblPassedTests.TabIndex = 5;
            this.lblPassedTests.Text = "?";
            // 
            // lblAppliedForLicense
            // 
            this.lblAppliedForLicense.AutoSize = true;
            this.lblAppliedForLicense.Location = new System.Drawing.Point(378, 22);
            this.lblAppliedForLicense.Name = "lblAppliedForLicense";
            this.lblAppliedForLicense.Size = new System.Drawing.Size(28, 16);
            this.lblAppliedForLicense.TabIndex = 4;
            this.lblAppliedForLicense.Text = "???";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Location = new System.Drawing.Point(88, 22);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(28, 16);
            this.lblDLAppID.TabIndex = 3;
            this.lblDLAppID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Passed Tests:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Applied For License:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.App ID:";
            // 
            // ctlDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctlDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(789, 112);
            this.Load += new System.EventHandler(this.ctlDrivingLicenseApplicationInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label lblAppliedForLicense;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
