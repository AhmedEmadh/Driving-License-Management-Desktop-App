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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            ctlDriverLicenseInfoWithFilter1.Focus();
            this.CancelButton = btnClose;
        }

        private void ctlDriverLicenseInfoWithFilter1_OnLicenseSelected(object obj)
        {
            ctlDriverLicenseInfoWithFilter Sender = (ctlDriverLicenseInfoWithFilter)obj;
            clsDetainedLicense detainedLicense = clsDetainedLicense.FindByLicenseID(Sender.LicenseID);
            if (detainedLicense != null || !Sender.License.IsActive)
            {
                //License is detained or License is not active
                btnDetain.Enabled = false;
                tbFineFees.Enabled = false;
                _DetainInfoFillBasicInfo();
                if (detainedLicense != null)
                {
                    if (!detainedLicense.IsReleased)
                    {
                        lblDetainID.Text = detainedLicense.DetainID.ToString();
                        tbFineFees.Text = detainedLicense.FineFees.ToString();
                        tbFineFees.Enabled = false;
                        btnDetain.Enabled = false;
                    }
                    else
                    {
                        lblDetainID.Text = "???";
                        tbFineFees.Enabled = true;
                        tbFineFees.Text = string.Empty;
                        btnDetain.Enabled = true;
                    }
                }

            }
            else
            {
                //License is not detained and License is active
                btnDetain.Enabled = true;
                tbFineFees.Enabled = true;
                _DetainInfoFillBasicInfo();
            }
            llblShowLicenseHistory.Enabled = true;
            llblShowLicenseInfo.Enabled = true;
        }

        private void ctlDriverLicenseInfoWithFilter1_OnWrongSelection(object obj)
        {
            _DetainInfoClear();
            btnDetain.Enabled = false;
            tbFineFees.Enabled = false;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseHistory.Enabled = false;
        }
        void _DetainInfoFillBasicInfo()
        {
            lblLicenseID.Text = ctlDriverLicenseInfoWithFilter1.LicenseID.ToString();
            lblDetainDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }
        void _DetainInfoClear()
        {
            lblCreatedBy.Text = "???";
            lblDetainDate.Text = "???";
            lblDetainID.Text = "???";
            lblLicenseID.Text = "???";
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Only Digits
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFineFees.Text))
            {
                clsDetainedLicense detainLicense = new clsDetainedLicense();
                detainLicense.LicenseID = ctlDriverLicenseInfoWithFilter1.LicenseID;
                detainLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                detainLicense.FineFees = Convert.ToInt32(tbFineFees.Text);
                if (detainLicense.Save())
                {
                    MessageBox.Show("License Detained Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDetainID.Text = detainLicense.DetainID.ToString();
                    btnDetain.Enabled = false;
                    tbFineFees.Enabled = false;
                }
                else
                {
                    MessageBox.Show("License Detain Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Fine Fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
