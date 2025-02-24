using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class ctlDriverLicenseInfo : UserControl
    {
        int _LicenseID = -1;
        clsLicense _License = null;
        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
            set
            {
                _License = clsLicense.Find(value);
                if (_License != null)
                {
                    _LicenseID = value;
                }
                else
                {
                    _LicenseID = -1;
                }
                    _SetValues();
            }
        }
        public clsLicense License
        {
            get
            {
                return _License;
            }
        }
        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pbPicture.Image = Resources.Male_512;
            else
                pbPicture.Image = Resources.Female_512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPicture.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        void _SetValues()
        {
            if (_License != null)
            {
                lblClass.Text = _License.licenseClassInfo.ClassName;
                lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
                lblDriverID.Text = _License.DriverInfo.DriverID.ToString();
                lblExpirationDate.Text = _License.ExpirationDate.ToString();
                lblGender.Text = _License.DriverInfo.PersonInfo.Gendor.ToString();
                lblIsActive.Text = _License.IsActive ? "Yes" : "No";
                lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
                lblIssueDate.Text = _License.IssueDate.ToString();
                lblIssueReason.Text = _License.IssueReason.ToString();
                lblLicenseID.Text = _License.LicenseID.ToString();
                lblName.Text = _License.DriverInfo.PersonInfo.FullName;
                lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo.ToString();
                lblNotes.Text = _License.Notes;
                _LoadPersonImage();
            }
            else
            {
                _ResetValues();
            }
        }
        void _ResetValues()
        {
            lblClass.Text = "???";
            lblDateOfBirth.Text = "???";
            lblDriverID.Text = "???";
            lblExpirationDate.Text = "???";
            lblGender.Text = "???";
            lblIsActive.Text = "???";
            lblIsDetained.Text = "???";
            lblIssueDate.Text = "???";
            lblIssueReason.Text = "???";
            lblLicenseID.Text = "???";
            lblName.Text = "???";
            lblNationalNo.Text = "???";
            lblNotes.Text = "???";
            pbPicture.Image = Resources.Male_512;
        }
        public ctlDriverLicenseInfo()
        {
            InitializeComponent();
        }
    }
}
