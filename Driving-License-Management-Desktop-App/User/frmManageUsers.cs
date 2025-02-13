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
        DataTable _dtAllUsers;
        public frmManageUsers()
        {
            InitializeComponent();
        }
        void _SetDefaultFilter()
        {
            cbFilterBy.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            tbFilter.Text = "";
            tbFilter.Visible = false;
        }
        void _LoadUsers()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 350;

            dgvUsers.Columns[3].HeaderText = "User Name";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 120;

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
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
            cbFilter.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            if (((ComboBox)sender).SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                cbFilter.Visible = false;
            }
            else
            {
                if (((ComboBox)sender).SelectedItem.ToString() == "Is Active")
                {
                    cbFilter.Visible = true;
                    tbFilter.Visible = false;
                }
                else
                {
                    cbFilter.Visible = false;
                    tbFilter.Visible = true;
                }
            }
            if (_dtAllUsers != null)
                lblRecordsCount.Text = _dtAllUsers.DefaultView.Count.ToString();
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
                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    clsUser.DeleteUser(UserID);
                    _LoadUsers();
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
            if (clsUser.IsUserExist(UserID))
            {
                new frmChangePassword(UserID).ShowDialog();
                _LoadUsers();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
            }
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            if (_dtAllUsers != null)
                lblRecordsCount.Text = _dtAllUsers.DefaultView.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllUsers != null)
            {
                switch (((ComboBox)sender).SelectedItem.ToString())
                {
                    case "Yes":
                        _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 1";
                        break;
                    case "No":
                        _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 0";
                        break;
                    default:
                        _dtAllUsers.DefaultView.RowFilter = "";
                        break;
                }
            }
            if (_dtAllUsers != null)
                lblRecordsCount.Text = _dtAllUsers.DefaultView.Count.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "User ID" || cbFilterBy.SelectedItem.ToString() == "PersonID")
            {
                // Allow digits (0-9), Backspace, and Delete
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignore the key press
                }
            }
        }
    }
}

