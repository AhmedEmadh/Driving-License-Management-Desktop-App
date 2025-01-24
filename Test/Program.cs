using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    internal class Program
    {
        /* clsApplicationTypeData */
        static void test_clsApplicationTypeData_GetApplicationTypeInfoByID()
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0;
            int ID = 1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter ID:");
            string read = Console.ReadLine();
            if (read != "" && int.TryParse(read, out ID))
            {
                if(clsApplicationTypeData.GetApplicationTypeInfoByID(ID, ref ApplicationTypeTitle, ref ApplicationFees))
                {
                    Console.WriteLine(ApplicationTypeTitle);
                    Console.WriteLine(ApplicationFees);
                    Console.WriteLine("=================================");

                }
                else
                {
                    Console.WriteLine("Invalid ID");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a number for ID");
            }

        }
        static void test_clsApplicationTypeData_GetAllApplicationTypes()
        {
            DataTable data = clsApplicationTypeData.GetAllApplicationTypes();
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    Console.WriteLine(row["ApplicationTypeID"] + " " + row["ApplicationTypeTitle"] + " " + row["ApplicationFees"]);
                }
            }
            else
            {
                Console.WriteLine("No Data Found");
            }
        }
        static void test_clsApplicationTypeData_AddNewApplicationType()
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application Type Title:");
            ApplicationTypeTitle = Console.ReadLine();
            Console.WriteLine("Enter Application Fees:");
            string read = Console.ReadLine();
            if (read != "" && float.TryParse(read, out ApplicationFees))
            {
                int CreatedID = clsApplicationTypeData.AddNewApplicationType(ApplicationTypeTitle, ApplicationFees);
                if (CreatedID > 0)
                {
                    Console.WriteLine($"Application Type Added Successfully With ID {CreatedID}");
                    Console.WriteLine("=================================");
                }
                else
                {
                    Console.WriteLine("Failed to Add Application Type");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a number for Application Fees");
            }
        }
        static void test_clsApplicationTypeData_UpdateApplicationType()
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0;
            int ID = 1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter ID:");
            string read = Console.ReadLine();
            if (read != "" && int.TryParse(read, out ID))
            {
                Console.WriteLine("Enter Application Type Title:");
                ApplicationTypeTitle = Console.ReadLine();
                Console.WriteLine("Enter Application Fees:");
                read = Console.ReadLine();
                if (read != "" && float.TryParse(read, out ApplicationFees))
                {
                    if (clsApplicationTypeData.UpdateApplicationType(ID, ApplicationTypeTitle, ApplicationFees))
                    {
                        Console.WriteLine("Application Type Updated Successfully");
                        Console.WriteLine("=================================");
                    }
                    else
                    {
                        Console.WriteLine("Failed to Update Application Type");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a number for Application Fees");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a number for ID");
            }
        }
        static void test_clsApplicationTypeData_DeleteApplicationType()
        {
            int ID = 1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter ID:");
            string read = Console.ReadLine();
            if (read != "" && int.TryParse(read, out ID))
            {
                if (clsApplicationTypeData.DeleteApplicationType(ID))
                {
                    Console.WriteLine("Application Type Deleted Successfully");
                    Console.WriteLine("=================================");
                }
                else
                {
                    Console.WriteLine("Failed to Delete Application Type");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a number for ID");
            }
        }


        /* clsApplicationData */
        static void test_clsApplicationData_GetApplicationInfoByID()
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
            if(!int.TryParse(line,out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsApplicationData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
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
        static void test_clsApplicationData_GetAllApplications()
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
        static void test_clsApplicationData_AddNewApplication()
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
        static void test_clsApplicationData_UpdateApplication()
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
        static void test_clsApplicationData_DeleteApplication()
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
        static void test_clsApplicationData_IsApplicationExists()
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
        static void test_clsApplicationData_DoesPersonHaveActiveApplication()
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
        static void test_clsApplicationData_GetActiveApplicationID()
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
        static void test_clsApplicationData_GetActiveApplicationIDForLicenseClass()
        {
           //clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID,ApplicationTypeID, LicenseClassID);
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
        static void test_clsApplicationData_UpdateStatus()
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
            /* Main */
            static void Main(string[] args)
        {
            /* test clsApplicationData */
            while(false)
            {
                //test_clsApplicationData_GetApplicationInfoByID();
            }

            do
            {
                //test_clsApplicationData_GetAllApplications();
            }
            while (false);

            //test_clsApplicationData_AddNewApplication();

            //test_clsApplicationData_UpdateApplication();
            //test_clsApplicationData_DeleteApplication();
            //test_clsApplicationData_IsApplicationExists();
            //test_clsApplicationData_DoesPersonHaveActiveApplication();
            //test_clsApplicationData_GetActiveApplicationID();
            //test_clsApplicationData_GetActiveApplicationIDForLicenseClass();
            //test_clsApplicationData_UpdateStatus();



            /* test clsApplicationTypeData */
            //test_clsApplicationTypeData_AddNewApplicationType();
            //test_clsApplicationTypeData_GetAllApplicationTypes();
            //test_clsApplicationTypeData_GetApplicationTypeInfoByID();
            //test_clsApplicationTypeData_UpdateApplicationType();
            //test_clsApplicationTypeData_DeleteApplicationType();

        }
    }
}
