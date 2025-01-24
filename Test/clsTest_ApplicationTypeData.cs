using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class clsTest_ApplicationTypeData
    {
        /* clsApplicationTypeData */
        public static void test_clsApplicationTypeData_GetApplicationTypeInfoByID()
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0;
            int ID = 1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter ID:");
            string read = Console.ReadLine();
            if (read != "" && int.TryParse(read, out ID))
            {
                if (clsApplicationTypeData.GetApplicationTypeInfoByID(ID, ref ApplicationTypeTitle, ref ApplicationFees))
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
        public static void test_clsApplicationTypeData_GetAllApplicationTypes()
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
        public static void test_clsApplicationTypeData_AddNewApplicationType()
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
        public static void test_clsApplicationTypeData_UpdateApplicationType()
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
        public static void test_clsApplicationTypeData_DeleteApplicationType()
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


    }
}
