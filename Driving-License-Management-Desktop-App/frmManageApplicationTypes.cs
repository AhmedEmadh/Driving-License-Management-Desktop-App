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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlShowData1_OnClose(object obj)
        {
            this.Close();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            ctlShowData1.Title = "Application Types";
        }
    }
}
