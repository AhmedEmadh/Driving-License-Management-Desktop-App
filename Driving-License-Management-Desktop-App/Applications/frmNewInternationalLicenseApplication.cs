using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using Driving_License_Management_Desktop_App.Licenses.Controls;
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
    public partial class frmNewInternationalLicenseApplication : Form
    {
        clsLicense _License;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new frmInternationalDriverLicenseInfo().ShowDialog();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new frmShowLicenseHistory(ctlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void ctlDriverLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ctlDriverLicenseInfoWithFilter1_OnLicenseSelected(object obj)
        {
            ctlDriverLicenseInfoWithFilter Sender = (ctlDriverLicenseInfoWithFilter)obj;
            _License = Sender.License;
            _SetValue(_License);
            if (_License.LicenseClass != 3)
            {
                MessageBox.Show("License Class must be 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctlDriverLicenseInfoWithFilter1.License.DriverID);
            if (ActiveInternaionalLicenseID == -1)
            {
                MessageBox.Show("Driver has no active International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            btnIssue.Enabled = true;
            

        }
        void _SetValue(clsLicense License)
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = License.ApplicationInfo.CreatedByUserInfo.UserName;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));
            lblFees.Text = clsApplicationType.Find((int)clsApplicationType.enType.NewInternationalLicense).Fees.ToString();
            lblILApplicationID.Text = "???";
            lblILLicenseID.Text = "???";
            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblLocalLicenseID.Text = License.LicenseID.ToString();
        }
        void _ApplicationInfoResetValues()
        {
            lblApplicationDate.Text = "???";
            lblCreatedBy.Text = "???";
            lblExpirationDate.Text = "???";
            lblFees.Text = "???";
            lblILApplicationID.Text = "???";
            lblILLicenseID.Text = "???";
            lblIssueDate.Text = "???";
            lblLocalLicenseID.Text = "???";
        }
        private void ctlDriverLicenseInfoWithFilter1_OnWrongSelection(object obj)
        {
            btnIssue.Enabled = false;
            _ApplicationInfoResetValues();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

        }
    }
}
