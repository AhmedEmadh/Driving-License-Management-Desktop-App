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

    }
}
