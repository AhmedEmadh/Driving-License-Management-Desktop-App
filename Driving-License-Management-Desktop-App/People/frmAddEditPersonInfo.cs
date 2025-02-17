using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
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
    public partial class frmAddEditPersonInfo : Form
    {

        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;
        private int _PersonID = -1;
        clsPerson _Person;


        public delegate void DataBackEventHandler(object sender, int ID);

        public event DataBackEventHandler DataBack;

        void _SetModeToAddNewMode()
        {
            _Mode = enMode.AddNew;
            lblTitle.Text = "Add New Person";
        }
        void _SetModeToUpdateMode()
        {
            _Mode = enMode.Update;
            lblTitle.Text = "Update Person";
        }

        public frmAddEditPersonInfo()
        {
            InitializeComponent();
        }
        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();
            _SetModeToUpdateMode();
            _PersonID = PersonID;
        }
        private void userControl11_OnClose(object obj)
        {
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;
            dtpDateOfBirth.Value = DateTime.Now;
            rbMale.Enabled = true;
            pbPersonImage.Image = Resources.Male_512;
            llblRemove.Visible = (pbPersonImage.ImageLocation != null);
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
                lblTitle.Text = "Add New Person";
            }
            else
            {
                lblTitle.Text = "Update Person";
                lblPersonIDValue.Text = _PersonID.ToString();
            }

        }
        private void _LoadValues()
        {
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Invalid Person ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            tbFirst.Text = _Person.FirstName;
            tbSecound.Text = _Person.SecondName;
            tbThird.Text = _Person.ThirdName;
            tbForth.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNo;
            tbAddress.Text = _Person.Address;
            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }
        }
        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadValues();

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked == true)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llblRemove.Visible = true;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LinkLabel)sender).Visible = false;
            pbPersonImage.Image = null;
            pbPersonImage.ImageLocation = null;


        }
        private bool _HandlePersonImage()
        {

            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private bool _IsValuesValid()
        {
            if (tbNationalNo.Text == "")
                return false;
            if (tbFirst.Text == "")
                return false;
            if (tbSecound.Text == "")
                return false;
            if (tbForth.Text == "")
                return false;
            if (tbAddress.Text == "")
                return false;
            if (tbPhone.Text == "")
                return false;
            if (cbCountry.Text == "")
                return false;
            return true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValuesValid())
            {
                MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Mode == enMode.AddNew)
                _Person = new clsPerson();
            if (!_HandlePersonImage())
                return;
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;
            _Person.FirstName = tbFirst.Text.Trim();
            _Person.SecondName = tbSecound.Text.Trim();
            _Person.ThirdName = tbThird.Text.Trim();
            _Person.LastName = tbForth.Text.Trim();
            _Person.NationalNo = tbNationalNo.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Address = tbAddress.Text.Trim();
            _Person.Phone = tbPhone.Text.Trim();
            _Person.Gendor = (short)(rbMale.Checked ? 0 : 1);
            _Person.Email = tbEmail.Text.Trim();
            _Person.NationalityCountryID = NationalityCountryID;
            _Person.ImagePath = pbPersonImage.ImageLocation;
            if (_Person.Save())
            {
                lblPersonIDValue.Text = _Person.PersonID.ToString();
                _PersonID = _Person.PersonID;
                //Change form mode to update
                _SetModeToUpdateMode();
                lblTitle.Text = "Update Person";
                MessageBox.Show("Person information saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Trigger the event to send data back to the caller form
                DataBack?.Invoke(this, _PersonID);
            }
            else
            {
                MessageBox.Show("Error in saving person information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void _ValidatingWhiteSpace(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError((TextBox)sender, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((TextBox)sender, string.Empty);
            }
        }
        private void tbFirst_Validating(object sender, CancelEventArgs e)
        {
            _ValidatingWhiteSpace(sender, e);
        }

        private void tbFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void _ValidateNationalNumber(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim() == "")
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider1.SetError(textbox, "This field is required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textbox, null);
            }
            if (clsPerson.IsPersonExist(textbox.Text))
            {
                if (clsPerson.Find(textbox.Text).PersonID != int.Parse(lblPersonIDValue.Text))
                {
                    e.Cancel = true;
                    textbox.Focus();
                    errorProvider1.SetError(textbox, "This national number is already exist");
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textbox, null);
            }
        }
        private void _ValidateEmail(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim() == "")
            {
                return;
            }
            if (!clsValidation.ValidateEmail(textbox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textbox, "Invalid email address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textbox, null);
            }
        }
    }
}
