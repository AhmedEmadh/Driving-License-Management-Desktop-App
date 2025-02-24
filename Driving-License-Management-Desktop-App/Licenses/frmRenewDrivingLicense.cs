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
    public partial class frmRenewDrivingLicense : Form
    {
        int _NewLicenseID = -1;
        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {

        }

        private void ctlDriverLicenseInfoWithFilter1_OnLicenseSelected(object obj)
        {
            ctlDriverLicenseInfoWithFilter caller = (ctlDriverLicenseInfoWithFilter)obj;
            if (caller != null)
            {
                ctlApplicationNewLicenseInfo1.LicenseID = ctlDriverLicenseInfoWithFilter1.LicenseID;
                if (caller.License.IsLicenseExpired())
                {
                    if (ctlDriverLicenseInfoWithFilter1.License.IsActive == false)
                    {
                        MessageBox.Show("License is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRenew.Enabled = false;
                        return;
                    }
                    btnRenew.Enabled = true;
                }
                else
                {
                    ctlApplicationNewLicenseInfo1.LicenseID = ctlDriverLicenseInfoWithFilter1.LicenseID;
                    btnRenew.Enabled = false;
                    MessageBox.Show("License is not expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (ctlDriverLicenseInfoWithFilter1.License == null)
            {
                MessageBox.Show("Please select a valid license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctlDriverLicenseInfoWithFilter1.License.IsActive == false)
            {
                MessageBox.Show("License is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense NewLicense =
                ctlDriverLicenseInfoWithFilter1.License.RenewLicense(ctlApplicationNewLicenseInfo1.Notes.Trim(),
                clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            ctlApplicationNewLicenseInfo1.ApplicationID = NewLicense.ApplicationID;
            _NewLicenseID = NewLicense.LicenseID;
            ctlApplicationNewLicenseInfo1.RenewedLicenseID = _NewLicenseID;
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            ctlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void ctlDriverLicenseInfoWithFilter1_OnWrongSelection(object obj)
        {
            btnRenew.Enabled = false;
        }
    }
}
