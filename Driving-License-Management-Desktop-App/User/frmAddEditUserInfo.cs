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

namespace Driving_License_Management_Desktop_App
{
    public partial class frmAddEditUserInfo : Form
    {
        enum Mode { AddNew, Update };
        Mode _Mode = Mode.AddNew;
        int _LoginID = -1;
        clsUser _User;
        int _UserID;
        public frmAddEditUserInfo()
        {
            InitializeComponent();
            _Mode = Mode.AddNew;
            lblTitle.Text = "Add New User";
        }
        void _FillLoginInfo(clsUser User)
        {
            tbUserName.Text = User.UserName;
            tbPassword.Text = User.Password;
            tbConfirmPassword.Text = User.Password;
            cbIsActive.Checked = User.IsActive;
            lblUserIDValue.Text = User.UserID.ToString();
        }
        public frmAddEditUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User = clsUser.FindByUserID(UserID);
            if (_User != null)
            {
                _Mode = Mode.Update;

            }
            else
            {
                MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_OnClose(object obj)
        {
            this.Close();
        }

        private void frmAddEditUserInfo_Load(object sender, EventArgs e)
        {
            ctlPersonInformationWithFilter1.SelectedIndex = 0;
            if (_Mode == Mode.Update)
            {
                lblTitle.Text = "Update User";
                if (_User != null)
                {
                    ctlPersonInformationWithFilter1.SearchText = _User.PersonID.ToString();
                    ctlPersonInformationWithFilter1.PersonID = _User.PersonID;
                    _LoginID = _UserID;
                    ctlPersonInformationWithFilter1.FilterEnabled = false;
                    _EnableLoginInfo();
                    _FillLoginInfo(_User);
                }
            }

        }

        private void tabPersonalInfo_Click(object sender, EventArgs e)
        {

        }
        void _ClearValues()
        {
            tbUserName.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            cbIsActive.Checked = false;
        }
        void _EnableLoginInfo()
        {
            lblConfirmPassTxt.Enabled = true;
            lblPasswordTxt.Enabled = true;
            lblUserIDTxt.Enabled = true;
            lblUserIDValue.Enabled = true;
            lblUserNameTxt.Enabled = true;

            tbConfirmPassword.Enabled = true;
            tbPassword.Enabled = true;
            tbUserName.Enabled = true;

            cbIsActive.Enabled = true;

            _ClearValues();
        }
        void _DisableLoginInfo()
        {
            lblConfirmPassTxt.Enabled = false;
            lblPasswordTxt.Enabled = false;
            lblUserIDTxt.Enabled = false;
            lblUserIDValue.Enabled = false;
            lblUserNameTxt.Enabled = false;

            tbConfirmPassword.Enabled = false;
            tbPassword.Enabled = false;
            tbUserName.Enabled = false;

            cbIsActive.Enabled = false;

            _ClearValues();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (_Mode == Mode.AddNew)
            {
                //check that person is valid
                if (clsPerson.IsPersonExist(ctlPersonInformationWithFilter1.PersonID))
                {
                    //check that person is not a user
                    if (clsUser.FindByPersonID(ctlPersonInformationWithFilter1.PersonID) == null)
                    {
                        _EnableLoginInfo();
                        _LoginID = ctlPersonInformationWithFilter1.PersonID;
                        tabControl1.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("Person is already a User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _DisableLoginInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Person is not Exist, Please Register Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _DisableLoginInfo();
                }
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_Mode == Mode.AddNew)
            {
                clsUser objUser = new clsUser();
                objUser.PersonID = ctlPersonInformationWithFilter1.PersonID;
                objUser.UserName = tbUserName.Text;
                objUser.Password = tbPassword.Text;

                objUser.IsActive = cbIsActive.Checked;
                if (tbPassword.Text == tbConfirmPassword.Text)
                {
                    if (objUser.Save())
                    {
                        MessageBox.Show("User Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblUserIDValue.Text = objUser.UserID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error in Saving User Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if(tbPassword.Text == tbConfirmPassword.Text)
                {
                    _User.Password = tbPassword.Text;
                    _User.Save();
                    MessageBox.Show("User Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAddEditPersonInfo().ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Mode == Mode.AddNew)
            {
                if (((TabControl)sender).SelectedTab.Text == "Login Info")
                {
                    if (_LoginID != ctlPersonInformationWithFilter1.PersonID)
                    {
                        _DisableLoginInfo();
                    }
                }
            }
        }
    }
}
