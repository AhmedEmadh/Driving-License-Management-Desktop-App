namespace Driving_License_Management_Desktop_App
{
    partial class frmReplacementForDamagedLicense
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
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblLRApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowNewLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlDriverLicenseInfoWithFilter1 = new Driving_License_Management_Desktop_App.Licenses.Controls.ctlDriverLicenseInfoWithFilter();
            this.gbReplacementFor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Location = new System.Drawing.Point(432, 23);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(343, 67);
            this.gbReplacementFor.TabIndex = 2;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(225, 28);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(103, 20);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(12, 28);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(139, 20);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblOldLicenseID);
            this.groupBox2.Controls.Add(this.lblReplacedLicenseID);
            this.groupBox2.Controls.Add(this.lblApplicationFees);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.lblLRApplicationID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info for License Replacement";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(421, 72);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(28, 16);
            this.lblCreatedBy.TabIndex = 11;
            this.lblCreatedBy.Text = "???";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Location = new System.Drawing.Point(421, 47);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(28, 16);
            this.lblOldLicenseID.TabIndex = 10;
            this.lblOldLicenseID.Text = "???";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(420, 22);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(28, 16);
            this.lblReplacedLicenseID.TabIndex = 9;
            this.lblReplacedLicenseID.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Location = new System.Drawing.Point(129, 72);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(28, 16);
            this.lblApplicationFees.TabIndex = 8;
            this.lblApplicationFees.Text = "???";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Location = new System.Drawing.Point(129, 47);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(28, 16);
            this.lblApplicationDate.TabIndex = 7;
            this.lblApplicationDate.Text = "???";
            // 
            // lblLRApplicationID
            // 
            this.lblLRApplicationID.AutoSize = true;
            this.lblLRApplicationID.Location = new System.Drawing.Point(129, 22);
            this.lblLRApplicationID.Name = "lblLRApplicationID";
            this.lblLRApplicationID.Size = new System.Drawing.Size(28, 16);
            this.lblLRApplicationID.TabIndex = 6;
            this.lblLRApplicationID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Old License ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Replaced License ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.R.Application ID:";
            // 
            // llblShowLicenseHistory
            // 
            this.llblShowLicenseHistory.AutoSize = true;
            this.llblShowLicenseHistory.Location = new System.Drawing.Point(23, 459);
            this.llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            this.llblShowLicenseHistory.Size = new System.Drawing.Size(135, 16);
            this.llblShowLicenseHistory.TabIndex = 4;
            this.llblShowLicenseHistory.TabStop = true;
            this.llblShowLicenseHistory.Text = "Show License History";
            this.llblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llblShowNewLicensesInfo
            // 
            this.llblShowNewLicensesInfo.AutoSize = true;
            this.llblShowNewLicensesInfo.Enabled = false;
            this.llblShowNewLicensesInfo.Location = new System.Drawing.Point(174, 459);
            this.llblShowNewLicensesInfo.Name = "llblShowNewLicensesInfo";
            this.llblShowNewLicensesInfo.Size = new System.Drawing.Size(151, 16);
            this.llblShowNewLicensesInfo.TabIndex = 5;
            this.llblShowNewLicensesInfo.TabStop = true;
            this.llblShowNewLicensesInfo.Text = "Show New Licenses Info";
            this.llblShowNewLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Location = new System.Drawing.Point(524, 459);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(143, 34);
            this.btnIssueReplacement.TabIndex = 7;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(683, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlDriverLicenseInfoWithFilter1
            // 
            this.ctlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctlDriverLicenseInfoWithFilter1.FilterText = "";
            this.ctlDriverLicenseInfoWithFilter1.License = null;
            this.ctlDriverLicenseInfoWithFilter1.LicenseID = -1;
            this.ctlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 14);
            this.ctlDriverLicenseInfoWithFilter1.Name = "ctlDriverLicenseInfoWithFilter1";
            this.ctlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(772, 332);
            this.ctlDriverLicenseInfoWithFilter1.TabIndex = 9;
            this.ctlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<object>(this.ctlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            this.ctlDriverLicenseInfoWithFilter1.OnWrongSelection += new System.Action<object>(this.ctlDriverLicenseInfoWithFilter1_OnWrongSelection);
            // 
            // frmReplacementForDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(796, 505);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.llblShowNewLicensesInfo);
            this.Controls.Add(this.llblShowLicenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmReplacementForDamagedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacement For Damaged License";
            this.Load += new System.EventHandler(this.frmReplacementForDamagedLicense_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLRApplicationID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.LinkLabel llblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llblShowNewLicensesInfo;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.Button btnClose;
        private Licenses.Controls.ctlDriverLicenseInfoWithFilter ctlDriverLicenseInfoWithFilter1;
    }
}