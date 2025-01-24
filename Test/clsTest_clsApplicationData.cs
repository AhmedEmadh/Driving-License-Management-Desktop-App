using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class clsTest_clsApplicationData
    {
        /* clsApplicationData */
        public static void test_clsApplicationData_GetApplicationInfoByID()
        {
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = new DateTime();
            float PaidFees = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID: ");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsApplicationData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                Console.WriteLine(ApplicantPersonID);
                Console.WriteLine(ApplicationDate);
                Console.WriteLine(ApplicationTypeID);
                Console.WriteLine(ApplicationStatus);
                Console.WriteLine(LastStatusDate);
                Console.WriteLine(PaidFees);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("No Data Found");
            }

        }
        public static void test_clsApplicationData_GetAllApplications()
        {
            DataTable data = clsApplicationData.GetAllApplications();
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    Console.WriteLine(row["ApplicationID"] + " " + row["ApplicantPersonID"] + " " + row["ApplicationDate"] + " " + row["ApplicationTypeID"] + " " + row["ApplicationStatus"] + " " + row["LastStatusDate"] + " " + row["PaidFees"] + " " + row["CreatedByUserID"]);
                }
            }
            else
            {
                Console.WriteLine("No Data Found");
            }
        }
        public static void test_clsApplicationData_AddNewApplication()
        {
            // clsApplicationData.AddNewApplication(ApplicantPersonID, ApplicatinoDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);    
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Applicant Person ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicantPersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Status:");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out ApplicationStatus))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Paid Fees:");
            line = Console.ReadLine();
            if (!float.TryParse(line, out PaidFees))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Created By User ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int CreatedID = clsApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            if (CreatedID > 0)
            {
                Console.WriteLine($"Application Added Successfully With ID {CreatedID}");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Failed to Add Application");
            }

        }
        public static void test_clsApplicationData_UpdateApplication()
        {
            // clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            int ApplicationID = -1;
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Applicant Person ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicantPersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Status:");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out ApplicationStatus))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Paid Fees:");
            line = Console.ReadLine();
            if (!float.TryParse(line, out PaidFees))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Created By User ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID))
            {
                Console.WriteLine("Application Updated Successfully");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Failed to Update Application");
            }
        }
        public static void test_clsApplicationData_DeleteApplication()
        {
            //clsApplicationData.DeleteApplication(ApplicationID);   
            int ApplicationID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsApplicationData.DeleteApplication(ApplicationID))
            {
                Console.WriteLine("Application Deleted Successfully");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Failed to Delete Application");
            }
        }
        public static void test_clsApplicationData_IsApplicationExists()
        {
            //clsApplicationData.IsApplicationExist(ApplicationID);
            int ApplicationID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsApplicationData.IsApplicationExist(ApplicationID))
            {
                Console.WriteLine("Application Exists");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Application Does Not Exist");
            }
        }
        public static void test_clsApplicationData_DoesPersonHaveActiveApplication()
        {
            //clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
            //1-New 2-Cancelled 3-Completed
            int PersonID = -1;
            int ApplicationTypeID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID))
            {
                Console.WriteLine("Person Has Active Application");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Person Does Not Have Active Application");
            }

        }
        public static void test_clsApplicationData_GetActiveApplicationID()
        {
            //clsApplicationData.GetActiveApplicationID(PersonID, ApplicationTypeID);
            int PersonID = -1;
            int ApplicationTypeID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int ID = clsApplicationData.GetActiveApplicationID(PersonID, ApplicationTypeID);
            if (ID > 0)
            {
                Console.WriteLine($"Active Application ID: {ID}");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("No Active Application Found");
            }
        }
        public static void test_clsApplicationData_GetActiveApplicationIDForLicenseClass()
        {
            //clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, ApplicationTypeID, LicenseClassID);
            int PersonID = -1;
            int ApplicationTypeID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Application Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter License Class ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClassID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int ID = clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, ApplicationTypeID, LicenseClassID);
            if (ID > 0)
            {
                Console.WriteLine($"Active Application ID: {ID}");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("No Active Application Found");
            }
        }
        public static void test_clsApplicationData_UpdateStatus()
        {
            //clsApplicationData.UpdateStatus(ApplicationID, NewStatus);
            //Status: 1-New 2-Cancelled 3-Completed
            int ApplicationID = -1;
            byte NewStatus = 0;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter New Status:");
            line = Console.ReadLine();
            if (!byte.TryParse(line, out NewStatus))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsApplicationData.UpdateStatus(ApplicationID, NewStatus))
            {
                Console.WriteLine("Status Updated Successfully");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Failed to Update Status");
            }
        }

    }
}
