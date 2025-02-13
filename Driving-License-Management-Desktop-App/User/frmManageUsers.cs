using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.User;
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
        void _SetDefaultFilter()
        {
            cbFilterBy.SelectedIndex = 0;
            tbFilter.Text = "";
            tbFilter.Visible = false;
        }
        void _LoadUsers()
        {
            dgvUsers.DataSource = clsUser.GetAllUsers();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _SetDefaultFilter();
            _LoadUsers();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmAddEditUserInfo().ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Visible = true;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
            new frmUserInfo(UserID).ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddEditUserInfo().ShowDialog();
            _LoadUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
            new frmAddEditUserInfo(UserID).ShowDialog();
            _LoadUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
            clsUser user = clsUser.FindByUserID(UserID);
            if (user != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    clsUser.DeleteUser(UserID);
                    _LoadUsers();
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
            if(clsUser.IsUserExist(UserID))
            {
                new frmChangePassword(UserID).ShowDialog();
                _LoadUsers();
            }
        }
    }
}
