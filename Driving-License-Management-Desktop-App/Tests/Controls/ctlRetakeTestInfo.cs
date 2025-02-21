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
    public partial class ctlRetakeTestInfo : UserControl
    {
        int _TestAppointmentID = -1;
        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
            set
            {
                _TestAppointmentID = value;
                clsTestAppointment testAppointment = clsTestAppointment.Find(_TestAppointmentID);
                if (testAppointment != null)
                {
                    if (testAppointment.RetakeTestAppInfo != null)
                    {
                        _SetValues(testAppointment);
                    }
                    else
                    {
                        _ResetValues();
                    }
                }
                else
                {
                    _ResetValues();
                }
            }
        }
        void _ResetValues()
        {
            lblAppFees.Text = "???";
            lblTotalFees.Text = "???";
            lblTestAppID.Text = "???";
        }
        clsTestType.enTestType _TestType;
        void _SetValues(clsTestAppointment testAppointment)
        {
            clsTestType.enTestType TestTypeID = testAppointment.TestTypeID;
            lblAppFees.Text = clsTestType.Find((int)TestTypeID).Fees.ToString();
            lblTotalFees.Text = (int.Parse(lblAppFees.Text) + 5).ToString();
            if (testAppointment.RetakeTestAppInfo != null)
            {
                lblTestAppID.Text = testAppointment.RetakeTestAppInfo.ApplicationID.ToString();
            }
        }

        public ctlRetakeTestInfo()
        {
            InitializeComponent();
        }

        private void ctlRetakeTestInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
