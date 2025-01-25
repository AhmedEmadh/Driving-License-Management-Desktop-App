using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
using System.Runtime.InteropServices;
namespace Test
{
    public static class clsTest_clsTestData
    {
        public static void Test_GetTestInfoByID()
        {
            //clsTestData.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID); ;
            int TestID = -1;
            int TestAppointmentID = -1;
            byte TestResult = 0;
            string Notes = null;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsTestData.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                Console.WriteLine("Test Info");
                Console.WriteLine(TestAppointmentID);
                Console.WriteLine(TestResult);
                Console.WriteLine(Notes);
                Console.WriteLine(CreatedByUserID);
            }
            else
            {
                Console.WriteLine("Invalid Test ID");
            }

        }
        public static void Test_GetLastTestByPersonAndTestTypeAndLicenseClassID()
        {
            //clsTestData.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID,LicenseClassID,TestTypeID, ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);
            int PersonID = -1;
            int LicenseClassID = -1;
            int TestTypeID = -1;
            int TestID = -1;
            int TestAppointmentID = -1;
            byte TestResult = 0;
            string Notes = null;
            int CreatedByUserID = -1;
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
            Console.WriteLine("Enter Test Type ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsTestData.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID, LicenseClassID, TestTypeID, ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                Console.WriteLine("Test Info");
                Console.WriteLine(TestID);
                Console.WriteLine(TestAppointmentID);
                Console.WriteLine(TestResult);
                Console.WriteLine(Notes);
                Console.WriteLine(CreatedByUserID);
            }
            else
            {
                Console.WriteLine("Invalid Test ID");
            }

        }
        public static void Test_GetAllTests()
        {
            //clsTestData.GetAllTests();
            DataTable dt = new DataTable();
            dt = clsTestData.GetAllTests();
            Console.WriteLine("=================================");
            Console.WriteLine("All Tests");
            Console.WriteLine("=================================");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["TestID"]);
                Console.WriteLine(row["TestAppointmentID"]);
                Console.WriteLine(row["TestResult"]);
                Console.WriteLine(row["Notes"]);
                Console.WriteLine(row["CreatedByUserID"]);
                Console.WriteLine("=================================");
            }

        }
        public static void Test_AddNewTest()
        {
            //clsTestData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = null;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test Appointment ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestAppointmentID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Result");
            line = Console.ReadLine();
            if (!bool.TryParse(line, out TestResult))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Notes");
            Notes = Console.ReadLine();
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int TestID = clsTestData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            if (TestID > 0)
            {
                Console.WriteLine("Test Info");
                Console.WriteLine(TestAppointmentID);
                Console.WriteLine(TestResult);
                Console.WriteLine(Notes);
                Console.WriteLine(CreatedByUserID);
            }
            else
            {
                Console.WriteLine("Invalid Test ID");
            }

        }
        public static void Test_UpdateTest()
        {
            //clsTestData.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = null;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Appointment ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestAppointmentID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Result");
            line = Console.ReadLine();
            if (!bool.TryParse(line, out TestResult))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Notes");
            Notes = Console.ReadLine();
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsTestData.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID))
            {
                Console.WriteLine("Test Info");
                Console.WriteLine(TestID);
                Console.WriteLine(TestAppointmentID);
                Console.WriteLine(TestResult);
                Console.WriteLine(Notes);
                Console.WriteLine(CreatedByUserID);
            }
            else
            {
                Console.WriteLine("Invalid Test ID");
            }

        }
        public static void Test_GetPassedTestCount()
        {
            //clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
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
            int TestCount = clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
            Console.WriteLine("Test Count");
            Console.WriteLine(TestCount);
        }

    }
}
