using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_clsLicenseClassData
    {
        public static void Test_GetLicenseClassInfoByID()
        {
            //clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            int LicenseClassID = -1;
            byte MinimumAllowedAge = byte.MaxValue;
            byte DefaultValidityLength = byte.MaxValue;
            float ClassFees = -1;
            string ClassName = null, ClassDescription = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License Class ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClassID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                Console.WriteLine("Class Name: " + ClassName);
                Console.WriteLine("Class Description: " + ClassDescription);
                Console.WriteLine("Minimum Allowed Age: " + MinimumAllowedAge);
                Console.WriteLine("Default Validity Length: " + DefaultValidityLength);
                Console.WriteLine("Class Fees: " + ClassFees);
            }
            else
            {
                Console.WriteLine("Invalid License Class ID");
            }

        }
        public static void Test_GetLicenseClassInfoByClassName()
        {
            //clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);
            string ClassName = string.Empty;
            byte MinimumAllowedAge = byte.MaxValue;
            byte DefaultValidityLength = byte.MaxValue;
            float ClassFees = -1;
            string ClassDescription = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License Class Name");
            ClassName = Console.ReadLine();
            if(clsLicenseClassData.GetLicenseClassInfoByClassName(ClassName, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                Console.WriteLine("Class Name: " + ClassName);
                Console.WriteLine("Class Description: " + ClassDescription);
                Console.WriteLine("Minimum Allowed Age: " + MinimumAllowedAge);
                Console.WriteLine("Default Validity Length: " + DefaultValidityLength);
                Console.WriteLine("Class Fees: " + ClassFees);
            }
            else
            {
                Console.WriteLine("Invalid License Class Name");
            }

        }
        public static void GetAllLicenseClasses()
        {
            //clsLicenseClassData.GetAllLicenseClasses();
            Console.WriteLine("=================================");
            DataTable dt = clsLicenseClassData.GetAllLicenseClasses();
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Class Name: " + dr["ClassName"]);
                Console.WriteLine("Class Description: " + dr["ClassDescription"]);
                Console.WriteLine("Minimum Allowed Age: " + dr["MinimumAllowedAge"]);
                Console.WriteLine("Default Validity Length: " + dr["DefaultValidityLength"]);
                Console.WriteLine("Class Fees: " + dr["ClassFees"]);
                Console.WriteLine("=================================");
            }

        }
        public static void Test_AddNewLicenseClass()
        {
            //clsLicenseClassData.AddNewLicenseClass(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            string ClassName = string.Empty;
            byte MinimumAllowedAge = byte.MaxValue;
            byte DefaultValidityLength = byte.MaxValue;
            float ClassFees = -1;
            string ClassDescription = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License Class Name");
            ClassName = Console.ReadLine();
            Console.WriteLine("Enter License Class Description");
            ClassDescription = Console.ReadLine();
            Console.WriteLine("Enter Minimum Allowed Age");
            string line = Console.ReadLine();
            if (!byte.TryParse(line, out MinimumAllowedAge))
            {
                //invalid age
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.WriteLine("Enter Default Validity Length");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out DefaultValidityLength))
            {
                //invalid age
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.WriteLine("Enter Class Fees");
            line = Console.ReadLine();
            if (!float.TryParse(line, out ClassFees))
            {
                //invalid fees
                Console.WriteLine("Invalid Fees");
                return;
            }
            int LicenseClassID = clsLicenseClassData.AddNewLicenseClass(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            if (LicenseClassID > 0)
            {
                Console.WriteLine($"License Class Added Successfully With ID {LicenseClassID}");
            }
            else
            {
                Console.WriteLine("License Class Not Added");
            }

        }
        public static void Test_UpdateLicenseClass()
        {
            //clsLicenseClassData.UpdateLicenseClass(LicenseClassID,ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees);
            int LicenseClassID = -1;
            byte MinimumAllowedAge = byte.MaxValue;
            byte DefaultValidityLength = byte.MaxValue;
            float ClassFees = -1;
            string ClassName = null, ClassDescription = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License Class ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClassID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter License Class Name");
            ClassName = Console.ReadLine();
            Console.WriteLine("Enter License Class Description");
            ClassDescription = Console.ReadLine();
            Console.WriteLine("Enter Minimum Allowed Age");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out MinimumAllowedAge))
            {
                //invalid age
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.WriteLine("Enter Default Validity Length");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out DefaultValidityLength))
            {
                //invalid age
                Console.WriteLine("Invalid Age");
                return;
            }
            Console.WriteLine("Enter Class Fees");
            line = Console.ReadLine();
            if (!float.TryParse(line, out ClassFees))
            {
                //invalid fees
                Console.WriteLine("Invalid Fees");
                return;
            }
            if (clsLicenseClassData.UpdateLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees))
            {
                Console.WriteLine("License Class Updated Successfully");
            }
            else
            {
                Console.WriteLine("License Class Not Updated");
            }

        }

    }
}
