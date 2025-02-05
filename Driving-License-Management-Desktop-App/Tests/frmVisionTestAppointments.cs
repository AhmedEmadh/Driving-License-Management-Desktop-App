using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_Management_Desktop_App
{
    public partial class frmVisionTestAppointments : Form
    {
        public frmVisionTestAppointments()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new btnSave().ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTakeTest().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlApplicationInfo1_OnLinkClicked(object obj)
        {
            new frmPersonDetails().ShowDialog();
        }
    }
}
