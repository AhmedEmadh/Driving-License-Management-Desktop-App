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

namespace Driving_License_Management_Desktop_App
{
    public partial class ctlApplicationInfo : UserControl
    {
        public event Action<object> OnLinkClick;
        void OnLinkClick_handler()
        {
            Action<object> handler = OnLinkClick;
            if (handler != null)
            {
                handler(this);
            }
        }

        int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;
        string _PassedTests;

        private string PassedTests
        {
            get
            {
                return PassedTests;
            }
            set
            {
                _PassedTests = value;
            }
        }
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
                    PassedTests = _localDrivingLicenseApplication.GetPassedTestCount().ToString();
                    //new
                    ctlApplicationBasicInfo1.ApplicationID = _localDrivingLicenseApplication.ApplicationID;
                    ctlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
                }
                else
                {
                    _SetValuesToDefault();
                }
            }
        }
        void _SetValuesToDefault()
        {
            //old
            PassedTests = "?";
            //new
            ctlApplicationBasicInfo1.ApplicationID = -1;
            ctlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = -1;
        }
        public event Action<Object> OnLinkClicked;
        void LinkClicked_handler()
        {
            Action<Object> LinkClicked_action = OnLinkClicked;
            if (LinkClicked_action != null)
            {
                LinkClicked_action(this);
            }
        }
        public ctlApplicationInfo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked_handler();
        }

        private void ctlApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctlApplicationBasicInfo1_OnLinkClick(object obj)
        {
            OnLinkClick_handler();
        }
    }
}
