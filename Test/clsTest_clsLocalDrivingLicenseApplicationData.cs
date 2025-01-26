using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    public static class clsTest_clsLocalDrivingLicenseApplicationData
    {
        public static void Test_GetLocalDrivingLicenseApplicationInfoByID()
        {
            //clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);
            int LocalDrivingLicenseApplicationID = -1;
            int ApplicationID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                Console.WriteLine("Local Driving License Application Info");
                Console.WriteLine("=================================");
                Console.WriteLine(ApplicationID);
                Console.WriteLine(LicenseClassID);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

        }
        public static void test_AddNewLocalDrivingLicenseApplication()
        {
            //clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            int ApplicationID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
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
            int CreatedID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            if (CreatedID > 0)
            {
                Console.WriteLine("Local Driving License Application ID");
                Console.WriteLine(CreatedID);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
            
        }
        public static void Test_GetLocalDrivingLicenseApplicationInfoByApplicationID()
        {
            //clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);
            int ApplicationID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID))
            {
                Console.WriteLine("Local Driving License Application Info");
                Console.WriteLine("=================================");
                Console.WriteLine(LocalDrivingLicenseApplicationID);
                Console.WriteLine(LicenseClassID);
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

        }
        public static void Test_GetAllLocalDrivingLicenseApplications()
        {
            //clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
            DataTable dataTable = clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
            if (dataTable.Rows.Count > 0)
            {
                Console.WriteLine("Local Driving License Applications");
                Console.WriteLine("=================================");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["LocalDrivingLicenseApplicationID"]);
                    Console.WriteLine(row["ApplicationID"]);
                    Console.WriteLine(row["LicenseClassID"]);
                }
            }
            else
            {
                Console.WriteLine("No Local Driving License Applications");
            }


        }
        public static void Test_AddNewLocalDrivingLicenseApplication()
        {
            //clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            int ApplicationID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out ApplicationID))
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
            int CreatedID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
            if (CreatedID > 0)
            {
                Console.WriteLine($"Local Driving License Application Added Successfully With ID {CreatedID}");
            }
            else
            {
                Console.WriteLine("Error Adding Local Driving License Application");
            }

        }
        public static void Test_UpdateLocalDrivingLicenseApplication()
        {
            //clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            int LocalDrivingLicenseApplicationID = -1;
            int ApplicationID = -1;
            int LicenseClassID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
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
            Console.WriteLine("Enter License Class ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseClassID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID))
            {
                Console.WriteLine("Local Driving License Application Updated Successfully");
            }
            else
            {
                Console.WriteLine("Error Updating Local Driving License Application");
            }

        }
        public static void Test_DeleteLocalDrivingLicenseApplication()
        {
            //clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
            int LocalDrivingLicenseApplicationID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))
            {
                Console.WriteLine("Local Driving License Application Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Error Deleting Local Driving License Application");
            }

        }
        public static void Test_DoesPassTestType()
        {
            //clsLocalDrivingLicenseApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID,TestTypeID);
            int LocalDrivingLicenseApplicationID = -1;
            int TestTypeID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID, TestTypeID))
            {
                Console.WriteLine("Local Driving License Application Passed Test Type");
            }
            else
            {
                Console.WriteLine("Local Driving License Application Did Not Pass Test Type");
            }


        }
        public static void Test_DoesAttendTestType()
        {
            //clsLocalDrivingLicenseApplicationData.DoesAttendTestType(LocalDrivingLicenseApplicationID, TestTypeID);
            int LocalDrivingLicenseApplicationID = -1;
            int TestTypeID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.DoesAttendTestType(LocalDrivingLicenseApplicationID, TestTypeID))
            {
                Console.WriteLine("Local Driving License Application Does Attend Test Type");
            }
            else
            {
                Console.WriteLine("Local Driving License Application Does Not Attend Test Type");
            }

        }
        public static void Test_TotalTrialsPerTest()
        {
            //clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, TestTypeID);
            int LocalDrivingLicenseApplicationID = -1;
            int TestTypeID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int TotalTrials = clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, TestTypeID);
            if (TotalTrials > 0)
            {
                Console.WriteLine("Total Trials Per Test");
                Console.WriteLine(TotalTrials);
            }
            else
            {
                Console.WriteLine("Error Getting Total Trials Per Test");
            }

        }
        public static void Test_IsThereAnActiveSchheduledTest()
        {
            //clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, TestTypeID);
            int LocalDrivingLicenseApplicationID = -1;
            int TestTypeID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, TestTypeID))
            {
                Console.WriteLine("There Is An Active Scheduled Test");
            }
            else
            {
                Console.WriteLine("There Is Not An Active Scheduled Test");
            }

        }

    }
}
