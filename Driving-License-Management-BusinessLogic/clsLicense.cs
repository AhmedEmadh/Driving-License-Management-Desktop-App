using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_BusinessLogic
{
    public class clsLicense
    {
        public static DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicenseData.GetDriverLicenses(DriverID);
        }
    }
}
