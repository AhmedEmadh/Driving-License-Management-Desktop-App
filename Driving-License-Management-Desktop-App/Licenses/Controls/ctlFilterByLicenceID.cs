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
    public partial class ctlFilterByLicenceID : UserControl
    {
        public Button SearchButton
        {
            get
            {
                return button1;
            }
            set
            {
                button1 = value;
            }
        }
        public ctlFilterByLicenceID()
        {
            InitializeComponent();
        }

        private void ctlFilterByLicenceID_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
