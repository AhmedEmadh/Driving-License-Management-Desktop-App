using Driving_License_Management_BusinessLogic;
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
    public partial class frmShowLicenseHistory : Form
    {
        int _PersonID;
        public frmShowLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            ctlDriverLicenses1.DriverID = clsDriver.FindByPersonID(_PersonID).DriverID;
        }
    }
}
