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
    public partial class ctlApplicationNewLicenseInfo : UserControl
    {
        int _LicenseID = -1;
        clsLicense _License = null;
        public string Notes
        {
            get
            {
                return tbNotes.Text;
            }
        }
        public int RenewedLicenseID
        {
            get
            {
                if(lblRenewedLicenseID.Text != "???")
                {
                    return Convert.ToInt32(lblRenewedLicenseID.Text);
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                lblRenewedLicenseID.Text = value.ToString();
            }

        }
        public int ApplicationID
        {
            get
            {
                if (lblApplicationID.Text != "???")
                {
                    return Convert.ToInt32(lblApplicationID.Text);
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                lblApplicationID.Text = value.ToString();
            }

        }
        public clsLicense License { get { return _License; }}
        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
            set
            {
                _License = clsLicense.Find(value);
                if(_License != null)
                {
                    _LicenseID = value;
                    _SetValues();
                }
                else
                {
                    _ResetValues();
                }
            }
        }
        void _SetValues()
        {
            if(_License != null)
            {
                lblApplicationDate.Text = _License.ApplicationInfo.ApplicationDate.ToString("yyyy/MM/dd");
                lblApplicationFees.Text = _License.ApplicationInfo.PaidFees.ToString();
                lblApplicationID.Text = _License.ApplicationInfo.ApplicationID.ToString();
                lblCreatedBy.Text = _License.ApplicationInfo.CreatedByUserInfo.UserName;
                lblExpirationDate.Text = _License.ExpirationDate.ToString("yyyy/MM/dd");
                lblIssueDate.Text = _License.IssueDate.ToString("yyyy/MM/dd");
                lblLicenseFees.Text = _License.PaidFees.ToString();
                lblOldLicenseID.Text = _License.LicenseID.ToString();
                lblTotalFees.Text = _License.PaidFees.ToString();
                tbNotes.Text = _License.Notes.ToString();
                lblRenewedLicenseID.Text = "???";
            }
            else
            {
                _ResetValues();
            }
        }
        void _ResetValues()
        {
            lblApplicationDate.Text = "???";
            lblApplicationFees.Text = "???";
            lblApplicationID.Text = "???";
            lblCreatedBy.Text = "???";
            lblExpirationDate.Text = "???";
            lblIssueDate.Text = "???";
            lblLicenseFees.Text = "???";
            lblOldLicenseID.Text = "???";
            lblTotalFees.Text = "???";
            lblRenewedLicenseID.Text = "???";
        }
        public ctlApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
