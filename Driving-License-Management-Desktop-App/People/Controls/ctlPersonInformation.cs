using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Properties;
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
    public partial class ctlPersonInformation : UserControl
    {
        int _ID = -1;
        clsPerson _Person;
        public int PersonID
        {
            get
            {
                return _ID;
            }
            set 
            {
                _Person = clsPerson.Find(value);
                if(_Person != null)
                {
                    _ID = value;
                    lblCAddress.Text = _Person.Address;
                    lblCCountry.Text = _Person.CountryInfo.CountryName;
                    lblCDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                    lblCEmail.Text = _Person.Email;
                    lblCName.Text = _Person.FullName;
                    lblCNationalNo.Text = _Person.NationalNo;
                    lblCPersonID.Text = _Person.PersonID.ToString();
                    lblCPhone.Text = _Person.Phone;
                    lblvName.Text = _Person.FullName;
                    lblvPersonID.Text = _Person.PersonID.ToString();
                    if(_Person.Gendor == (short)clsPerson.enGendor.Male)
                    {
                        pictureBox1.Image = Resources.Male_512;
                    }
                    else
                    {
                        pictureBox1.Image = Resources.Female_512;
                    }
                }

            }
        }

        public ctlPersonInformation()
        {
            InitializeComponent();
        }

        private void ctlPersonInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
