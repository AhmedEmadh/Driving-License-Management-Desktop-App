using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        int _LocalDrivingLicenseApplicationID;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _SetModeToAddNewMode();
            _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
        }
        public frmNewLocalDrivingLicenseApplication(int ID)
        {
            InitializeComponent();
            _SetModeToUpdateMode();
            _LocalDrivingLicenseApplicationID = ID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(ID);
        }

        void _ReloadLables()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            clsLicenseClass lc = clsLicenseClass.Find(cbLicenseClass.SelectedItem.ToString());
            lblApplicationFees.Text = lc.ClassFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }
        void _LoadLicenseClassItems()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();
            foreach (DataRow dr in dt.Rows)
            {
                //add to combo box cbLicenseClass
                cbLicenseClass.Items.Add(dr["ClassName"].ToString());
            }
            cbLicenseClass.SelectedIndex = 0;

        }
        void _UpdateLicenseClass()
        {
            clsLicenseClass lc = clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID);
            cbLicenseClass.SelectedItem = lc.ClassName;
        }
        void _LoadApplicationData()
        {
            ctlPersonInformationWithFilter1.PersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
            lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString("yyyy/MM/dd");
            lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lblApplicationID.Text = _LocalDrivingLicenseApplication.ApplicationID.ToString();
            lblCreatedBy.Text = _LocalDrivingLicenseApplication.CreatedByUserInfo.UserName;
            if(_Mode == enMode.Update)
            {
                //set filter textbox to Passed ID
                ctlPersonInformationWithFilter1.SearchText = _LocalDrivingLicenseApplication.ApplicantPersonID.ToString();
            }
            _UpdateLicenseClass();
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadLicenseClassItems();
            if (_Mode == enMode.AddNew)
            {
                ctlPersonInformationWithFilter1.SelectedIndex = 0;
                //add items to the combobox from the database DataTable to list all the available driving license types names
                _ReloadLables();
            }
            else
            {
                _ReloadLables();
                _LoadApplicationData();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlPersonInformationWithFilter1_OnPersonSelected(object obj)
        {

        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadLables();
        }
        void _SetModeToUpdateMode()
        {
            _Mode = enMode.Update;
            lblTitle.Text = "Update Local Driving License Application";
        }
        void _SetModeToAddNewMode()
        {
            _Mode = enMode.AddNew;
            lblTitle.Text = "New Local Driving License Application";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            }
            else
            {
                _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(int.Parse(lblApplicationID.Text));
            }
            _LocalDrivingLicenseApplication.ApplicantPersonID = ctlPersonInformationWithFilter1.PersonID;
            _LocalDrivingLicenseApplication.ApplicationTypeID = _LocalDrivingLicenseApplication.ApplicationTypeID = (int)clsApplicationType.enType.NewLocalDrivingLicenseService;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = float.Parse(lblApplicationFees.Text);
            _LocalDrivingLicenseApplication.LicenseClassID = clsLicenseClass.Find(cbLicenseClass.SelectedItem.ToString()).LicenseClassID;
            if (_LocalDrivingLicenseApplication.Save())
            {
                MessageBox.Show("Application Saved Successfully");
                lblApplicationID.Text = _LocalDrivingLicenseApplication.ApplicationID.ToString();
                _SetModeToUpdateMode();
            }
            else
            {
                MessageBox.Show("Failed to save the application");

            }
        }
    }
}
