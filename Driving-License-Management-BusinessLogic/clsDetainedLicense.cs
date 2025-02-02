using Driving_License_Management_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_BusinessLogic
{
    public class clsDetainedLicense
    {
        enum enMode { AddNew, Update };
        enMode Mode = enMode.AddNew;

        int DetainID { get; set; }
        int LicenseID { get; set; }
        DateTime DetainDate { get; set; }
        float FineFees { get; set; }
        int CreatedByUserID { get; set; }
        clsUser CreatedByUserInfo { get; set; }
        bool IsReleased { get; set; }
        DateTime ReleaseDate { get; set; }
        int ReleasedByUserID { get; set; }
        clsUser ReleasedByUserInfo { get; set; }
        int ReleaseApplicationID { get; set; }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.CreatedByUserInfo = null;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = -1;
            this.ReleasedByUserInfo = null;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }
        public clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            ReleasedByUserInfo = clsUser.FindByUserID(ReleasedByUserID);
            Mode = enMode.Update;
        }
        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicenseData.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
            return (this.DetainID > 0);
        }
        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
        }
        public static clsDetainedLicense Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.MaxValue, ReleaseDate = DateTime.MaxValue;
            float FineFees = 0;
            bool IsReleased = false;
            clsDetainedLicenseData.GetDetainedLicenseInfoByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }
        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }
        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.MaxValue, ReleaseDate = DateTime.MaxValue;
            float FineFees = 0;
            bool IsReleased = false;
            clsDetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateDetainedLicense();
            }
            return false;
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(LicenseID);
        }
        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainedLicenseData.ReleaseDetainedLicense(this.DetainID, ReleasedByUserID, ReleaseApplicationID);
        }
    }
}
