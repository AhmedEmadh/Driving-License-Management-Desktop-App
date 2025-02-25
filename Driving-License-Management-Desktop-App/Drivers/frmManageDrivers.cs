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
    public partial class frmManageDrivers : Form
    {
        DataTable _dtAllDrivers;
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _dtAllDrivers = clsDriver.GetAllDrivers();
            dgvDrivers.DataSource = _dtAllDrivers;
            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();

            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 120;

                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 140;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 320;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 170;

                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 150;
            }

        }

        private void ctlManagePersons1_Load(object sender, EventArgs e)
        {

        }

        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }
        int _GetCurrentDataRowDriverID()
        {
            int CurrentRow = dgvDrivers.CurrentRow.Index;
            int LocalDrivingLicenseApplicationID = int.Parse(dgvDrivers.CurrentRow.Cells[0].Value.ToString());
            return LocalDrivingLicenseApplicationID;
        }
        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = _GetCurrentDataRowDriverID();
            new frmPersonDetails(clsDriver.FindByDriverID(DriverID).PersonInfo.PersonID).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = _GetCurrentDataRowDriverID();

            new frmShowLicenseHistory(clsDriver.FindByDriverID(DriverID).PersonInfo.PersonID).ShowDialog();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbFilterBy.SelectedIndex;
            if (cbFilterBy.Items[selectedIndex].ToString() == "None")
            {
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                //in this case we deal with numbers not string.
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbSearch.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbSearch.Text.Trim());

            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
