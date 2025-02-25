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

namespace Driving_License_Management_Desktop_App
{
    public partial class ctlDetainInfo : UserControl
    {
        int _detainID = -1;
        clsDetainedLicense _DetainedLicense = null;
        public int DetainID
        {
            get
            {
                return _detainID;
            }
            set
            {
                _DetainedLicense = clsDetainedLicense.Find(value);
                if (_DetainedLicense != null)
                {
                    _detainID = value;
                    lblCreatedBy.Text =  clsLicense.Find(_DetainedLicense.LicenseID).CreatedByUserID.ToString();
                    lblDetainDate.Text = DateTime.Now.ToString();
                    lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                    lblFineFees.Text = _DetainedLicense.FineFees.ToString();
                    lblLicenseID.Text = _DetainedLicense.LicenseID.ToString();
                }
            }
        }
        public void Clear()
        {
            lblCreatedBy.Text = "???";
            lblDetainDate.Text = "???";
            lblDetainID.Text = "???";
            lblFineFees.Text = "???";
            lblLicenseID.Text = "???";
        }
        public ctlDetainInfo()
        {
            InitializeComponent();
        }
    }
}
