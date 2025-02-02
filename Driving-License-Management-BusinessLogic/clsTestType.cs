using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_BusinessLogic
{
    public class clsTestType
    {
        public enum enMode { AddNew, Update };
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest=3};
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }
        public clsTestType()
        {
            this.ID = (int)enTestType.VisionTest;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Fees = 0;
            Mode = enMode.AddNew;
        }
        private clsTestType(int ID,string TestTypeTitle,string Description,float TestTypeFees)
        {
            this.ID = (int)ID;
            this.Title = TestTypeTitle;
            this.Description = Description;
            this.Fees = TestTypeFees;
            Mode = enMode.Update;
        }
        private bool _AddNewTestType()
        {
            int CreatedID = clsTestTypeData.AddNewTestType(this.Title, this.Description, this.Fees);
            return (CreatedID != -1);
        }
        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType(this.ID, this.Title, this.Description, this.Fees);
        }
        public static clsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = string.Empty, TestTypeDescription = string.Empty;
            float TestTypeFees = 0;
            bool isFound = clsTestTypeData.GetTestTypeInfoByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);
            if (isFound) {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllTestTypes()
        {
            DataTable dataTable = clsTestTypeData.GetAllTestTypes();
            return dataTable;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateTestType();
            }
            return false;
        }
    }
}
