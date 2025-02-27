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
    public partial class frmInternationalDriverLicenseInfo : Form
    {
        int _InternationalDriverLicenseID;
        public frmInternationalDriverLicenseInfo(int InternationalDriverLicenseID)
        {
            InitializeComponent();
            _InternationalDriverLicenseID = InternationalDriverLicenseID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInternationalDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ctlInternationalDrivingLicenseInfo1.InternationalID = _InternationalDriverLicenseID;
        }
    }
}
