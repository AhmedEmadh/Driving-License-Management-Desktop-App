using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using Driving_License_Management_Desktop_App.Tests.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            ctlScheduleTest1.TestType = (clsTestType.enTestType)_TestAppointment.TestTypeInfo.ID;
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
            ctlScheduleTest1.TestAppointmentID = _TestAppointment.TestAppointmentID;
            _Mode = enMode.Update;
        }
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            ctlScheduleTest1.TestType = testType;
            ctlScheduleTest1.TestAppointmentID = _TestAppointmentID;
            _TestAppointment = new clsTestAppointment();
            _Mode = enMode.AddNew;
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
                //Prepare Object for saving
                _TestAppointment.LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
                _TestAppointment.AppointmentDate = ctlScheduleTest1.Date;
                _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                clsTestType _TestType = clsTestType.Find((int)ctlScheduleTest1.TestType);
                    _TestAppointment.PaidFees = _TestType.Fees;
                if (_TestAppointment.Save())
                {
                    MessageBox.Show("Test Scheduled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
