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
    public partial class frmUserInfo : Form
    {
        clsUser _user;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _user = clsUser.FindByUserID(UserID);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            this.CancelButton = btnClose;
            if(_user != null)
            {
                ctlUserCard1.UserID = _user.UserID;
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
