using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    public static class clsTest_clsUserData
    {
        public static void Test_GetUserInfoByUserID()
        {
            //clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);
            int UserID = -1;
            int PersonID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out UserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                Console.WriteLine("User Info");
                Console.WriteLine(PersonID);
                Console.WriteLine(UserName);
                Console.WriteLine(Password);
                Console.WriteLine(IsActive);
            }
            else
            {
                Console.WriteLine("Invalid User ID");
            }

        }
        public static void Test_GetUserInfoByPersonID()
        {
            //clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive);
            int PersonID = -1;
            int UserID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive))
            {
                Console.WriteLine("Person Info");
                Console.WriteLine(UserID);
                Console.WriteLine(UserName);
                Console.WriteLine(Password);
                Console.WriteLine(IsActive);
            }
            else
            {
                Console.WriteLine("Invalid Person ID");
            }

        }
        public static void Test_GetUserInfoByUsernameAndPassword()
        {
            //clsUserData.GetUserInfoByUsernameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);
            string UserName = string.Empty;
            string Password = string.Empty;
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User Name");
            UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
            if (clsUserData.GetUserInfoByUsernameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive))
            {
                Console.WriteLine("User Info");
                Console.WriteLine(UserID);
                Console.WriteLine(PersonID);
                Console.WriteLine(IsActive);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password");
            }

        }
        public static void Test_AddNewUser()
        {
            //clsUserData.AddNewUser(PersonID,UserName,Password,IsActive);
            int PersonID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter Person ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out PersonID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter User Name");
            UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
            int UserID = clsUserData.AddNewUser(PersonID, UserName, Password, IsActive)
            if (UserID > 0)
            {
                Console.WriteLine($"User Added With ID {UserID}");
            }
            else
            {
                Console.WriteLine("User Not Added");
            }

        }
        public static void Test_UpdateUser()
        {
            //clsUserData.UpdateUser(UserID, PersonID, UserName, Password, IsActive);
            int UserID = -1;
            int PersonID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out UserID))
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
            Console.WriteLine("Enter User Name");
            UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
            if (clsUserData.UpdateUser(UserID, PersonID, UserName, Password, IsActive))
            {
                Console.WriteLine($"User Updated With ID {UserID}");
            }
            else
            {
                Console.WriteLine("User Not Updated");
            }

        }
        public static void Test_GetAllUsers()
        {
            //clsUserData.GetAllUsers();
            DataTable dt = clsUserData.GetAllUsers();
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("User Info");
                Console.WriteLine(dt.Rows[0]["UserID"]);
                Console.WriteLine(dt.Rows[0]["PersonID"]);
                Console.WriteLine(dt.Rows[0]["UserName"]);
                Console.WriteLine(dt.Rows[0]["Password"]);
                Console.WriteLine(dt.Rows[0]["IsActive"]);
            }

        }
        public static void Test_DeleteUser()
        {
            //clsUserData.DeleteUser(UserID);
            int UserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out UserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsUserData.DeleteUser(UserID))
            {
                Console.WriteLine($"User Deleted With ID {UserID}");
            }
            else
            {
                Console.WriteLine("User Not Deleted");
            }

        }
        public static void Test_IsUserExist()
        {
            //clsUserData.IsUserExist(UserID);
            int UserID = -1;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out UserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            if (clsUserData.IsUserExist(UserID))
            {
                Console.WriteLine($"User Exist With ID {UserID}");
            }
            else
            {
                Console.WriteLine("User Not Exist");
            }

        }
        public static void Test_IsUserExistByUserName()
        {
            //clsUserData.IsUserExist(UserName);
            string UserName = string.Empty;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User Name");
            UserName = Console.ReadLine();
            if (clsUserData.IsUserExist(UserName))
            {
                Console.WriteLine($"User Exist With Name {UserName}");
            }
            else
            {
                Console.WriteLine("User Not Exist");
            }

        }
        public static void Test_IsUserExistForPersonID()
        {
            //clsUserData.IsUserExistForPersonID(PersonID); ;
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
            if (clsUserData.IsUserExistForPersonID(PersonID))
            {
                Console.WriteLine($"User Exist With Person ID {PersonID}");
            }
            else
            {
                Console.WriteLine("User Not Exist");
            }

        }
        public static void Test_DoesPersonHaveUser44()
        {
            //clsUserData.DoesPersonHaveUser44(PersonID);
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
            if (clsUserData.DoesPersonHaveUser44(PersonID))
            {
                Console.WriteLine($"User Exist With Person ID {PersonID}");
            }
            else
            {
                Console.WriteLine("User Not Exist");
            }


        }
        public static void Test_ChangePassword()
        {
            //clsUserData.ChangePassword(UserID, NewPassword);
            int UserID = -1;
            string NewPassword = string.Empty;
            Console.WriteLine("=================================");
            Console.WriteLine("Enter User ID");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out UserID))
            {
                //invalid id
                Console.WriteLine("Invalid ID");
                return;
            }
            Console.WriteLine("Enter New Password");
            NewPassword = Console.ReadLine();
            if (clsUserData.ChangePassword(UserID, NewPassword))
            {
                Console.WriteLine($"Password Changed With ID {UserID}");
            }
            else
            {
                Console.WriteLine("Password Not Changed");
            }

        }

    }
}
