using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            //userControl21.Title = "Manage Users";
            userControl21.ButtonValue = "User";
            this.CancelButton = userControl21.CloseButton;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            
        }

        private void userControl21_OnAdd(object obj)
        {
            new frmAddEditUserInfo().ShowDialog();
        }

        private void userControl21_OnClose(object obj)
        {
            this.Close();
        }
    }
}
