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
        public Button SearchButton
        {
            get
            {
                return ctlFilter1.SearchButton;
            }
            set
            {
                ctlFilter1.SearchButton = value;
            }
        }
        public ctlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctlDriverLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
