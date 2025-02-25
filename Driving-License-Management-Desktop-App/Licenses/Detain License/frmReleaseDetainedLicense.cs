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
    public partial class frmReleaseDetainedLicense : Form
    {
        int _LicenseID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }
        void _DetainInfoFillBasicInfo(int DetainID = -1)
        {
            lblLicenseID.Text = ctlDriverLicenseInfoWithFilter1.LicenseID.ToString();
            lblDetainDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplicationType.enType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            lblApplicationID.Text = "???";

            clsDetainedLicense detainLicense = clsDetainedLicense.Find(DetainID);
            if (detainLicense != null)
            {
                lblDetainID.Text = detainLicense.DetainID.ToString();
                lblFineFees.Text = detainLicense.FineFees.ToString();
                lbltotalFees.Text = (detainLicense.FineFees + clsApplicationType.Find((int)clsApplicationType.enType.ReleaseDetainedDrivingLicsense).Fees).ToString();
            }
            else
            {
                lblDetainID.Text = "???";
                lblFineFees.Text = "???";
                lbltotalFees.Text = "???";
            }
        }
        void _DetainInfoClear()
        {
            lblApplicationFees.Text = "???";
            lblApplicationID.Text = "???";
            lblCreatedBy.Text = "???";
            lblDetainDate.Text = "???";
            lblDetainID.Text = "???";
            lblFineFees.Text = "???";
            lblLicenseID.Text = "???";
            lbltotalFees.Text = "???";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlDriverLicenseInfoWithFilter1_OnLicenseSelected(object obj)
        {
            ctlDriverLicenseInfoWithFilter Sender = (ctlDriverLicenseInfoWithFilter)obj;
            clsDetainedLicense detainedLicense = clsDetainedLicense.FindByLicenseID(Sender.LicenseID);
            if (detainedLicense != null || !Sender.License.IsActive)
            {
                //License is detained or License is not active
                if (detainedLicense != null)
                {
                    if (!detainedLicense.IsReleased)
                    {
                        //Detained and License is active
                        _DetainInfoFillBasicInfo(detainedLicense.DetainID);
                        lblDetainID.Text = detainedLicense.DetainID.ToString();
                        lblFineFees.Text = detainedLicense.FineFees.ToString();
                        btnRelease.Enabled = true;

                    }
                    else
                    {
                        //Not Detained and License is active
                        _DetainInfoFillBasicInfo();
                        lblDetainID.Text = "???";
                        lblFineFees.Text = "???";
                        btnRelease.Enabled = false;
                    }
                }
                else
                {
                    //Not Detained and License is active
                    _DetainInfoFillBasicInfo();
                    lblDetainID.Text = "???";
                    lblFineFees.Text = "???";
                    btnRelease.Enabled = false;
                }

            }
            else
            {
                //License is not detained and License is active
                _DetainInfoFillBasicInfo();
                btnRelease.Enabled = false;
            }
            llblShowLicenseHistory.Enabled = true;
            llblShowLicenseInfo.Enabled = true;
        }

        private void ctlDriverLicenseInfoWithFilter1_OnWrongSelection(object obj)
        {
            _DetainInfoClear();
            btnRelease.Enabled = false;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseHistory.Enabled = false;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;


            bool IsReleased = ctlDriverLicenseInfoWithFilter1.License.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID); ;

            lblApplicationID.Text = ApplicationID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Failed to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowLicenseInfo.Enabled = true;
            llblShowLicenseHistory.Enabled = true;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_LicenseID == -1)
                ctlDriverLicenseInfoWithFilter1.Focus();
            else
            {
                ctlDriverLicenseInfoWithFilter1.FilterText = _LicenseID.ToString();
                ctlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                ctlDriverLicenseInfoWithFilter1.SearchForLicense();
            }
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctlDriverLicenseInfoWithFilter1.License == null) return; //No license selected()
            new frmShowLicenseInfo(ctlDriverLicenseInfoWithFilter1.License.LicenseID).ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctlDriverLicenseInfoWithFilter1.License == null) return; //No license selected()
            new frmShowLicenseHistory(ctlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonInfo.PersonID).ShowDialog();
        }
    }
}
