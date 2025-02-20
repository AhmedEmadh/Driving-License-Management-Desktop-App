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
    public partial class frmVisionTestAppointments : Form
    {
        int _LocalDrivingLicenseApplicationID;
        clsTestType.enTestType TestType;
        public frmVisionTestAppointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            TestType = testType;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmScheduleTest(1).ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTakeTest().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlApplicationInfo1_OnLinkClicked(object obj)
        {
            new frmPersonDetails().ShowDialog();
        }
        void _ReloadData()
        {
            dataGridView1.DataSource = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, TestType);
            lblCount.Text = dataGridView1.Rows.Count.ToString();
        }
        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            ctlApplicationInfo1.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _ReloadData();

        }
    }
}
