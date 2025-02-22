namespace Driving_License_Management_Desktop_App
{
    partial class frmScheduleTest
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlScheduleTest1 = new Driving_License_Management_Desktop_App.Tests.Controls.ctlScheduleTest();
            this.gbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRetakeAppFees = new System.Windows.Forms.Label();
            this.lblRetakeTestAppID = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.gbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(248, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 45);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlScheduleTest1
            // 
            this.ctlScheduleTest1.BackColor = System.Drawing.Color.White;
            this.ctlScheduleTest1.Date = new System.DateTime(2025, 2, 22, 20, 22, 31, 279);
            this.ctlScheduleTest1.LocalDrivingLicenseApplicationID = -1;
            this.ctlScheduleTest1.Location = new System.Drawing.Point(13, 13);
            this.ctlScheduleTest1.Name = "ctlScheduleTest1";
            this.ctlScheduleTest1.ScheduleDateEnabled = true;
            this.ctlScheduleTest1.Size = new System.Drawing.Size(348, 449);
            this.ctlScheduleTest1.TabIndex = 9;
            this.ctlScheduleTest1.TestAppointmentID = -1;
            this.ctlScheduleTest1.TestType = Driving_License_Management_BusinessLogic.clsTestType.enTestType.VisionTest;
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.Controls.Add(this.lblTotalFees);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeTestAppID);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeAppFees);
            this.gbRetakeTestInfo.Controls.Add(this.label3);
            this.gbRetakeTestInfo.Controls.Add(this.label2);
            this.gbRetakeTestInfo.Controls.Add(this.label1);
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(13, 354);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(330, 100);
            this.gbRetakeTestInfo.TabIndex = 10;
            this.gbRetakeTestInfo.TabStop = false;
            this.gbRetakeTestInfo.Text = "Retake Test Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "R.App.Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "R.Test.App.ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Fees:";
            // 
            // lblRetakeAppFees
            // 
            this.lblRetakeAppFees.AutoSize = true;
            this.lblRetakeAppFees.Location = new System.Drawing.Point(94, 31);
            this.lblRetakeAppFees.Name = "lblRetakeAppFees";
            this.lblRetakeAppFees.Size = new System.Drawing.Size(28, 16);
            this.lblRetakeAppFees.TabIndex = 14;
            this.lblRetakeAppFees.Text = "???";
            // 
            // lblRetakeTestAppID
            // 
            this.lblRetakeTestAppID.AutoSize = true;
            this.lblRetakeTestAppID.Location = new System.Drawing.Point(106, 57);
            this.lblRetakeTestAppID.Name = "lblRetakeTestAppID";
            this.lblRetakeTestAppID.Size = new System.Drawing.Size(28, 16);
            this.lblRetakeTestAppID.TabIndex = 15;
            this.lblRetakeTestAppID.Text = "???";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(248, 31);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(28, 16);
            this.lblTotalFees.TabIndex = 16;
            this.lblTotalFees.Text = "???";
            // 
            // frmScheduleTest
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(366, 525);
            this.Controls.Add(this.gbRetakeTestInfo);
            this.Controls.Add(this.ctlScheduleTest1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmScheduleTest";
            this.Text = "frmScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Tests.Controls.ctlScheduleTest ctlScheduleTest1;
        private System.Windows.Forms.GroupBox gbRetakeTestInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRetakeTestAppID;
        private System.Windows.Forms.Label lblRetakeAppFees;
    }
}