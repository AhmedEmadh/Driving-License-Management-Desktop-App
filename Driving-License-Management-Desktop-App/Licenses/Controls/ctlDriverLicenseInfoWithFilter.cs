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

namespace Driving_License_Management_Desktop_App.Licenses.Controls
{

    public partial class ctlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<object> OnLicenseSelected;
        void OnLicenseSelected_handler()
        {
            Action<object> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(this);
            }
        }
        public event Action<object> OnWrongSelection;
        void OnWrongSelection_handler()
        {
            Action<object> handler = OnWrongSelection;
            if (handler != null)
            {
                handler(this);
            }
        }
        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }
            set
            {
                gbFilter.Enabled = value;
            }
        }
        public int LicenseID
        {
            get
            {
                return ctlDriverLicenseInfo1.LicenseID;
            }
            set
            {
                ctlDriverLicenseInfo1.LicenseID = value;
            }
        }
        public clsLicense License
        {
            get
            {
                return ctlDriverLicenseInfo1.License;
            }
            set
            {

            }
        }

        public Button SearchButton
        {
            get
            {
                return btnSearch;
            }
            set
            {
                btnSearch = value;
            }
        }
        public ctlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctlDriverLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {

        }
        void _SearchForLicense()
        {
            try
            {
                ctlDriverLicenseInfo1.LicenseID = int.Parse(tbFilter.Text);
                if (ctlDriverLicenseInfo1.LicenseID > 0)
                {
                    OnLicenseSelected_handler();
                }
                else
                {
                    OnWrongSelection_handler();
                }

            }
            catch
            {
                MessageBox.Show("Please enter a valid License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control keys (Backspace, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Blocks non-numeric input
            }

            // Check for Enter key
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevents the "ding" sound
                _SearchForLicense();
            }

        }

        private void tbFilter_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //_SearchForLicense();
            }
        }
    }
}
