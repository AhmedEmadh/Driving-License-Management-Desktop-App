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
    public partial class frmListInternationalLicenseApplications : Form
    {
        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            ctlManagePersons1.Title = "International License Applications";
            ctlManagePersons1.ButtonValue = "License";
            ctlManagePersons1.contextMenuStrip = contextMenuStrip1;
            this.CancelButton = ctlManagePersons1.CloseButton;
        }

        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }
    }
}
