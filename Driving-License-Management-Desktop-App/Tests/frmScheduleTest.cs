using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using Driving_License_Management_Desktop_App.Tests.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmScheduleTest : Form
    {
        int _TestAppointmentID = -1;
        clsTestAppointment _TestAppointment = null;
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;
        clsTestType.enTestType _enTestType;
        int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = null;
        //Update Constructor
        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            ctlScheduleTest1.TestType = (clsTestType.enTestType)_TestAppointment.TestTypeInfo.ID;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            ctlScheduleTest1.LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _enTestType = (clsTestType.enTestType)_TestAppointment.TestTypeInfo.ID;
            //Disable Saving If Locked
            if (_TestAppointment.IsLocked)
            {
                ctlScheduleTest1.ScheduleDateEnabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                ctlScheduleTest1.ScheduleDateEnabled = true;
                btnSave.Enabled = true;
            }
            ctlScheduleTest1.Date = _TestAppointment.AppointmentDate;
            ctlScheduleTest1.TestAppointmentID = _TestAppointment.TestAppointmentID;
            _SetRetakeTestInfo();
        }
        //Add New Constructor
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            ctlScheduleTest1.TestType = testType;
            _enTestType = testType;
            ctlScheduleTest1.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            _TestAppointment = new clsTestAppointment();
            _SetRetakeTestInfo();
        }

        void _SetRetakeTestInfo()
        {
            int RetakeTestApplicationFees = 5;
            lblRetakeAppFees.Text = RetakeTestApplicationFees.ToString();
            clsTestType TestType = clsTestType.Find((int)_enTestType);
            float RetakeFees = TestType.Fees;
            float TotalFees = RetakeFees + RetakeTestApplicationFees;
            lblTotalFees.Text = TotalFees.ToString();
            if (_Mode == enMode.Update)
            {
                if (_TestAppointment.RetakeTestApplicationID > 0)
                    lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                else
                    lblRetakeTestAppID.Text = "???";

            }
            else
            {
                lblRetakeTestAppID.Text = "???";
            }
        }
        void _ResetRetakeTestInfo()
        {
            lblRetakeAppFees.Text = "???";
            lblRetakeTestAppID.Text = "???";
            lblTotalFees.Text = "???";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                _TestAppointment.AppointmentDate = ctlScheduleTest1.Date;

                if (_TestAppointment.Save())
                {
                    MessageBox.Show("Test Scheduled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Schedule Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Add New Mode
                //Create Retake Test Application if retaking
                if (_TestAppointment == null)
                    _TestAppointment = new clsTestAppointment();
                int NumberOfTrials = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_enTestType);
                if (NumberOfTrials > 0)
                {
                    //Creating Retake Test Application
                    int RetakeTestApplicationFees = 5;
                    clsApplication Application = new clsApplication();
                    Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                    Application.ApplicationDate = DateTime.Now;
                    Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                    Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                    Application.LastStatusDate = DateTime.Now;
                    Application.PaidFees = RetakeTestApplicationFees;
                    Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                    Application.Save();
                    //Updating Retake Test Application ID
                    _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;
                }
                else
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                }
                //Prepare Object for saving
                _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
                _TestAppointment.AppointmentDate = ctlScheduleTest1.Date;
                _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _TestAppointment.TestTypeID = _enTestType;
                _TestAppointment.IsLocked = false;
                clsTestType _TestType = clsTestType.Find((int)_enTestType);
                _TestAppointment.PaidFees = _TestType.Fees;
                if (_TestAppointment.Save())
                {
                    MessageBox.Show("Test Scheduled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    _SetRetakeTestInfo();
                    if (_TestAppointment.RetakeTestApplicationID > 0)
                        lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                    else
                        lblRetakeTestAppID.Text = "???";

                }
                else
                {
                    MessageBox.Show("Failed to Schedule Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {

        }
    }
}
