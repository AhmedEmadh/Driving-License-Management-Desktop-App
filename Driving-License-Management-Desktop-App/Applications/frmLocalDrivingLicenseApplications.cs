using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        /*
         None
LocalDrivingLicenseApplicationID
NationalNo
FullName
Status
         */
        private static DataTable _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        private DataTable _dtLocalDrivingLicenseApplications = _dtAllLocalDrivingLicenseApplications.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID", "ClassName", "NationalNo",
                                                       "FullName", "ApplicationDate", "PassedTestCount", "Status");
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVisionTestAppointments().ShowDialog();
        }

        private void ctlManagePersons1_Load(object sender, EventArgs e)
        {

        }

        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _UpdateData();

        }

        private void ctlManagePersons1_OnAdd(object obj)
        {
            new frmNewLocalDrivingLicenseApplication().ShowDialog();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentRow = dgvLocalDrivingLicenseApplications.CurrentRow.Index;
            int ApplicationID = Convert.ToInt32(dgvLocalDrivingLicenseApplications.Rows[CurrentRow].Cells[0].Value);
            new frmLocalDrivingLicenseApplicationInfo(ApplicationID).ShowDialog();

        }
        void _UpdateData()
        {
            dgvLocalDrivingLicenseApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        }
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentRow = dgvLocalDrivingLicenseApplications.CurrentRow.Index;
            int ApplicationID = Convert.ToInt32(dgvLocalDrivingLicenseApplications.Rows[CurrentRow].Cells[0].Value);
            new frmNewLocalDrivingLicenseApplication(ApplicationID).ShowDialog();
            _UpdateData();
        }
        void _ChangeFilterBarVisibility()
        {
            if (cbFilterBy.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Visible = true;
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilterBy.Text != "None");

            if (tbFilter.Visible)
            {
                tbFilter.Text = "";
                tbFilter.Focus();
            }

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {

                case "LocalDrivingLicenseApplicationID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;


                case "FullName":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());
            dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicenseApplications;
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "LocalDrivingLicenseApplicationID")
            {
                // Allow digits (0-9), Backspace, and Delete
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignore the key press
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmNewLocalDrivingLicenseApplication().ShowDialog();
            _UpdateData();
        }
    }
}

