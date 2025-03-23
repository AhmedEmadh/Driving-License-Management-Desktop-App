using Driving_License_Management_BusinessLogic;
using Driving_License_Management_Desktop_App.Applications;
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
    public partial class frmManageApplicationTypes : Form
    {
        DataTable _dt;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void _AdjustColomns()
        {
            dgvApplicationTypes.Columns[0].Width = 50;
            dgvApplicationTypes.Columns[1].Width = 369;
            dgvApplicationTypes.Columns[2].Width = 100;
        }
        void _InitalizeDataGridView()
        {
            _UpdateData();
            _AdjustColomns();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _InitalizeDataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void _UpdateData()
        {
            _dt = clsApplicationType.GetAllApplicationTypes();
            _dt.Columns[0].ColumnName = "ID";
            _dt.Columns[1].ColumnName = "Title";
            _dt.Columns[2].ColumnName = "Fees";
            dgvApplicationTypes.DataSource = _dt;
            //set width of columns
            //dgvApplicationTypes.Columns[0].Width = 50;
            //dgvApplicationTypes.Columns[1].Width = 226;
            //dgvApplicationTypes.Columns[2].Width = 100;
            lblRecordsCount.Text = _dt.Rows.Count.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells["ID"].Value);
            new frmUpdateApplicationType(ApplicationTypeID).ShowDialog();
            _UpdateData();
        }
    }
}
