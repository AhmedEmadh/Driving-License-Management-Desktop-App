using Driving_License_Management_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App.Applications
{
    public partial class ctlDrivingLicenseApplicationInfo : UserControl
    {
        int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplication _localDrivingLicenseApplication = null;
        public int LocalDrivingLicenseApplicationID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;
            }
            set
            {
                _LocalDrivingLicenseApplicationID = value;
                _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
                if (_localDrivingLicenseApplication != null)
                {
                    lblAppliedForLicense.Text = _localDrivingLicenseApplication.LicenseClassInfo.ClassName;
                    lblDLAppID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                    PassedTests = _localDrivingLicenseApplication.GetPassedTestCount();
                }
                else
                {
                    _SetValuesToDefault();
                }
            }
        }
        int _PassedTests;
        int PassedTests
        {
            get
            {
                return _PassedTests;
            }
            set
            {
                _PassedTests = value;
                if (value >= 0)
                {
                    lblPassedTests.Text = _PassedTests + "/3";
                }
                else
                {
                    lblPassedTests.Text = "?/3";
                }
            }
        }
        public ctlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        void _SetValuesToDefault()
        {
            lblAppliedForLicense.Text = "???";
            lblDLAppID.Text = "???";
            PassedTests = -1;
        }
        private void ctlDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
