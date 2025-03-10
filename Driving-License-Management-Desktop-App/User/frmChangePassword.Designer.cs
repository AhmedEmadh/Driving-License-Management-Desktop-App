namespace Driving_License_Management_Desktop_App.User
{
    partial class frmChangePassword
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
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctlloginInfo1 = new Driving_License_Management_Desktop_App.User.ctlloginInfo();
            this.ctlPersonInformation1 = new Driving_License_Management_Desktop_App.ctlPersonInformation();
            this.SuspendLayout();
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(163, 353);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(194, 22);
            this.tbCurrentPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(163, 380);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(194, 22);
            this.tbNewPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(163, 407);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(194, 22);
            this.tbConfirmPassword.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(405, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(538, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctlloginInfo1
            // 
            this.ctlloginInfo1.BackColor = System.Drawing.Color.White;
            this.ctlloginInfo1.Location = new System.Drawing.Point(12, 223);
            this.ctlloginInfo1.Name = "ctlloginInfo1";
            this.ctlloginInfo1.Size = new System.Drawing.Size(640, 93);
            this.ctlloginInfo1.TabIndex = 1;
            this.ctlloginInfo1.UserID = -1;
            // 
            // ctlPersonInformation1
            // 
            this.ctlPersonInformation1.BackColor = System.Drawing.Color.White;
            this.ctlPersonInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctlPersonInformation1.Name = "ctlPersonInformation1";
            this.ctlPersonInformation1.PersonID = -1;
            this.ctlPersonInformation1.PersonNationalNo = "";
            this.ctlPersonInformation1.Size = new System.Drawing.Size(640, 215);
            this.ctlPersonInformation1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.ctlloginInfo1);
            this.Controls.Add(this.ctlPersonInformation1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlPersonInformation ctlPersonInformation1;
        private ctlloginInfo ctlloginInfo1;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}