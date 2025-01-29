using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_clsTestAppointmentData
    {
        public static void Test_GetTestAppointmentInfoByID()
        {
            //clsTestAppointmentData.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID);
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            Console.WriteLine("=================================");
            Console.WriteLine("Enter TestAppointment ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestAppointmentID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsTestAppointmentData.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                Console.WriteLine("Test Appointment Info:");
                Console.WriteLine(TestTypeID);
                Console.WriteLine(LocalDrivingLicenseApplicationID);
                Console.WriteLine(AppointmentDate);
                Console.WriteLine(PaidFees);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine(IsLocked);
                Console.WriteLine(RetakeTestApplicationID);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Test Appointment ID");
            }


        }
        public static void Test_GetLastTestAppointment()
        {
            //clsTestAppointmentData.GetLastTestAppointment(LocalDrivingLicenseApplicationID,TestTypeID,TestAppointmentID,AppointmentDate,PaindFees,CreatedByUserID,IsLocked,RetakeTestApplicationID);
            int LocalDrivingLicenseApplicationID = -1;
            int TestTypeID = -1;
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaindFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }

            if(clsTestAppointmentData.GetLastTestAppointment(LocalDrivingLicenseApplicationID,TestTypeID,ref TestAppointmentID,ref AppointmentDate,ref PaindFees,ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                Console.WriteLine("Test Appointment Info:");
                Console.WriteLine(TestTypeID);
                Console.WriteLine(LocalDrivingLicenseApplicationID);
                Console.WriteLine(TestAppointmentID);
                Console.WriteLine(AppointmentDate);
                Console.WriteLine(PaindFees);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine(IsLocked);
                Console.WriteLine(RetakeTestApplicationID);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Local Driving License Application ID");
            }

        }
        public static void Test_GetAllTestAppointments()
        {
            //clsTestAppointmentData.GetAllTestAppointments();
            DataTable dt = clsTestAppointmentData.GetAllTestAppointments();
            Console.WriteLine("=================================");
            Console.WriteLine("Test Appointments:");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["TestAppointmentID"]);
                Console.WriteLine(row["LocalDrivingLicenseApplicationID"]);
                Console.WriteLine(row["TestTypeID"]);
                Console.WriteLine(row["AppointmentDate"]);
                Console.WriteLine(row["PaidFees"]);
                Console.WriteLine(row["CreatedByUserID"]);
                Console.WriteLine(row["IsLocked"]);
                Console.WriteLine(row["RetakeTestApplicationID"]);
                Console.WriteLine("=================================");
            }

        }
        public static void GetApplicationTestAppointmentsPerTestType()
        {
            //clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID,TestTypeID);
            int LocalDrivingLicenseApplicationID = -1;
            int TestTypeID = -1;

            Console.WriteLine("=================================");
            Console.WriteLine("Enter Local Driving License Application ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }

            DataTable dt = clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID,TestTypeID);
            Console.WriteLine("=================================");
            Console.WriteLine("Test Appointments:");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["TestAppointmentID"]);
                Console.WriteLine(row["LocalDrivingLicenseApplicationID"]);
                Console.WriteLine(row["TestTypeID"]);
                Console.WriteLine(row["AppointmentDate"]);
                Console.WriteLine(row["PaidFees"]);
                Console.WriteLine(row["CreatedByUserID"]);
                Console.WriteLine(row["IsLocked"]);
                Console.WriteLine(row["RetakeTestApplicationID"]);
                Console.WriteLine("=================================");
            }

        }
        public static void Test_AddNewTestAppointment()
        {
            //clsTestAppointmentData.AddNewTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, RetakeTestApplicationID);
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            int RetakeTestApplicationID = -1;

            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test Type ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Local Driving License Application ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            //Console.WriteLine("Enter Appointment Date:");
            //line = Console.ReadLine();
            //if (!DateTime.TryParse(line, out AppointmentDate))
            //{
            //    //invalid id
            //    Console.WriteLine("Invalid Date");
            //    return;
            //}
            Console.WriteLine("Enter Paid Fees:");
            line = Console.ReadLine();
            if (!float.TryParse(line, out PaidFees))
            {
                //invalid id
                Console.WriteLine("Invalid Fees");
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
            Console.WriteLine("Enter Retake Test Application ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out RetakeTestApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }

            int CreatedID = clsTestAppointmentData.AddNewTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, RetakeTestApplicationID);
            if (CreatedID > 0)
            {
                Console.WriteLine("Test Appointment ID:");
                Console.WriteLine(CreatedID);
            }
            else
            {
                Console.WriteLine("Invalid Test Appointment ID");
            }

        }
        public static void Test_UpdateTestAppointment()
        {
            //clsTestAppointmentData.UpdateTestAppointment(TestAppointmentID, Test, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            int TestAppointmentID = -1;
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test Appointment ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestAppointmentID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Test Type ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Local Driving License Application ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LocalDrivingLicenseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Appointment Date:");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out AppointmentDate))
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
            Console.WriteLine("Enter Is Locked:");
            line = Console.ReadLine();
            if (!bool.TryParse(line, out IsLocked))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Retake Test Application ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out RetakeTestApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsTestAppointmentData.UpdateTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID))
            {
                Console.WriteLine("Test Appointment Updated");
            }
            else
            {
                Console.WriteLine("Failed to Update Test Appointment");

            }

        }
        public static void Test_GetTestID()
        {
            //clsTestAppointmentData.GetTestID(TestAppointmentID);
            int TestAppointmentID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test Appointment ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestAppointmentID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int TestID = clsTestAppointmentData.GetTestID(TestAppointmentID);
            if (TestID > 0)
            {
                Console.WriteLine("Test ID: " + TestID);
            }
            else
            {
                Console.WriteLine("Invalid Test Appointment ID");
            }

        }

    }
}
