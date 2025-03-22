using Driving_License_Management_BusinessLogic;
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

namespace Driving_License_Management_Desktop_App.Applications
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        int _ApplicationID;
        public frmLocalDrivingLicenseApplicationInfo(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;

        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ctlApplicationInfo1.LocalDrivingLicenseApplicationID = _ApplicationID;
        }

        //private void ctlApplicationInfo1_OnLinkClicked(object obj)
        //{
        //    clsLocalDrivingLicenseApplication localApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_ApplicationID);
        //    int PersonID = localApplication.ApplicantPersonInfo.PersonID;
        //    new frmPersonDetails(PersonID).ShowDialog();
        //}
    }
}
