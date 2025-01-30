using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Driving_License_Management_BusinessLogic;
namespace Driving_License_Management_Desktop_App.Global_Classes
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            return false;
        }
        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            return false;
        }

    }
}
