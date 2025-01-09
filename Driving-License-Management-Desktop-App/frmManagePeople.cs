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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            userControl21.Value = "People";
            userControl21.ButtonValue = "Person";
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            

        }

        private void userControl21_OnAdd(object obj)
        {
            new frmAddEditPersonInfo().ShowDialog();
        }

        private void userControl21_OnClose(object obj)
        {
            this.Close();
        }
    }
}
