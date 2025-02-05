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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }
        public frmManagePeople(string Name)
        {
            InitializeComponent();

        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            ctlManagePersons1.Value = "People";
            ctlManagePersons1.ButtonValue = "Person";
            this.CancelButton = ctlManagePersons1.CloseButton;
            ctlManagePersons1.Data = clsPerson.GetAllPeople();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            

        }
        void Databack(object sender, int ID)
        {
            ctlManagePersons1.SearchText = ID.ToString();
        }
        private void userControl21_OnAdd(object obj)
        {

            frmAddEditPersonInfo form = new frmAddEditPersonInfo();
            form.DataBack += Databack;
            form.ShowDialog();
        }

        private void userControl21_OnClose(object obj)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmPersonDetails(1023).ShowDialog();
        }
    }
}
