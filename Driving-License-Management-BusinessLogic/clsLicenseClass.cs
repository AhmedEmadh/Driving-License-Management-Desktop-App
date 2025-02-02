using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_BusinessLogic
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew, Update };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public float ClassFees { set; get; }

        public clsLicenseClass() 
        {
            LicenseClassID = -1;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            MinimumAllowedAge = 18;
            DefaultValidityLength = 10;
            ClassFees = 0;
            Mode = enMode.AddNew;
        }
        private clsLicenseClass(int LicenseClassID,string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }
        private bool _AddNewLicenseClass()
        {
            //call DataAccess Layer
            int AddedID = clsLicenseClassData.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
            return (AddedID != -1);
        }
        private bool _UpdateLicenseClass()
        {
            //call DataAccess Layer
            return clsLicenseClassData.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            float ClassFees = 0;
            if (clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }
        public static clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1;
            string ClassDescription = string.Empty;
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            float ClassFees = 0;
            if (clsLicenseClassData.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLicenseClass();
            }
            return false;
        }
    }
}
