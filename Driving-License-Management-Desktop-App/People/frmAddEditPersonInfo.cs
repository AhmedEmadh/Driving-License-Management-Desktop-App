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
    public partial class frmAddEditPersonInfo : Form
    {

        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;
        private int _PersonID = -1;
        clsPerson _Person;
        public frmAddEditPersonInfo()
        {
            InitializeComponent();
        }
        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        private void userControl11_OnClose(object obj)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows) {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;
            dtpDateOfBirth.Value = DateTime.Now;
            rbMale.Enabled = true;
            pictureBox1.Image = Resources.Male_512;
            llblRemove.Visible = (pictureBox1.ImageLocation != null);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-150);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            cbCountry.SelectedIndex = cbCountry.FindString("Egypt");

            tbFirst.Text = string.Empty;
            tbSecound.Text = string.Empty;
            tbThird.Text = string.Empty;
            tbForth.Text = string.Empty;
            tbNationalNo.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbEmail.Text = string.Empty;

            if (_Mode == enMode.AddNew)
            {
                lblAddNewPerson.Text = "Add New Person";
            }
            else
            {
                lblAddNewPerson.Text = "Update Person";
            }




        }
        private void _LoadValues()
        {
            clsPerson person = clsPerson.Find(_PersonID);
            if(_PersonID == -1)
            {
                MessageBox.Show("Invalid Person ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            tbFirst.Text = person.FirstName;
            tbSecound.Text = person.SecondName;
            tbThird.Text = person.ThirdName;
            tbForth.Text = person.LastName;
            tbNationalNo.Text = person.NationalNo;
            tbAddress.Text = person.Address;
            tbPhone.Text = person.Phone;
            tbEmail.Text = person.Email;
            dtpDateOfBirth.Value = person.DateOfBirth;
            cbCountry.SelectedIndex = cbCountry.FindString(person.CountryInfo.CountryName);
            if (person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

        }
        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadValues();
            
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked == true)
                pictureBox1.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFemale.Checked == true)
                pictureBox1.Image = Resources.Female_512;
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
