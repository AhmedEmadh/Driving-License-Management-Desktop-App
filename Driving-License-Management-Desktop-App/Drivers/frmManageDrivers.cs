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
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            ctlManagePersons1.Value = "Drivers";
            ctlManagePersons1.ButtonValue = "Driver";
            
        }

        private void ctlManagePersons1_Load(object sender, EventArgs e)
        {

        }

        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }
    }
}
