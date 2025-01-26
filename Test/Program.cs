using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Driving_License_Management_DataAccessLayer;
namespace Test
{
    internal class Program
    {
        
        /* Main */
        static void Main(string[] args)
        {
            /* test clsApplicationData */
            //clsTest_clsApplicationData.test_clsApplicationData_GetApplicationInfoByID();
            //clsTest_clsApplicationData.test_clsApplicationData_GetAllApplications();
            //clsTest_clsApplicationData.test_clsApplicationData_AddNewApplication();

            //clsTest_clsApplicationData.test_clsApplicationData_UpdateApplication();
            //clsTest_clsApplicationData.test_clsApplicationData_DeleteApplication();
            //clsTest_clsApplicationData.test_clsApplicationData_IsApplicationExists();
            //clsTest_clsApplicationData.test_clsApplicationData_DoesPersonHaveActiveApplication();
            //clsTest_clsApplicationData.test_clsApplicationData_GetActiveApplicationID();
            //clsTest_clsApplicationData.test_clsApplicationData_GetActiveApplicationIDForLicenseClass();
            //clsTest_clsApplicationData.test_clsApplicationData_UpdateStatus();

            /* test clsApplicationTypeData */
            //clsTest_ApplicationTypeData.test_clsApplicationTypeData_AddNewApplicationType();
            //clsTest_ApplicationTypeData.test_clsApplicationTypeData_GetAllApplicationTypes();
            //clsTest_ApplicationTypeData.test_clsApplicationTypeData_GetApplicationTypeInfoByID();
            //clsTest_ApplicationTypeData.test_clsApplicationTypeData_UpdateApplicationType();
            //clsTest_ApplicationTypeData.test_clsApplicationTypeData_DeleteApplicationType();

            /* test clsCountryData */
            //clsTest_clsCountryData.test_clsCountryData_GetCountryInfoByID();
            //clsTest_clsCountryData.test_clsCountryData_GetCountryInfoByName();
            //clsTest_clsCountryData.test_clsCountryData_GetAllCountries();
            ////////// Future Features
            //clsTest_clsCountryData.test_clsCountryData_AddNewCountry();
            //clsTest_clsCountryData.test_clsCountryData_UpdateCountry();
            //clsTest_clsCountryData.test_clsCountryData_DeleteCountry();

            /* test clsDetainedLicenseData */
            // clsTest_DetainedLicenseData.test_clsDetainedLicenseData_GetAllDetainedLicenses();
            //while (true)
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_GetDetainedLicenseInfoByID();
            //while (true)
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_GetDetainedLicenseInfoByLicenseID();
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_AddNewDetainedLicense();
            //while (true)
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_UpdateDetainedLicense();
            //while (true)
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_ReleaseDetainedLicense();
            //while (true)
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_IsLicenseDetained();
            //while(true)
            //clsTest_DetainedLicenseData.test_clsDetainedLicenseData_IsLicenseDetained();
            //clsTest_clsDriverData.test_UpdateDriver();
            //clsTest_clsDriverData.test_AddNewDriver();
            //clsTest_clsDriverData.test_GetAllDrivers();
            //clsTest_clsDriverData.test_GetDriverInfoByPersonID();            
            //clsTest_clsDriverData.test_GetDriverInfoByDriverID();

            //clsTest_clsInternationalLicenseData.test_GetInternationlLicenseInfoByID();
            //clsTest_clsInternationalLicenseData.test_GettAllInternationalLicenses();
            //clsTest_clsInternationalLicenseData.test_GetDriverInternationalLicenses();
            //clsTest_clsInternationalLicenseData.test_AddNewInternationalLicense();
            //clsTest_clsInternationalLicenseData.test_UpdateInternationalLicense();
            //clsTest_clsInternationalLicenseData.test_GetActiveInternationalLicenseIDByDriverID();
            //while (true)
                clsTest_clsTestData.Test_GetAllTests();
                        
            //clsTest_clsLicenseData.Test_DeactivateLicense();
                //clsTest_clsLicenseData.Test_GetLicenseInfoByID();
        }
    }
}
