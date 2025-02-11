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
        int _LoginID = -1;
        public frmAddEditUserInfo()
        {
            InitializeComponent();
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
        }

        private void tabPersonalInfo_Click(object sender, EventArgs e)
        {
            
        }
        void _EnableLoginInfo()
        {
            lblConfirmPassTxt.Enabled = true;
            lblPasswordTxt.Enabled = true;
            lblTitle.Enabled = true;
            lblUserIDTxt.Enabled = true;
            lblUserIDValue.Enabled = true;
            lblUserNameTxt.Enabled = true;

            tbConfirmPassword.Enabled = true;
            tbPassword.Enabled = true;
            tbUserName.Enabled = true;

            cbIsActive.Enabled = true;
        }
        void _DisableLoginInfo()
        {
            lblConfirmPassTxt.Enabled = false;
            lblPasswordTxt.Enabled = false;
            lblTitle.Enabled = false;
            lblUserIDTxt.Enabled = false;
            lblUserIDValue.Enabled = false;
            lblUserNameTxt.Enabled = false;

            tbConfirmPassword.Enabled = false;
            tbPassword.Enabled = false;
            tbUserName.Enabled = false;

            cbIsActive.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //check that person is valid
            if(clsPerson.IsPersonExist(ctlPersonInformationWithFilter1.PersonID))
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAddEditPersonInfo().ShowDialog();
        }
    }
}
