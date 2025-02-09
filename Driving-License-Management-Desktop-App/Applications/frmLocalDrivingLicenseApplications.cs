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
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVisionTestAppointments().ShowDialog();
        }

        private void ctlManagePersons1_Load(object sender, EventArgs e)
        {

        }

        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            ctlManagePersons1.ContextMenuStrip = contextMenuStrip1;
            this.CancelButton = ctlManagePersons1.CloseButton;
            ctlManagePersons1.AddButtonText = "Add Application";
        }

        private void ctlManagePersons1_OnAdd(object obj)
        {
            new frmNewLocalDrivingLicenseApplication().ShowDialog();
        }
    }
}
