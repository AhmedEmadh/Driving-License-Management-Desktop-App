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
    public partial class ctlloginInfo : UserControl
    {
        int _UserID = -1;
        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                clsUser user = clsUser.FindByUserID(value);
                if(user != null)
                {
                    _UserID = user.UserID;
                    lblUserName.Text = user.UserName;
                    lblUserID.Text = user.UserID.ToString();
                    lblIsActive.Text = user.IsActive ? "Yes" : "No";
                }
                else
                {
                    _ResetValues();
                }
            }
        }
        void _ResetValues()
        {
            lblIsActive.Text = "???";
            lblUserID.Text = "???";
            lblUserName.Text = "???";
        }
        public ctlloginInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctlloginInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
