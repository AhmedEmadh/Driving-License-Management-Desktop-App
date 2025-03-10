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
        int _InternationalLicenseID;
        int _LocalDrivingLicenseID = -1;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        public frmNewInternationalLicenseApplication(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmInternationalDriverLicenseInfo(_InternationalLicenseID).ShowDialog();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new frmShowLicenseHistory(ctlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void ctlDriverLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {
            if(_LocalDrivingLicenseID != -1)
            {
                ctlDriverLicenseInfoWithFilter1.FilterText = _LocalDrivingLicenseID.ToString();
                ctlDriverLicenseInfoWithFilter1.LicenseID = _LocalDrivingLicenseID;
                ctlDriverLicenseInfoWithFilter1.FilterEnabled = false;

            }
        }

        private void ctlDriverLicenseInfoWithFilter1_OnLicenseSelected(object obj)
        {
            ctlDriverLicenseInfoWithFilter Sender = (ctlDriverLicenseInfoWithFilter)obj;
            _License = Sender.License;
            _SetValue(_License);
            llblShowLicensesHistory.Enabled = true;
            llblShowLicensesInfo.Enabled = false;
            if (_License.LicenseClass != 3)
            {
                MessageBox.Show("License Class must be 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctlDriverLicenseInfoWithFilter1.License.DriverID);
            if (ActiveInternaionalLicenseID > 0)
            {
                MessageBox.Show($"Driver has an active International License with ID {ActiveInternaionalLicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                btnIssue.Enabled = false;
                llblShowLicensesInfo.Enabled = true;
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
            lblApplicationID.Text = "???";
            lblInternationalLicenseID.Text = "???";
            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblLocalLicenseID.Text = License.LicenseID.ToString();
        }
        void _ApplicationInfoResetValues()
        {
            lblApplicationDate.Text = "???";
            lblCreatedBy.Text = "???";
            lblExpirationDate.Text = "???";
            lblFees.Text = "???";
            lblApplicationID.Text = "???";
            lblInternationalLicenseID.Text = "???";
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
            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicantPersonID = ctlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            InternationalLicense.DriverID = ctlDriverLicenseInfoWithFilter1.License.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctlDriverLicenseInfoWithFilter1.License.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssue.Enabled = false;
            ctlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowLicensesInfo.Enabled = true;
        }
    }
}
