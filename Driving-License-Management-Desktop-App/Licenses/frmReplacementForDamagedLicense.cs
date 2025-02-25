using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using Driving_License_Management_Desktop_App.Licenses;
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
    public partial class frmReplacementForDamagedLicense : Form
    {
        clsLicense _License;
        public frmReplacementForDamagedLicense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmShowLicenseHistory(_License.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show new license Info
            if(lblReplacedLicenseID.Text != "???")
            {
                new frmShowLicenseInfo(int.Parse(lblReplacedLicenseID.Text)).ShowDialog();
            }
        }

        private void frmReplacementForDamagedLicense_Load(object sender, EventArgs e)
        {

        }
        clsApplication _Application;
        int _CreateNewApplication()
        {
            _Application = new clsApplication();
            if (rbDamagedLicense.Checked)
            {
                //Damaged License
                _Application.ApplicationTypeID = (int)clsApplicationType.enType.ReplacementForADamagedDrivingLicense;
            }
            else
            {
                //Lost License
                _Application.ApplicationTypeID = (int)clsApplicationType.enType.ReplacementForALostDrivingLicense;
            }
            _Application.ApplicantPersonID = _License.ApplicationInfo.ApplicantPersonID;
            _Application.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _Application.ApplicationDate = DateTime.Now;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = clsApplicationType.Find(_Application.ApplicationTypeID).Fees;
            _Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_Application.Save())
            {
                //MessageBox.Show("Application Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Application Save Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _Application.ApplicationID;
        }
        clsLicense _NewLicense;
        int _CreateNewLicense()
        {
            _NewLicense = new clsLicense();
            _NewLicense.ApplicationID = _Application.ApplicationID;
            _NewLicense.DriverID = _License.DriverID;
            _NewLicense.LicenseClass = _License.LicenseClass;
            _NewLicense.IssueDate = DateTime.Now;
            //get type validity length
            _NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(_License.LicenseClass).DefaultValidityLength);
            _NewLicense.Notes = _License.Notes;
            _NewLicense.PaidFees = _License.PaidFees;
            _NewLicense.IsActive = true;
            if (rbDamagedLicense.Checked)
                _NewLicense.IssueReason = clsLicense.enIssueReason.DamagedReplacement;
            else
                _NewLicense.IssueReason = clsLicense.enIssueReason.LostReplacement;
            _NewLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_NewLicense.Save())
            {
                //MessageBox.Show("License Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("License Save Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _NewLicense.LicenseID;

        }
        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if(_License.IsActive == false)
            {
                MessageBox.Show("License is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Create Application and License
            int ApplicationID = _CreateNewApplication();
            int LicenseID = _CreateNewLicense();
            //Show ApplicationID and LicenseID
            lblLRApplicationID.Text = ApplicationID.ToString();
            lblReplacedLicenseID.Text = LicenseID.ToString();
            //Deactivate Previous License and Complete new License Application
            _Application.SetComplete();
            _License.DeactivateCurrentLicense();
            //Check If Process Succeeded
            if (ApplicationID > 0 && LicenseID > 0)
            {
                llblShowNewLicensesInfo.Enabled = true;
                MessageBox.Show("Replacement Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Replacement Issue Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctlDriverLicenseInfoWithFilter1_OnLicenseSelected(object obj)
        {
            ctlDriverLicenseInfoWithFilter Sender = (ctlDriverLicenseInfoWithFilter)obj;
            _License = Sender.License;
            lblApplicationDate.Text = Sender.License.ApplicationInfo.ApplicationDate.ToString("yyyy/MM/dd");
            lblApplicationFees.Text = Sender.License.ApplicationInfo.PaidFees.ToString();
            lblCreatedBy.Text = Sender.License.ApplicationInfo.CreatedByUserInfo.UserName;
            lblLRApplicationID.Text = "???";
            lblOldLicenseID.Text = Sender.License.LicenseID.ToString();
            lblReplacedLicenseID.Text = "???";
            btnIssueReplacement.Enabled = true;

            if(_License != null)
            {
                if (_License.IsActive)
                {
                    btnIssueReplacement.Enabled = true;
                }
                else
                {
                    btnIssueReplacement.Enabled = false;
                }
            }
            else
            {
                btnIssueReplacement.Enabled = false;
            }
            llblShowNewLicensesInfo.Enabled = false;
        }

        private void ctlDriverLicenseInfoWithFilter1_OnWrongSelection(object obj)
        {
            btnIssueReplacement.Enabled = false;
            llblShowNewLicensesInfo.Enabled = false;
        }
    }
}
