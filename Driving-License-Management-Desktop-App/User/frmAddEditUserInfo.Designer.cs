namespace Driving_License_Management_Desktop_App
{
    partial class frmAddEditUserInfo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctlPersonInformationWithFilter1 = new Driving_License_Management_Desktop_App.ctlPersonInformationWithFilter();
            this.button5 = new System.Windows.Forms.Button();
            this.tapLoginInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblConfirmPassTxt = new System.Windows.Forms.Label();
            this.lblPasswordTxt = new System.Windows.Forms.Label();
            this.lblUserNameTxt = new System.Windows.Forms.Label();
            this.lblUserIDTxt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tapLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonalInfo);
            this.tabControl1.Controls.Add(this.tapLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 323);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.Controls.Add(this.ctlPersonInformationWithFilter1);
            this.tabPersonalInfo.Controls.Add(this.button5);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(771, 294);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Info";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            this.tabPersonalInfo.Click += new System.EventHandler(this.tabPersonalInfo_Click);
            // 
            // ctlPersonInformationWithFilter1
            // 
            this.ctlPersonInformationWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctlPersonInformationWithFilter1.FilterEnabled = true;
            this.ctlPersonInformationWithFilter1.Location = new System.Drawing.Point(18, 7);
            this.ctlPersonInformationWithFilter1.Name = "ctlPersonInformationWithFilter1";
            this.ctlPersonInformationWithFilter1.PersonID = -1;
            this.ctlPersonInformationWithFilter1.SearchText = "";
            this.ctlPersonInformationWithFilter1.SelectedIndex = -1;
            this.ctlPersonInformationWithFilter1.ShowAddPersonButton = false;
            this.ctlPersonInformationWithFilter1.Size = new System.Drawing.Size(651, 285);
            this.ctlPersonInformationWithFilter1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(687, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tapLoginInfo
            // 
            this.tapLoginInfo.Controls.Add(this.cbIsActive);
            this.tapLoginInfo.Controls.Add(this.tbConfirmPassword);
            this.tapLoginInfo.Controls.Add(this.tbPassword);
            this.tapLoginInfo.Controls.Add(this.tbUserName);
            this.tapLoginInfo.Controls.Add(this.lblUserIDValue);
            this.tapLoginInfo.Controls.Add(this.lblConfirmPassTxt);
            this.tapLoginInfo.Controls.Add(this.lblPasswordTxt);
            this.tapLoginInfo.Controls.Add(this.lblUserNameTxt);
            this.tapLoginInfo.Controls.Add(this.lblUserIDTxt);
            this.tapLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tapLoginInfo.Name = "tapLoginInfo";
            this.tapLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tapLoginInfo.Size = new System.Drawing.Size(771, 294);
            this.tapLoginInfo.TabIndex = 1;
            this.tapLoginInfo.Text = "Login Info";
            this.tapLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Enabled = false;
            this.cbIsActive.Location = new System.Drawing.Point(128, 132);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(79, 20);
            this.cbIsActive.TabIndex = 8;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Enabled = false;
            this.tbConfirmPassword.Location = new System.Drawing.Point(128, 104);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(100, 22);
            this.tbConfirmPassword.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(128, 76);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 6;
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Location = new System.Drawing.Point(128, 48);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 22);
            this.tbUserName.TabIndex = 5;
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Enabled = false;
            this.lblUserIDValue.Location = new System.Drawing.Point(125, 21);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(28, 16);
            this.lblUserIDValue.TabIndex = 4;
            this.lblUserIDValue.Text = "???";
            // 
            // lblConfirmPassTxt
            // 
            this.lblConfirmPassTxt.AutoSize = true;
            this.lblConfirmPassTxt.Enabled = false;
            this.lblConfirmPassTxt.Location = new System.Drawing.Point(7, 107);
            this.lblConfirmPassTxt.Name = "lblConfirmPassTxt";
            this.lblConfirmPassTxt.Size = new System.Drawing.Size(118, 16);
            this.lblConfirmPassTxt.TabIndex = 3;
            this.lblConfirmPassTxt.Text = "Confirm Password:";
            // 
            // lblPasswordTxt
            // 
            this.lblPasswordTxt.AutoSize = true;
            this.lblPasswordTxt.Enabled = false;
            this.lblPasswordTxt.Location = new System.Drawing.Point(7, 82);
            this.lblPasswordTxt.Name = "lblPasswordTxt";
            this.lblPasswordTxt.Size = new System.Drawing.Size(70, 16);
            this.lblPasswordTxt.TabIndex = 2;
            this.lblPasswordTxt.Text = "Password:";
            // 
            // lblUserNameTxt
            // 
            this.lblUserNameTxt.AutoSize = true;
            this.lblUserNameTxt.Enabled = false;
            this.lblUserNameTxt.Location = new System.Drawing.Point(7, 54);
            this.lblUserNameTxt.Name = "lblUserNameTxt";
            this.lblUserNameTxt.Size = new System.Drawing.Size(76, 16);
            this.lblUserNameTxt.TabIndex = 1;
            this.lblUserNameTxt.Text = "UserName:";
            // 
            // lblUserIDTxt
            // 
            this.lblUserIDTxt.AutoSize = true;
            this.lblUserIDTxt.Enabled = false;
            this.lblUserIDTxt.Location = new System.Drawing.Point(7, 21);
            this.lblUserIDTxt.Name = "lblUserIDTxt";
            this.lblUserIDTxt.Size = new System.Drawing.Size(52, 16);
            this.lblUserIDTxt.TabIndex = 0;
            this.lblUserIDTxt.Text = "UserID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(622, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(703, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(269, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 46);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Add New User";
            // 
            // frmAddEditUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(803, 431);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditUserInfo";
            this.Text = "frmAddEditUserInfo";
            this.Load += new System.EventHandler(this.frmAddEditUserInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tapLoginInfo.ResumeLayout(false);
            this.tapLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tapLoginInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblConfirmPassTxt;
        private System.Windows.Forms.Label lblPasswordTxt;
        private System.Windows.Forms.Label lblUserNameTxt;
        private System.Windows.Forms.Label lblUserIDTxt;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Button button5;
        private ctlPersonInformationWithFilter ctlPersonInformationWithFilter1;
        private System.Windows.Forms.Label lblTitle;
    }
}