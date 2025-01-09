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
            form.Hide();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _CallerForm.Close();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePeople().Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUsers().Show();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
