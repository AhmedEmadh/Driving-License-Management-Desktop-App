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
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails()
        {
            InitializeComponent();
        }
        public frmPersonDetails(int ID)
        {
            InitializeComponent();
            ctlPersonInformation1.PersonID = ID;
        }
        public frmPersonDetails(string NationalNo)
        {
            InitializeComponent();
            ctlPersonInformation1.PersonNationalNo = NationalNo;
        }
        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnHiddenClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
