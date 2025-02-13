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

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
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
        void _InitalizeDataGridView()
        {
            dgvPeople.DataSource = _dtPeople;

            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gender";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;
            }
        }
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _InitalizeDataGridView();

        }

        private void userControl21_Load(object sender, EventArgs e)
        {


        }
        void Databack(object sender, int ID)
        {
            //ctlManagePersons1.SearchText = ID.ToString();
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
            new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value).ShowDialog();
        }
        void _RefreshData()
        {
            // Refresh the data from the data source
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                           "FirstName", "SecondName", "ThirdName", "LastName",
                                                           "GendorCaption", "DateOfBirth", "CountryName",
                                                           "Phone", "Email");

            // Rebind the DataGridView to the updated data
            dgvPeople.DataSource = _dtPeople;

            // Update the record count label
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddEditPersonInfo().ShowDialog();
            _RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gender":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (tbSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbSearch.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbSearch.Text.Trim());

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

        }
        void _Change_Search_Box_Visibility()
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Change_Search_Box_Visibility();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            new frmAddEditPersonInfo(PersonID).ShowDialog();
            _RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Name = (string)dgvPeople.CurrentRow.Cells["FirstName"].Value;
            int PersonID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;
            if (MessageBox.Show($"Are you Sure that you want to delete person {Name}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clsPerson person = clsPerson.Find(PersonID);
                person.DeletePerson();
                _RefreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmAddEditPersonInfo().ShowDialog();
            _RefreshData();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "Person ID")
            {
                // Allow digits (0-9), Backspace, and Delete
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignore the key press
                }
            }

        }
    }
}
