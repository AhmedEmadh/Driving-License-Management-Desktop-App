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
using static Driving_License_Management_BusinessLogic.clsTestType;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmTakeTest : Form
    {
        enum enMode { AddNew, Update };
        enMode _Mode = enMode.AddNew;
        clsTestAppointment _TestAppointment;
        int _TestAppointmentID;
        clsTest _Test = null;
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment != null)
            {
                if (!_TestAppointment.IsLocked)
                {
                    _Mode = enMode.AddNew;
                }
                else
                {
                    _Mode = enMode.Update;
                    _Test = clsTest.FindByTestAppointmentID(_TestAppointmentID);
                }
            }
            ctlScheduledTest1.TestAppointmentID = _TestAppointmentID;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (MessageBox.Show("Are you sure you want to take this test?\nPlease Note that this action cannot be undone", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    
                    clsTest clsTest = new clsTest();
                    clsTest.TestAppointmentID = _TestAppointmentID;
                    clsTest.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                    clsTest.Notes = tbNotes.Text;
                    clsTest.TestResult = rbPass.Checked;
                    if (clsTest.Save())
                    {
                        MessageBox.Show("Test Taken Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctlScheduledTest1.TestID = clsTest.TestID;
                        clsTestAppointment testAppointment = clsTestAppointment.Find(_TestAppointmentID);
                        if (testAppointment != null)
                        {
                            testAppointment.IsLocked = true;
                            testAppointment.Save();
                            btnSave.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to Take Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                clsTest clsTest = clsTest.FindByTestAppointmentID(_TestAppointmentID);
                clsTest.Notes = tbNotes.Text;
                if (clsTest.Save())
                {
                    MessageBox.Show("Test Info Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to Take Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Checked = !_Test.TestResult;
                rbPass.Checked = !rbFail.Checked;
                tbNotes.Text = _Test.Notes;
            }
        }
    }
}
