using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_DetainedLicenseData
    {

        public static void test_clsDetainedLicenseData_GetDetainedLicenseInfoByID()
        {
            //clsDetainedLicenseData.GetDetainedLicenseInfoByID(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Detain ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out DetainID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if(clsDetainedLicenseData.GetDetainedLicenseInfoByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                Console.WriteLine("Detained License Info:");
                Console.WriteLine("=================================");
                Console.WriteLine(LicenseID);
                Console.WriteLine(DetainDate);
                Console.WriteLine(FineFees);
                Console.WriteLine(CreatedByUserID);
                Console.WriteLine(IsReleased);
                Console.WriteLine(ReleaseDate);
                Console.WriteLine(ReleasedByUserID);
                Console.WriteLine(ReleaseApplicationID);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Detained Licence not found");
            }
        }
        public static void test_clsDetainedLicenseData_GetAllDetainedLicenses()
        {
            //clsDetainedLicenseData.GetAllDetainedLicenses();
            Console.WriteLine("=================================");
            Console.WriteLine("Detained Licenses:");
            Console.WriteLine("=================================");
            foreach (DataRow item in clsDetainedLicenseData.GetAllDetainedLicenses().Rows)
            {
                Console.WriteLine(item["DetainID"]);
                Console.WriteLine(item["LicenseID"]);
                Console.WriteLine(item["DetainDate"]);
                Console.WriteLine(item["FineFees"]);
                Console.WriteLine(item["CreatedByUserID"]);
                Console.WriteLine(item["IsReleased"]);
                Console.WriteLine(item["ReleaseDate"]);
                Console.WriteLine(item["ReleasedByUserID"]);
                Console.WriteLine(item["ReleaseApplicationID"]);
                Console.WriteLine("=================================");
            }
        }
        public static void test_clsDetainedLicenseData_GetDetainedLicenseInfoByLicenseID()
        {
            //clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID, DetainID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            int LicenceID = -1;
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenceID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenceID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                Console.WriteLine("DetainID: " + Convert.ToString(DetainID));
                Console.WriteLine("DetainDate: " + Convert.ToString(DetainDate));
                Console.WriteLine("FineFees: " + Convert.ToString(FineFees));
                Console.WriteLine("CreatedByUserID: " + Convert.ToString(CreatedByUserID));
                Console.WriteLine("IsReleased: " + Convert.ToString(IsReleased));
                Console.WriteLine("ReleaseDate: " + Convert.ToString(ReleaseDate));
                Console.WriteLine("ReleasedByUserID: " + Convert.ToString(ReleasedByUserID));
                Console.WriteLine("ReleaseApplicationID: " + Convert.ToString(ReleaseApplicationID));
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Detained Licence not found");
            }
        }
        public static void test_clsDetainedLicenseData_AddNewDetainedLicense()
        {
            //clsDetainedLicenseData.AddNewDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID);
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            //Console.WriteLine("Enter Detain Date:");
            //line = Console.ReadLine();
            //if (!DateTime.TryParse(line, out DetainDate))
            //{
            //    //invalid id
            //    Console.WriteLine("Invalid Detain Date");
            //    return;
            //}
            DetainDate = DateTime.Now;
            Console.WriteLine("Enter Fine Fees:");
            line = Console.ReadLine();
            if (!float.TryParse(line, out FineFees))
            {
                //invalid id
                Console.WriteLine("Invalid Fine Fees");
                return;
            }
            Console.WriteLine("Enter Created By User ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Created By User ID");
                return;
            }
            int AddedID = clsDetainedLicenseData.AddNewDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID);
            if (AddedID > 0)
            {
                Console.WriteLine("New Detained License ID: " + Convert.ToString(AddedID));
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Failed to add new detained license");
            }
        }
        public static void test_clsDetainedLicenseData_UpdateDetainedLicense()
        {
            //clsDetainedLicenseData.UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID);
            int DetainID = -1;
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Detain ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out DetainID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter License ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
            }
            Console.WriteLine("Enter Detain Date:");
            line = Console.ReadLine();
            if (!DateTime.TryParse(line, out DetainDate))
            {
                //invalid id
                Console.WriteLine("Invalid Detain Date");
                return;
            }
            Console.WriteLine("Enter Fine Fees:");
            line = Console.ReadLine();
            if (!float.TryParse(line, out FineFees))
            {
                //invalid id
                Console.WriteLine("Invalid Fine Fees");
                return;
            }
            Console.WriteLine("Enter Created By User ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out CreatedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Created By User ID");
                return;
            }

            if (clsDetainedLicenseData.UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID))
            {
                Console.WriteLine("Detained License Updated");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Detained License not found");
            }

        }
        public static void test_clsDetainedLicenseData_ReleaseDetainedLicense()
        {
            //clsDetainedLicenseData.ReleaseDetainedLicense(DetainID,ReleasedByUserID, ReleaseApplicationID);
            int DetainID = -1;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Detain ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out DetainID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter Released By User ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ReleasedByUserID))
            {
                //invalid id
                Console.WriteLine("Invalid Released By User ID");
                return;
            }
            Console.WriteLine("Enter Release Application ID:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out ReleaseApplicationID))
            {
                //invalid id
                Console.WriteLine("Invalid Release Application ID");
                return;
            }
            if (clsDetainedLicenseData.ReleaseDetainedLicense(DetainID, ReleasedByUserID, ReleaseApplicationID))
            {
                Console.WriteLine("Detained License Released");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Detained License not found");
            }
        }
        public static void test_clsDetainedLicenseData_IsLicenseDetained()
        {
            //clsDetainedLicenseData.IsLicenseDetained(LicenseID);
            int LicenseID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter License ID:");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out LicenseID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsDetainedLicenseData.IsLicenseDetained(LicenseID))
            {
                Console.WriteLine("License Detained");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("License Not Detained");
            }

        }

    }
}
