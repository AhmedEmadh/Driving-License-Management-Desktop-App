using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App.Tests.Controls
{
    public partial class ctlScheduleTest : UserControl
    {
        clsTestType.enTestType _TestType;
        public clsTestType.enTestType TestType
        {
            get
            {
                return _TestType;
            }
            set
            {
                _TestType = value;
                switch (_TestType)
                {
                    case clsTestType.enTestType.VisionTest:
                        pbTestPicture.Image = Resources.Vision_512;
                        gbTestType.Text = "Vision Test";
                        lblTitle.Text = "Schedule Vision Test";
                        break;
                    case clsTestType.enTestType.WrittenTest:
                        pbTestPicture.Image = Resources.Written_Test_512;
                        gbTestType.Text = "Written Test";
                        lblTitle.Text = "Schedule Written Test";
                        break;
                    case clsTestType.enTestType.StreetTest:
                        pbTestPicture.Image = Resources.Street_Test_32;
                        gbTestType.Text = "Street Test";
                        lblTitle.Text = "Schedule Street Test";
                        break;
                }
            }
        }
        public enum enMode { AddNew, Update };
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        enMode _enMode = enMode.AddNew;
        enCreationMode _enCreationMode = enCreationMode.FirstTimeSchedule;
        int _LocalDrivingLicenseApplicationID = -1;
        public int DrivingLicenseApplicationID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;
            }
            set
            {
                clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(value);
                if (localDrivingLicenseApplication != null)
                {
                    //Application Found
                    _LocalDrivingLicenseApplicationID = localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                    if (!localDrivingLicenseApplication.DoesAttendTestType(TestType))
                    {
                        //First Time Schedule
                        _enCreationMode = enCreationMode.FirstTimeSchedule;
                    }
                    else
                    {
                        //Not First Time
                        if (!localDrivingLicenseApplication.DoesPassTestType(TestType))
                        {
                            //Retake Test
                            _enCreationMode = enCreationMode.RetakeTestSchedule;
                            ctlRetakeTestInfo1.TestType = TestType;
                        }
                        else
                        {
                            //Passed Test Before
                            _enMode = enMode.Update;
                            _enCreationMode = enCreationMode.FirstTimeSchedule;
                        }
                    }
                    _SetValues(value);
                }
                else
                {
                    _LocalDrivingLicenseApplicationID = -1;
                    _ResetValues();
                }
            }
        }
        void _SetValues(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            lblClassID.Text = _LocalDrivingLicenseApplication.LicenseClassID.ToString();
            lblDLAPPID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lblName.Text = _LocalDrivingLicenseApplication.ApplicantfullName.ToString();
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(TestType).ToString();
            if (!_LocalDrivingLicenseApplication.DoesPassTestType(TestType) && _LocalDrivingLicenseApplication.DoesAttendTestType(TestType))
            {
                _enCreationMode = enCreationMode.RetakeTestSchedule;
                ctlRetakeTestInfo1.TestType = TestType;
            }
            else
            {
                _enCreationMode = enCreationMode.FirstTimeSchedule;
            }
        }
        void _ResetValues()
        {
            lblClassID.Text = "???";
            lblDLAPPID.Text = "???";
            lblFees.Text = "???";
            lblName.Text = "???";
            lblTrial.Text = "???";
        }
        public ctlScheduleTest()
        {
            InitializeComponent();
        }

        private void ctlScheduleTest_Load(object sender, EventArgs e)
        {

        }
    }
}
