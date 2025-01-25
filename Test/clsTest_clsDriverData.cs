using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_clsDriverData
    {
        public static void test_GetDriverInfoByDriverID()
        {
            //clsDriverData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate);
            int DriverID = -1;
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Driver ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out DriverID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsDriverData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                Console.WriteLine("Driver Info");
                Console.WriteLine(PersonID);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine(CreatedDate);
            }
            else
            {
                Console.WriteLine("Invalid Driver ID");
            }

        }
        public static void test_GetDriverInfoByPersonID()
        {
            //clsDriverData.GetDriverInfoByPersonID(clsDriverData, ref DriverID, ref CreatedByUserID, ref CreatedDate);
            int PersonID = -1;
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsDriverData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                Console.WriteLine("Driver Info");
                Console.WriteLine("=================================");
                Console.WriteLine(DriverID);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine(CreatedDate);
            }
            else
            {
                Console.WriteLine("Invalid Person ID");
            }

        }
        public static void test_GetAllDrivers()
        {
            //clsDriverData.GetAllDrivers();
            DataTable dt = clsDriverData.GetAllDrivers();
            Console.WriteLine("Driver Info");
            Console.WriteLine("=================================");
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine(row["DriverID"]);
                Console.WriteLine(row["PersonID"]);
                Console.WriteLine(row["CreatedByUserID"]);
                Console.WriteLine(row["CreatedDate"]);
                Console.WriteLine();
            }

        }
        public static void test_AddNewDriver()
        {
            //clsDriverData.AddNewDriver(PersonID, CreatedByUserID);
            int PersonID = -1;
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
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            int CreatedID = clsDriverData.AddNewDriver(PersonID, CreatedByUserID);
            if (CreatedID > 0)
            {
                Console.WriteLine("Driver ID");
                Console.WriteLine(CreatedID);
            }
            else
            {
                Console.WriteLine("Failed to Add Driver");
            }


        }
        public static void test_UpdateDriver()
        {
            //clsDriverData.UpdateDriver(DriverID, PersonID, CreatedByUserID);
            int DriverID = -1;
            int PersonID = -1;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Driver ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out DriverID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Person ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Created By User ID");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsDriverData.UpdateDriver(DriverID, PersonID, CreatedByUserID))
            {
                Console.WriteLine("Driver Updated");
            }
            else
            {
                Console.WriteLine("Failed to Update Driver");
            }

        }

    }
}
