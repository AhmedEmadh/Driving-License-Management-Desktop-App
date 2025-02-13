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

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
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
            clsUser user = clsUser.FindByUserNameAndPassword(tbUserName.Text, tbPassword.Text);
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


