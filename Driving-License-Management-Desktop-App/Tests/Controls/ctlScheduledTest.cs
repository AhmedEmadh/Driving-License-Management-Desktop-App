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

namespace Driving_License_Management_Desktop_App.Tests.Controls
{
    public partial class ctlScheduledTest : UserControl
    {
        clsTestType.enTestType _TestType;
        clsTestType.enTestType TestType
        {
            get
            {
                return _TestType;
            }
            set
            {
                _TestType = value;
                groupBox1.Text = clsTestType.TestTypeToString(_TestType);
                _SetPicture(_TestType);
            }
        }
        int _TestAppointmentID = -1;
        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
            set
            {
                clsTestAppointment testAppointment = clsTestAppointment.Find(value);
                if (testAppointment != null)
                {
                    _TestAppointmentID = value;
                    _SetValues(testAppointment);
                }
                else
                {
                    _TestAppointmentID = -1;
                }

            }
        }
        void _SetValues(clsTestAppointment testAppointment)
        {
            if(testAppointment != null)
            {
                TestType = testAppointment.TestTypeID;
                clsTest test = clsTest.FindByTestAppointmentID(testAppointment.TestAppointmentID);
                lblDate.Text = testAppointment.AppointmentDate.ToString("yyyy-MM-dd");
                lblDClass.Text = testAppointment.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.ClassName.ToString();
                lblDLAppID.Text = testAppointment.LocalDrivingLicenseApplicationID.ToString();
                lblFees.Text = clsTestType.Find((int)TestType).Fees.ToString();
                lblName.Text = testAppointment.LocalDrivingLicenseApplicationInfo.ApplicantfullName.ToString();
                lblTrial.Text = testAppointment.LocalDrivingLicenseApplicationInfo.TotalTrialsPerTest(TestType).ToString();
                if (test != null)
                {
                    lblTestID.Text = test.TestID.ToString();

                }
            }
            else
            {

            }

        }
        void _SetPicture(clsTestType.enTestType testType)
        {
            switch (testType)
            {
                case clsTestType.enTestType.VisionTest:
                    pbTest.Image = Properties.Resources.Vision_512;
                    break;
                case clsTestType.enTestType.WrittenTest:
                    pbTest.Image = Properties.Resources.Written_Test_512;
                    break;
                case clsTestType.enTestType.StreetTest:
                    pbTest.Image = Properties.Resources.driving_test_512;
                    break;
                default:
                    break;
            }
        }
        public ctlScheduledTest()
        {
            InitializeComponent();
        }

        private void ctlScheduledTest_Load(object sender, EventArgs e)
        {

        }

    }
}
