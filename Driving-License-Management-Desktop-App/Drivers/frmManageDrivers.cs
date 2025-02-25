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
    public partial class frmManageDrivers : Form
    {
        DataTable _dtAllDrivers;
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            ctlManagePersons1.Title = "Drivers";
            ctlManagePersons1.ButtonValue = "Driver";
            ctlManagePersons1.contextMenuStrip = contextMenuStrip1;
            this.CancelButton = ctlManagePersons1.CloseButton;

        }

        private void ctlManagePersons1_Load(object sender, EventArgs e)
        {

        }

        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPersonDetails().ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowLicenseHistory().ShowDialog();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
    }
}
