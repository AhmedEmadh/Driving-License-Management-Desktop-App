using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        void AdjustFontAndSize()
        {
            this.Width = (int)(this.Width * (clsSettings.LoginNormalFontSize / 12.0));
            this.Height = (int)(this.Height * (clsSettings.LoginNormalFontSize / 12.0));
            lblTitle.Font = new Font( FontFamily.GenericSansSerif,clsSettings.LoginNormalFontSize + 12);
            label1.Font = new Font(FontFamily.GenericSansSerif, clsSettings.LoginNormalFontSize);
            label2.Font = new Font(FontFamily.GenericSansSerif, clsSettings.LoginNormalFontSize);
            cbRememberMe.Font = new Font(FontFamily.GenericSansSerif, clsSettings.LoginNormalFontSize);
            btnLogin.Font = new Font(FontFamily.GenericSansSerif, clsSettings.LoginNormalFontSize);
            tbUserName.Font = new Font(FontFamily.GenericSansSerif, clsSettings.LoginNormalFontSize);
            tbPassword.Font = new Font(FontFamily.GenericSansSerif, clsSettings.LoginNormalFontSize);
            // Adjust TextBox Size
            tbUserName.Width = 1920;
            tbPassword.Width = 1920;
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            AdjustFontAndSize();

            string username="", password="";
            tbUserName.Focus();
            clsGlobal.GetStoredCredential(ref username, ref password);
            if (!(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)))
            {
                cbRememberMe.Checked = true;
                tbUserName.Text = username;
                tbPassword.Text = password;

            }
            else
            {
                cbRememberMe.Checked = false;
            }
        }
        void _ClearLoginInfo()
        {
            tbUserName.Text = "";
            tbPassword.Text = "";
            cbRememberMe.Checked = false;
            tbUserName.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Invalid Username/Password.","Wrong Credintials",MessageBoxButtons.OK,MessageBoxIcon.Error);
            clsUser user = clsUser.FindByUserNameAndPassword(tbUserName.Text, clsGlobal.ComputeHash(tbPassword.Text));
            if (user != null)
            {
                if (user.IsActive)
                {
                    if (cbRememberMe.Checked == true)
                    {
                        clsGlobal.RememberUsernameAndPassword(tbUserName.Text, tbPassword.Text);
                    }
                    else
                    {
                        clsGlobal.RememberUsernameAndPassword("", "");
                    }
                    clsGlobal.CurrentUser = user;
                    _ClearLoginInfo();
                    new frmMainMenu(this).Show();

                }
                else
                {
                    MessageBox.Show("Your account is not active. Please contact your administrator.", "Account Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ClearLoginInfo();
            }
        }
    }

}


