using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Test
{
    public static class clsTest_clsCountryData
    {
        /* clsCountryData */
        public static void test_clsCountryData_GetCountryInfoByID()
        {
            string CountryName = "";
            int ID = 1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter ID:");
            string read = Console.ReadLine();
            if (read != "" && int.TryParse(read, out ID))
            {
                if (clsCountryData.GetCountryInfoByID(ID, ref CountryName))
                {
                    Console.WriteLine(CountryName);
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
        public static void test_clsCountryData_GetCountryInfoByName()
        {
            string CountryName = "";
            int ID = 1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Country Name:");
            string read = Console.ReadLine();
            if (read != "")
            {
                if (clsCountryData.GetCountryInfoByName(read, ref ID))
                {
                    Console.WriteLine(ID);
                    Console.WriteLine("=================================");
                }
                else
                {
                    Console.WriteLine("Invalid Country Name");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Country Name");
            }
        }

        public static void test_clsCountryData_GetAllCountries()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Countries:");
            Console.WriteLine("=================================");
            foreach (DataRow item in clsCountryData.GetAllCountries().Rows)
            {
                Console.WriteLine(item["CountryID"] + " " + item["CountryName"]);
            }
            Console.WriteLine("=================================");
        }
    }
}
