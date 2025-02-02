using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_BusinessLogic
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enGendor { Male = 0, Female = 1 };
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { get; set; }
        public clsCountry CountryInfo { get; set; }
        private string _ImagePath;
        public string ImagePath { get { return _ImagePath; } set { _ImagePath = value; } }
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.NationalNo = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gendor = (short)enGendor.Male;
            this.Address = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.CountryInfo = new clsCountry();
            this.ImagePath = string.Empty;

        }
        private clsPerson(int PersonID, string FirstName, string SecoundName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecoundName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            CountryInfo = clsCountry.Find(this.NationalityCountryID);
            Mode = enMode.Update;
        }
        private bool _AddNewPerson()
        {
            //Call DataAccessLayer
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            //Call DataAccessLayer
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecoundName = "", ThirdName = "", LastName = "", NationalNo = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref SecoundName, ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            if (IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecoundName, ThirdName, LastName, NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "", SecoundName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecoundName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            if (IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecoundName, ThirdName, LastName, NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNewPerson())
                        {
                            this.Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                case enMode.Update:
                    {
                        return _UpdatePerson();
                    }
            }
            return false;
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public bool DeletePerson()
        {
            return clsPersonData.DeletePerson(this.PersonID);
        }
        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

    }
}
