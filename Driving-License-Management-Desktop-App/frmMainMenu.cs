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
    public partial class frmMainMenu : Form
    {
        Form _CallerForm;
        public frmMainMenu()
        {
            InitializeComponent();
        }
        public frmMainMenu(Form form)
        {
            InitializeComponent();
            _CallerForm = form;
            _CallerForm.Hide();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _CallerForm.Close();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmManagePeople().Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUsers().ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageApplicationTypes().ShowDialog();
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CallerForm.Show();
            this.Hide();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageTestTypes().ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmNewLocalDrivingLicenseApplication().ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLocalDrivingLicenseApplications().ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
