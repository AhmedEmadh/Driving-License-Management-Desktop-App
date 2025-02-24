using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App.Licenses
{
    public partial class frmIssueDrivingLicense : Form
    {
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = null;
        int _LocalDrivingLicenseApplicationID = -1;
        public frmIssueDrivingLicense(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            ctlApplicationBasicInfo1.ApplicationID = _LocalDrivingLicenseApplication.ApplicationID;
            ctlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalDrivingLicenseApplication.IssueLicenseForTheFirstTime(tbNotes.Text, clsGlobal.CurrentUser.UserID);
            if (LicenseID > 0)
            {
                MessageBox.Show($"License Issued Successfully With License ID = {LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("License Issue Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
