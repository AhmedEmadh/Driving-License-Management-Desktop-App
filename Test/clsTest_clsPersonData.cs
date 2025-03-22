using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Test
{
    public static class clsTest_clsPersonData
    {
        public static void Test_GetPersonInfoByID()
        {
            //clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            //Gender: 0 = Male, 1 = Female
            int PersonID = -1;
            string FirstName = null;
            string SecondName = null;
            string ThirdName = null;
            string LastName = null;
            string NationalNo = null;
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string Address = null;
            string Phone = null;
            string Email = null;
            int NationalityCountryID = -1;
            string ImagePath = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                Console.WriteLine("Person Info");
                Console.WriteLine(FirstName);
                Console.WriteLine(SecondName);
                Console.WriteLine(ThirdName);
                Console.WriteLine(LastName);
                Console.WriteLine(NationalNo);
                Console.WriteLine(DateOfBirth);
                Console.WriteLine(Gender);
                Console.WriteLine(Address);
                Console.WriteLine(Phone);
                Console.WriteLine(Email);
                Console.WriteLine(NationalityCountryID);
                Console.WriteLine(ImagePath);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

        }
        public static void Test_GetPersonInfoByNationalNo()
        {
            //clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            string NationalNo = null;
            int PersonID = -1;
            string FirstName = null;
            string SecondName = null;
            string ThirdName = null;
            string LastName = null;
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string Address = null;
            string Phone = null;
            string Email = null;
            int NationalityCountryID = -1;
            string ImagePath = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter National No");
            string line = Console.ReadLine();
            if (line.Length > 0)
            {
                NationalNo = line;
            }
            if(clsPersonData.GetPersonInfoByNationalNo(NationalNo,ref PersonID,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,ref Gender,ref Address,ref Phone,ref Email,ref NationalityCountryID,ref ImagePath))
            {
                Console.WriteLine("Person Info");
                Console.WriteLine(PersonID);
                Console.WriteLine(FirstName);
                Console.WriteLine(SecondName);
                Console.WriteLine(ThirdName);
                Console.WriteLine(LastName);
                Console.WriteLine(DateOfBirth);
                Console.WriteLine(Gender);
                Console.WriteLine(Address);
                Console.WriteLine(Phone);
                Console.WriteLine(Email);
                Console.WriteLine(NationalityCountryID);
                Console.WriteLine(ImagePath);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid National No");
            }

        }
        public static void AddNewPerson()
        {
            //clsPersonData.AddNewPerson(FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            string FirstName = null;
            string SecondName = null;
            string ThirdName = null;
            string LastName = null;
            string NationalNo = null;
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string Address = null;
            string Phone = null;
            string Email = null;
            int NationalityCountryID = -1;
            string ImagePath = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter First Name");
            string line = Console.ReadLine();
            if (line.Length > 0)
            {
                FirstName = line;
            }
            Console.WriteLine("Enter Second Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                SecondName = line;
            }
            Console.WriteLine("Enter Third Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                ThirdName = line;
            }
            Console.WriteLine("Enter Last Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                LastName = line;
            }
            Console.WriteLine("Enter National No");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                NationalNo = line;
            }
            Console.WriteLine("Enter Date Of Birth");
            line = Console.ReadLine();
            if (line.Length > 0 && DateTime.TryParse(line, out DateOfBirth))
            {
                DateOfBirth = Convert.ToDateTime(line);
            }
            Console.WriteLine("Enter Gender");
            line = Console.ReadLine();
            if (line.Length > 0 && short.TryParse(line, out Gender))
            {
                Gender = Convert.ToInt16(line);
            }
            Console.WriteLine("Enter Address");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                Address = line;
            }
            Console.WriteLine("Enter Phone");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                Phone = line;
            }
            Console.WriteLine("Enter Email");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                Email = line;
            }
            Console.WriteLine("Enter Nationality Country ID");
            line = Console.ReadLine();
            if (line.Length > 0 && int.TryParse(line, out NationalityCountryID))
            {
                NationalityCountryID = Convert.ToInt32(line);
            }
            Console.WriteLine("Enter Image Path");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                ImagePath = line;
            }

            int PersonID = clsPersonData.AddNewPerson(FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            if (PersonID > 0)
            {
                Console.WriteLine("Person ID");
                Console.WriteLine(PersonID);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }


        }
        public static void Test_UpdatePerson()
        {
            //clsPersonData.UpdatePerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            int PersonID = -1;
            string FirstName = null;
            string SecondName = null;
            string ThirdName = null;
            string LastName = null;
            string NationalNo = null;
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string Address = null;
            string Phone = null;
            string Email = null;
            int NationalityCountryID = -1;
            string ImagePath = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter First Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                FirstName = line;
            }
            Console.WriteLine("Enter Second Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                SecondName = line;
            }
            Console.WriteLine("Enter Third Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                ThirdName = line;
            }
            Console.WriteLine("Enter Last Name");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                LastName = line;
            }
            Console.WriteLine("Enter National No");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                NationalNo = line;
            }
            Console.WriteLine("Enter Date Of Birth");
            line = Console.ReadLine();
            if (line.Length > 0 && DateTime.TryParse(line, out DateOfBirth))
            {
                DateOfBirth = Convert.ToDateTime(line);
            }
            Console.WriteLine("Enter Gender");
            line = Console.ReadLine();
            if (line.Length > 0 && short.TryParse(line, out Gender))
            {
                Gender = Convert.ToInt16(line);
            }
            Console.WriteLine("Enter Address");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                Address = line;
            }
            Console.WriteLine("Enter Phone");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                Phone = line;
            }
            Console.WriteLine("Enter Email");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                Email = line;
            }
            Console.WriteLine("Enter Nationality Country ID");
            line = Console.ReadLine();
            if (line.Length > 0 && int.TryParse(line, out NationalityCountryID))
            {
                NationalityCountryID = Convert.ToInt32(line);
            }
            Console.WriteLine("Enter Image Path");
            line = Console.ReadLine();
            if (line.Length > 0)
            {
                ImagePath = line;
            }

            if(clsPersonData.UpdatePerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath))
            {
                Console.WriteLine("Person ID Updated");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }

        }
        public static void Test_GetAllPeople()
        {
            //clsPersonData.GetAllPeople();
            Console.WriteLine("=================================");
            DataTable dt = clsPersonData.GetAllPeople();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["PersonID"]);
                Console.WriteLine(row["FirstName"]);
                Console.WriteLine(row["SecondName"]);
                Console.WriteLine(row["ThirdName"]);
                Console.WriteLine(row["LastName"]);
                Console.WriteLine(row["NationalNo"]);
                Console.WriteLine(row["DateOfBirth"]);
                Console.WriteLine(row["Gender"]);
                Console.WriteLine(row["Address"]);
                Console.WriteLine(row["Phone"]);
                Console.WriteLine(row["Email"]);
                Console.WriteLine(row["NationalityCountryID"]);
                Console.WriteLine(row["ImagePath"]);
                Console.WriteLine("=================================");
            }

        }
        public static void Test_DeletePerson()
        {
            //clsPersonData.DeletePerson(PersonID);
            int PersonID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsPersonData.DeletePerson(PersonID))
            {
                Console.WriteLine("Person ID Deleted");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }

        }
        public static void Test_IsPersonExist()
        {
            //clsPersonData.IsPersonExist(PersonID);
            int PersonID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsPersonData.IsPersonExist(PersonID))
            {
                Console.WriteLine("Person ID Exist");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }

        }
        public static void TestIsPersonExistNationalNo()
        {
            //clsPersonData.IsPersonExist(NationalNo);
            string NationalNo = null;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter National No");
            string line = Console.ReadLine();
            if (line.Length > 0)
            {
                NationalNo = line;
            }
            if (clsPersonData.IsPersonExist(NationalNo))
            {
                Console.WriteLine("Person ID Exist");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }

        }


    }
}
