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
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmTestAppointments : Form
    {
        int _LocalDrivingLicenseApplicationID;
        clsTestType.enTestType _TestType;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public frmTestAppointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            ctlApplicationInfo1.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _TestType = testType;
        }

        private void btnScheduleTest_Click(object sender, EventArgs e)
        {
            // if there is no active scheduled test and passed tests
            if (!_LocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType) && !_LocalDrivingLicenseApplication.DoesPassTestType(_TestType))
            {
                new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType).ShowDialog();
                _ReloadData();

            }
            else
            {
                if (!_LocalDrivingLicenseApplication.DoesPassTestType(_TestType))
                    MessageBox.Show("You have an active test scheduled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("You have already passed this test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTakeTest(_GetCurrentDataRowTestAppointmentID()).ShowDialog();
            _ReloadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlApplicationInfo1_OnLinkClicked(object obj)
        {
            new frmPersonDetails().ShowDialog();
        }
        void _ReloadData()
        {
            dataGridView1.DataSource = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);
            lblCount.Text = dataGridView1.Rows.Count.ToString();
        }
        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            ctlApplicationInfo1.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            lblTitle.Text = clsTestType.TestTypeToString(_TestType) + " Appointments";
            _ReloadData();

        }
        int _GetCurrentDataRowTestAppointmentID()
        {
            int CurrentRow = dataGridView1.CurrentRow.Index;
            int TestAppointmentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            return TestAppointmentID;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmScheduleTest(_GetCurrentDataRowTestAppointmentID()).ShowDialog();
            _ReloadData();
        }
    }
}
