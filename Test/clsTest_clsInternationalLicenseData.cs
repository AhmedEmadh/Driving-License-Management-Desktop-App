using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_clsInternationalLicenseData
    {
        public static void test_GetInternationlLicenseInfoByID()
        {
            //clsInternationalLicenseData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter International License ID");
            string line = Console.ReadLine();
            if(!int.TryParse(line, out InternationalLicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsInternationalLicenseData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                Console.WriteLine("International License Info");
                Console.WriteLine("=================================");
                Console.WriteLine(ApplicationID);
                Console.WriteLine(DriverID);
                Console.WriteLine(IssuedUsingLocalLicenseID);
                Console.WriteLine(IssueDate);
                Console.WriteLine(ExpirationDate);
                Console.WriteLine(IsActive);
                Console.WriteLine(CreatedByUserID);
            }
            else
            {
                Console.WriteLine("Invalid International License ID");
            }

        }
        public static void test_GettAllInternationalLicenses()
        {
            //clsInternationalLicenseData.GetAllInternationalLicenses();
            DataTable dt = clsInternationalLicenseData.GetAllInternationalLicenses();
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("All International Licenses");
                Console.WriteLine("=================================");
                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["InternationalLicenseID"]);
                    Console.WriteLine(row["ApplicationID"]);
                    Console.WriteLine(row["DriverID"]);
                    Console.WriteLine(row["IssuedUsingLocalLicenseID"]);
                    Console.WriteLine(row["IssueDate"]);
                    Console.WriteLine(row["ExpirationDate"]);
                    Console.WriteLine(row["IsActive"]);
                    Console.WriteLine(row["CreatedByUserID"]);
                    Console.WriteLine("=================================");
                }
            }
            else
            {
                Console.WriteLine("No Data Found");
            }

        }
        public static void test_GetDriverInternationalLicenses()
        {
            //clsInternationalLicenseData.GetDriverInternationalLicenses(DriverID);
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
            DataTable dt = clsInternationalLicenseData.GetDriverInternationalLicenses(DriverID);
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Driver International Licenses");
                Console.WriteLine("=================================");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["InternationalLicenseID"]);
                    Console.WriteLine(row["ApplicationID"]);
                    Console.WriteLine(row["DriverID"]);
                    Console.WriteLine(row["IssuedUsingLocalLicenseID"]);
                    Console.WriteLine(row["IssueDate"]);
                    Console.WriteLine(row["ExpirationDate"]);
                    Console.WriteLine(row["IsActive"]);
                    Console.WriteLine(row["CreatedByUserID"]);
                    Console.WriteLine("=================================");
                }
            }
            else
            {
                Console.WriteLine("No Data Found");
            }

        }
        public static void test_AddNewInternationalLicense()
        {
            //clsInternationalLicenseData.AddNewInternationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
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
            Console.WriteLine("Enter Issued Using Local License ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out IssuedUsingLocalLicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
           IssueDate = DateTime.Now;
            Console.WriteLine("Enter Expiration Date");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out ExpirationDate))
            {
                //invalid id
                Console.WriteLine("Invalid Expiration Date");
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
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Created By User ID");
                return;
            }
            int NewID = clsInternationalLicenseData.AddNewInternationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            if (NewID > 0)
            {
                Console.WriteLine("International License Added Successfully");
            }
            else
            {
                Console.WriteLine("Failed to Add International License");
            }

        }
        public static void test_UpdateInternationalLicense()
        {
            //clsInternationalLicenseData.UpdateInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter International License ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out InternationalLicenseID))
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
            Console.WriteLine("Enter Issued Using Local License ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out IssuedUsingLocalLicenseID))
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
            Console.WriteLine("Enter IsActive");
            line = Console.ReadLine();
            if (!bool.TryParse(line, out IsActive))
            {
                //invalid id
                Console.WriteLine("Invalid IsActive");
                return;
            }
            Console.Write("Enter Created By User ID");
            line = Console.ReadLine();
            if(!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Created By User ID");
                return;
            }
            if(clsInternationalLicenseData.UpdateInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID))
            {
                Console.WriteLine("International License Updated Successfully");
            }
            else
            {
                Console.WriteLine("Failed to Update International License");
            }

        }
        public static void test_GetActiveInternationalLicenseIDByDriverID()
        {
            //clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);
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

            int ActiveInternationalLicenseID = clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);
            if(ActiveInternationalLicenseID > 0)
            {
            Console.WriteLine("Active International License ID: " + ActiveInternationalLicenseID);
            }
            else
            {
                Console.WriteLine("No Active International License Found");
            }

        }

    }
}
