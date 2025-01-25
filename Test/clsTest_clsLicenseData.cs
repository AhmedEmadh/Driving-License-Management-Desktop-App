using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
using static System.Net.Mime.MediaTypeNames;
namespace Test
{
    public static class clsTest_clsLicenseData
    {
        public static void Test_GetLicenseInfoByID()
        {
            //clsLicenseData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = null;
            float PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsLicenseData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                Console.WriteLine("License Info");
                Console.WriteLine(ApplicationID);
                Console.WriteLine(DriverID);
                Console.WriteLine(LicenseClass);
                Console.WriteLine(IssueDate);
                Console.WriteLine(ExpirationDate);
                Console.WriteLine(Notes);
                Console.WriteLine(PaidFees);
                Console.WriteLine(IsActive);
                Console.WriteLine(IssueReason);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

            
        }
        public static void Test_GetAllLicenses()
        {
            //clsLicenseData.GetAllLicenses();
            DataTable dt = clsLicenseData.GetAllLicenses();
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("All Licenses");
                Console.WriteLine("=================================");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["LicenseID"]);
                    Console.WriteLine(row["ApplicationID"]);
                    Console.WriteLine(row["DriverID"]);
                    Console.WriteLine(row["LicenseClass"]);
                    Console.WriteLine(row["IssueDate"]);
                    Console.WriteLine(row["ExpirationDate"]);
                    Console.WriteLine(row["Notes"]);
                    Console.WriteLine(row["PaidFees"]);
                    Console.WriteLine(row["IsActive"]);
                    Console.WriteLine(row["IssueReason"]);
                    Console.WriteLine(row["CreatedByUserID"]);
                    Console.WriteLine("=================================");
                }
            }
            else
            {
                Console.WriteLine("No Data Found");
            }

        }
        public static void Test_GetDriverLicenses()
        {
            //clsLicenseData.GetDriverLicenses(DriverID);
            int DriverID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Driver ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out DriverID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            DataTable dt = clsLicenseData.GetDriverLicenses(DriverID);
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Driver Licenses");
                Console.WriteLine("=================================");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["LicenseID"]);
                    Console.WriteLine(row["ApplicationID"]);
                    Console.WriteLine(row["DriverID"]);
                    Console.WriteLine(row["LicenseClass"]);
                    Console.WriteLine(row["IssueDate"]);
                    Console.WriteLine(row["ExpirationDate"]);
                    Console.WriteLine(row["Notes"]);
                    Console.WriteLine(row["PaidFees"]);
                    Console.WriteLine(row["IsActive"]);
                    Console.WriteLine(row["IssueReason"]);
                    Console.WriteLine(row["CreatedByUserID"]);
                    Console.WriteLine("=================================");
                }
            }
            else
            {
                Console.WriteLine("No Data Found");
            }

        }
        public static void Test_AddNewLicense()
        {
            //clsLicenseData.AddNewLicense(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID);
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = null;
            float PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Driver ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out DriverID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter License Class");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClass))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Issue Date");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out IssueDate))
            {
                //invalid id
                Console.WriteLine("Invalid Issue Date");
                return;
            }
            Console.WriteLine("Enter Expiration Date");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out ExpirationDate))
            {
                //invalid id
                Console.WriteLine("Invalid Expiration Date");
                return;
            }
            Console.WriteLine("Enter Notes");
            Notes = Console.ReadLine();
            Console.WriteLine("Enter Paid Fees");
            line = Console.ReadLine();
            if (!float.TryParse(line, out PaidFees))
            {
                //invalid id
                Console.WriteLine("Invalid Paid Fees");
                return;
            }
            Console.WriteLine("Enter IsActive");
            line = Console.ReadLine();
            if (!bool.TryParse(line, out IsActive))
            {
                //invalid id
                Console.WriteLine("Invalid IsActive");
                return;
            }
            Console.WriteLine("Enter Issue Reason");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out IssueReason))
            {
                //invalid id
                Console.WriteLine("Invalid Issue Reason");
                return;
            }
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Created By User ID");
                return;
            }
            int LicenseID = clsLicenseData.AddNewLicense(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            if(LicenseID > 0)
            {
            Console.WriteLine("License ID");
            Console.WriteLine(LicenseID);
            Console.WriteLine("=================================");

            }
            else
            {
                Console.WriteLine("Error Adding License");
            }
        }
        public static void Test_UpdateLicense()
        {
            //clsLicenseData.UpdateLicense(LicenseID,ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PainFees,IsActive,IssueReason,CreatedByUserID);
            int LicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = null;
            float PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Driver ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out DriverID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter License Class");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClass))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Issue Date");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out IssueDate))
            {
                //invalid id
                Console.WriteLine("Invalid Issue Date");
                return;
            }
            Console.WriteLine("Enter Expiration Date");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out ExpirationDate))
            {
                //invalid id
                Console.WriteLine("Invalid Expiration Date");
                return;
            }
            Console.WriteLine("Enter Notes");
            Notes = Console.ReadLine();
            Console.WriteLine("Enter Paid Fees");
            line = Console.ReadLine();
            if (!float.TryParse(line, out PaidFees))
            {
                //invalid id
                Console.WriteLine("Invalid Paid Fees");
                return;
            }
            Console.WriteLine("Enter IsActive");
            line = Console.ReadLine();
            if (!bool.TryParse(line, out IsActive))
            {
                //invalid id
                Console.WriteLine("Invalid IsActive");
                return;
            }
            Console.WriteLine("Enter Issue Reason");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out IssueReason))
            {
                //invalid id
                Console.WriteLine("Invalid Issue Reason");
                return;
            }
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Created By User ID");
                return;
            }
            int result = clsLicenseData.UpdateLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            if (result > 0)
            {
                Console.WriteLine("License Updated Successfully");
            }
            else
            {
                Console.WriteLine("Error Updating License");
            }

        }
        public static void Test_GetActiveLicenseIDByPersonID()
        {
            //clsLicenseData.GetActiveLicenseIDByPersonID(PersonID,LicenseClassID);
            int PersonID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter License Class ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClassID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int result = clsLicenseData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
            if (result > 0)
            {
                Console.WriteLine("License ID");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error Getting License ID");
            }

        }
        public static void Test_DeactivateLicense()
        {
            //clsLicenseData.DeactivateLicense(LicenseID);
            int LicenseID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLicenseData.DeactivateLicense(LicenseID))
            {
                Console.WriteLine("License Deactivated Successfully");
            }
            else
            {
                Console.WriteLine("Error Deactivating License");
            }

        }

    }
}
