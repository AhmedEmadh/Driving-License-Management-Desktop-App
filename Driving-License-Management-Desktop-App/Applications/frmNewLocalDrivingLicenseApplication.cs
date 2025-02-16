using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        void _ReloadLables()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            clsLicenseClass lc = clsLicenseClass.Find(cbLicenseClass.SelectedItem.ToString());
            lblApplicationFees.Text = lc.ClassFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctlPersonInformationWithFilter1.SelectedIndex = 0;
            //add items to the combobox from the database DataTable to list all the available driving license types names
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();
            foreach (DataRow dr in dt.Rows)
            {
                //add to combo box cbLicenseClass
                cbLicenseClass.Items.Add(dr["ClassName"].ToString());
            }
            cbLicenseClass.SelectedIndex = 0;
            _ReloadLables();
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            localDrivingLicenseApplication.ApplicantPersonID = ctlPersonInformationWithFilter1.PersonID;
            localDrivingLicenseApplication.ApplicationTypeID = localDrivingLicenseApplication.ApplicationTypeID = (int)clsApplicationType.enType.NewLocalDrivingLicenseService;
            localDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            localDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            localDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            localDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            localDrivingLicenseApplication.PaidFees = float.Parse(lblApplicationFees.Text);
            localDrivingLicenseApplication.LicenseClassID = clsLicenseClass.Find(cbLicenseClass.SelectedItem.ToString()).LicenseClassID;
            if (localDrivingLicenseApplication.Save())
            {
                MessageBox.Show("Application Saved Successfully");
                lblApplicationID.Text = localDrivingLicenseApplication.ApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to save the application");

            }
        }
    }
}
