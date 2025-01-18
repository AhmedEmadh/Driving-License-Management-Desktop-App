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
    public partial class frmAddEditUserInfo : Form
    {
        public frmAddEditUserInfo()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_OnClose(object obj)
        {
            this.Close();
        }

        private void frmAddEditUserInfo_Load(object sender, EventArgs e)
        {
            ctlPersonInformationWithFilter1.SelectedIndex = 0;
        }

        private void tabPersonalInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAddEditPersonInfo().ShowDialog();
        }
    }
}
