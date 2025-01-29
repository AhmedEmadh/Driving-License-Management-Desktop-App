using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_clsTestTypeData
    {
        public static void Test_GetTestTypeInfoByID()
        {
            //clsTestTypeData.GetTestTypeInfoByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);
            int TestTypeID = -1;
            string TestTypeTitle = string.Empty;
            string TestTypeDescription = null;
            float TestTypeFees = 0;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test Type ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out TestTypeID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsTestTypeData.GetTestTypeInfoByID(TestTypeID,ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                Console.WriteLine("Test Type Info");
                Console.WriteLine(TestTypeID);
                Console.WriteLine(TestTypeTitle);
                Console.WriteLine(TestTypeDescription);
                Console.WriteLine(TestTypeFees);
            }
            else
            {
                Console.WriteLine("Invalid Test Type ID");
            }

        }
        public static void Test_GetAllTestTypes()
        {
            //clsTestTypeData.GetAllTestTypes();
            DataTable dt = clsTestTypeData.GetAllTestTypes();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i]["TestTypeID"] + " " + dt.Rows[i]["TestTypeTitle"] + " " + dt.Rows[i]["TestTypeDescription"] + " " + dt.Rows[i]["TestTypeFees"]);
            }

        }
        public static void Test_AddNewTestType()
        {
            //clsTestTypeData.AddNewTestType(Title,Description,Fees);
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Title");
            string Title = Console.ReadLine();
            Console.WriteLine("Enter Description");
            string Description = Console.ReadLine();
            Console.WriteLine("Enter Fees");
            string Fees = Console.ReadLine();
            int TestTypeID = clsTestTypeData.AddNewTestType(Title, Description, float.Parse(Fees));
            if (TestTypeID > 0)
            {
                Console.WriteLine("Test Type Added Successfully");
            }
            else
            {
                Console.WriteLine("Failed to add Test Type");
            }

        }
        public static void Test_UpdateTestType()
        {
            //clsTestTypeData.UpdateTestType(TestTypeID, Title, Description, Fees);
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Test Type ID");
            string TestTypeID = Console.ReadLine();
            Console.WriteLine("Enter Title");
            string Title = Console.ReadLine();
            Console.WriteLine("Enter Description");
            string Description = Console.ReadLine();
            Console.WriteLine("Enter Fees");
            string Fees = Console.ReadLine();
            if (clsTestTypeData.UpdateTestType(int.Parse(TestTypeID), Title, Description, float.Parse(Fees)))
            {
                Console.WriteLine("Test Type Updated Successfully");
            }
            else
            {
                Console.WriteLine("Failed to Update Test Type");
            }

        }

    }
}
