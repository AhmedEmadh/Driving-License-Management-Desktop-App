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
        int _PersonID = -1;
        public frmShowLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        public frmShowLicenseHistory()
        {
            InitializeComponent();
        }
        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            // Skip execution if running inside the Designer
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            if (_PersonID != -1)
            {
                ctlPersonInformationWithFilter1.SearchText = _PersonID.ToString();
                ctlPersonInformationWithFilter1.PersonID = _PersonID;
                ctlPersonInformationWithFilter1.FilterEnabled = false;
                ctlDriverLicenses1.DriverID = clsDriver.FindByPersonID(_PersonID).DriverID;
            }
            else
            {
                ctlPersonInformationWithFilter1.FilterEnabled = true;
                ctlPersonInformationWithFilter1.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}