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
            int LicenseID = int.Parse(dgvDetainedLicenses.CurrentRow.Cells[1].Value.ToString());
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
            

            releaseDetainedLicenseToolStripMenuItem.Enabled = (!(bool)dgvDetainedLicenses.CurrentRow.Cells[5].Value) && _License.IsActive;
        }
    }
}
