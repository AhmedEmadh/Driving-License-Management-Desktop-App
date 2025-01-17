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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            ctlShowData1.Title = "Test Types";
        }

        private void ctlShowData1_OnClose(object obj)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUpdateTestType().ShowDialog();
        }
    }
}
