using Driving_License_Management_BusinessLogic;
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
    public partial class ctlInternationalDrivingLicenseInfo : UserControl
    {
        int _InternationalID;
        clsInternationalLicense _InternationalLicense;
        public int InternationalID
        {
            get
            {
                return _InternationalID;
            }
            set
            {
                _InternationalLicense = clsInternationalLicense.Find(value);
                if (_InternationalLicense != null)
                {
                    _InternationalID = value;
                    _SetValues();
                }
                else
                {
                    _InternationalID = -1;
                }
            }
        }
        void _SetValues()
        {
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString();
            lblDriverID.Text = _InternationalLicense.DriverInfo.DriverID.ToString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString();
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor.ToString();
            lblILicenseID.Text = _InternationalID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive.ToString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToString();
            lblLicenseID.Text = clsLicense.GetActiveLicenseIDByPersonID(_InternationalLicense.DriverInfo.PersonID, 3).ToString();
            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo.ToString();

            pbPicture.Image = LoadImage(_InternationalLicense.DriverInfo.PersonInfo.ImagePath);
            if (pbPicture.Image == null)
            {
                if (_InternationalLicense.DriverInfo.PersonInfo.Gendor == (short)clsPerson.enGendor.Male)
                {
                    pbPicture.Image = Properties.Resources.Male_512;
                }
                else
                {
                    pbPicture.Image = Properties.Resources.Female_512;
                }

            }
        }
        public static Image LoadImage(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            if (!File.Exists(path))
                return null;

            try
            {
                // Open the image file and return the Image object
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading image.", ex);
            }
        }
        public ctlInternationalDrivingLicenseInfo()
        {
            InitializeComponent();
        }
    }
}
