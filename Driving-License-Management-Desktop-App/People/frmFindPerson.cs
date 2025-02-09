using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management_Desktop_App.People
{
    public partial class frmFindPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {

        }

        private void frmFindPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this, ctlPersonInformationWithFilter1.PersonID);
        }
    }
}
