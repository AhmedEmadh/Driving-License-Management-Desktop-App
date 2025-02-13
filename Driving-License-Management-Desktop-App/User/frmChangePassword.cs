using Driving_License_Management_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App.User
{
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User = clsUser.FindByUserID(UserID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_User != null)
            {
                ctlPersonInformation1.PersonID = _User.PersonID;
                ctlloginInfo1.UserID = _User.UserID;

            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        void _ResetValues()
        {
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPassword.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text == _User.Password)
            {
                if (tbNewPassword.Text == tbConfirmPassword.Text)
                {
                    _User.Password = tbNewPassword.Text;
                    _User.Save();
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetValues();
                tbCurrentPassword.Focus();
            }
        }
    }
}
