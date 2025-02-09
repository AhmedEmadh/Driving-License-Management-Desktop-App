using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class ctlPersonInformation : UserControl
    {
        int _ID = -1;
        clsPerson _Person;
        private void _SetDefaultValues()
        {
            lblvName.Text = "???";
            lblvPersonID.Text = "???";
            lblvAddress.Text = "???";
            lblvCountry.Text = "???";
            lblvDateOfBirth.Text = "???";
            lblvEmail.Text = "???";
            lblvNationalNo.Text = "???";
            lblvPhone.Text = "???";
            lblvGender.Text = "???";
            pbPersonPicture.Image = Resources.Male_512;

        }
        public event Action<object> OnPersonSelected;
        void OnPersonSelected_handler()
        {
            Action<object> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(this);
            }
        }
        public event Action<object> OnEditPersonInfo;
        void OnEditPersonInfo_handler()
        {
            Action<object> handler = OnEditPersonInfo;
            if (handler != null)
            {
                handler(this);
            }
        }
        public int PersonID
        {
            get
            {
                return _ID;
            }
            set
            {
                _Person = clsPerson.Find(value);
                if (_Person != null)
                {
                    _ID = value;
                    lblvAddress.Text = _Person.Address;
                    lblvCountry.Text = _Person.CountryInfo.CountryName;
                    lblvDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                    lblvEmail.Text = _Person.Email;
                    lblvName.Text = _Person.FullName;
                    lblvNationalNo.Text = _Person.NationalNo;
                    lblvPersonID.Text = _Person.PersonID.ToString();
                    lblvPhone.Text = _Person.Phone;
                    lblvName.Text = _Person.FullName;
                    lblvPersonID.Text = _Person.PersonID.ToString();
                    lblvGender.Text = clsPerson.GendorToString(_Person.Gendor);
                    if (string.IsNullOrEmpty(_Person.ImagePath))
                    {
                        if (_Person.Gendor == (short)clsPerson.enGendor.Male)
                        {
                            pbPersonPicture.Image = Resources.Male_512;
                        }
                        else
                        {
                            pbPersonPicture.Image = Resources.Female_512;
                        }

                    }
                    else
                    {
                        try
                        {
                            pbPersonPicture.Image = Image.FromFile(_Person.ImagePath);

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Image Not Found");
                        }
                    }
                    OnPersonSelected_handler();
                }
                else
                {
                    _SetDefaultValues();
                }
            }
        }
        public string PersonNationalNo
        {
            get
            {
                if (_Person != null)
                    return lblvNationalNo.Text;
                else
                    return "";
            }
            set
            {
                _Person = clsPerson.Find(value);
                if (_Person != null)
                {
                    _ID = _Person.PersonID;
                    lblvAddress.Text = _Person.Address;
                    lblvCountry.Text = _Person.CountryInfo.CountryName;
                    lblvDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                    lblvEmail.Text = _Person.Email;
                    lblvName.Text = _Person.FullName;
                    lblvNationalNo.Text = _Person.NationalNo;
                    lblvPersonID.Text = _Person.PersonID.ToString();
                    lblvPhone.Text = _Person.Phone;
                    lblvName.Text = _Person.FullName;
                    lblvPersonID.Text = _Person.PersonID.ToString();
                    lblvGender.Text = clsPerson.GendorToString(_Person.Gendor);
                    if (string.IsNullOrEmpty(_Person.ImagePath))
                    {
                        if (_Person.Gendor == (short)clsPerson.enGendor.Male)
                        {
                            pbPersonPicture.Image = Resources.Male_512;
                        }
                        else
                        {
                            pbPersonPicture.Image = Resources.Female_512;
                        }
                    }
                    else
                    {
                        try
                        {
                            pbPersonPicture.Image = Image.FromFile(_Person.ImagePath);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Image Not Found");
                        }
                    }
                    OnPersonSelected_handler();
                }
                else
                {
                    _SetDefaultValues();
                }
            }
        }

        public ctlPersonInformation()
        {
            InitializeComponent();
        }
        public ctlPersonInformation(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }
        private void ctlPersonInformation_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnEditPersonInfo_handler();
            if (_Person != null)
            {
                new frmAddEditPersonInfo(_Person.PersonID).ShowDialog();
                this.PersonID = _Person.PersonID;
            }
            else
            {
                MessageBox.Show("No person selected");
            }
        }
    }
}
