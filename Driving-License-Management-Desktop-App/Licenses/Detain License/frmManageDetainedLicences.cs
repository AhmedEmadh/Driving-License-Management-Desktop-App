using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmManageDetainedLicences : Form
    {
        DataTable _dtAllDetainedLicences;

        clsLicense _License;

        public frmManageDetainedLicences()
        {
            InitializeComponent();
        }
        int _GetCurrentDataRowLicenseID()
        {
            int CurrentRow = dgvDetainedLicenses.CurrentRow.Index;
            int LicenseID = int.Parse(dgvDetainedLicenses.CurrentRow.Cells[dgvDetainedLicenses.Columns["LicenseID"].Index].Value.ToString());
            return LicenseID;
        }
        void _ReloadData()
        {
            _dtAllDetainedLicences = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtAllDetainedLicences;
            lblRecordsCount.Text = _dtAllDetainedLicences.Rows.Count.ToString();
        }
        private void frmManageDetainedLicences_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbIsReleased.SelectedIndex = 0;
            _ReloadData();
        }

        private void ctlShowDataWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ctlShowDataWithFilter1_OnClose(object obj)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = _GetCurrentDataRowLicenseID();
            _License = clsLicense.Find(LicenseID);
            new frmShowLicenseInfo(LicenseID).ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = _GetCurrentDataRowLicenseID();
            _License = clsLicense.Find(LicenseID);
            new frmPersonDetails(_License.DriverInfo.PersonID).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = _GetCurrentDataRowLicenseID();
            _License = clsLicense.Find(LicenseID);
            new frmShowLicenseHistory(_License.DriverInfo.PersonID).ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = _GetCurrentDataRowLicenseID();
            new frmReleaseDetainedLicense(licenseID).ShowDialog();
            _ReloadData();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            new frmDetainLicense().ShowDialog();
            _ReloadData();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            new frmReleaseDetainedLicense().ShowDialog();
            _ReloadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LicenseID = _GetCurrentDataRowLicenseID();
            _License = clsLicense.Find(LicenseID);


            releaseDetainedLicenseToolStripMenuItem.Enabled = (!(bool)dgvDetainedLicenses.CurrentRow.Cells[dgvDetainedLicenses.Columns["IsReleased"].Index].Value) && _License.IsActive;
        }
        void SetTextBoxAndComboboxVisibility()
        {
            //Enable or disable the search text box
            if (cbFilterBy.SelectedItem.ToString() == "None")
            {
                tbSearch.Visible = false;
            }
            else
            {
                if (cbFilterBy.SelectedItem.ToString() != "Is Released")
                {
                    tbSearch.Visible = true;
                    cbIsReleased.Visible = false;
                    cbIsReleased.SelectedIndex = 0;
                }
                else
                {
                    tbSearch.Visible = false;
                    cbIsReleased.Visible = true;
                }
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                    None
                    Detain ID
                    Is Released
                    National No.
                    Full Name
                    Release Application ID
             */
            SetTextBoxAndComboboxVisibility();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            // Map Selected Filter to real Column name
            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;

                case "Is Released":
                    FilterColumn = "IsReleased";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // Reset the filters if nothing is selected or if the text box is empty
            if (tbSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDetainedLicences.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllDetainedLicences.Rows.Count.ToString();
                return;
            }

            // Apply filtering logic based on the selected column and input
            if ((FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID"))
            {
                // Numeric fields (like Detain ID or Release Application ID)
                _dtAllDetainedLicences.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbSearch.Text.Trim());
            }
            else
            {
                // String fields (like Full Name or National No.)
                _dtAllDetainedLicences.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbSearch.Text.Trim());
            }

            lblRecordsCount.Text = _dtAllDetainedLicences.DefaultView.Count.ToString();
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * combobox values
                None
                Yes
                No
            IsReleased is a boolean field in the database
            */
            if (_dtAllDetainedLicences == null) return;
            switch (cbIsReleased.SelectedItem.ToString())
            {
                case "None":
                    _dtAllDetainedLicences.DefaultView.RowFilter = "";
                    break;
                case "Yes":
                    _dtAllDetainedLicences.DefaultView.RowFilter = "[IsReleased] = True";
                    break;
                case "No":
                    _dtAllDetainedLicences.DefaultView.RowFilter = "[IsReleased] = False";
                    break;
            }

        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "Detain ID")
            {
                // Prevent the user from entering non-numeric characters in numeric fields
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
