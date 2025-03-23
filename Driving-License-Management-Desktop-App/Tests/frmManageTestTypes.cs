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
    public partial class frmManageTestTypes : Form
    {
        DataTable _dt;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }
        void _LoadData()
        {
            _dt = clsTestType.GetAllTestTypes();
            _dt.Columns[0].ColumnName = "ID";
            _dt.Columns[1].ColumnName = "Title";
            _dt.Columns[2].ColumnName = "Description";
            _dt.Columns[3].ColumnName = "Fees";
            dgvTestTypes.DataSource = _dt;
            ////set width
            //dgvTestTypes.Columns[0].Width = 50;
            //dgvTestTypes.Columns[1].Width = 120;
            //dgvTestTypes.Columns[2].Width = 237;
            //dgvTestTypes.Columns[3].Width = 100;
            //Update Record Count
            lblRecordsCount.Text = _dt.Rows.Count.ToString();

        }
        void _AdjustColomns()
        {
            dgvTestTypes.Columns[0].Width = 50;
            dgvTestTypes.Columns[1].Width = 170;
            dgvTestTypes.Columns[2].Width = 374;
            dgvTestTypes.Columns[3].Width = 100;
        }
        void _InitalizeDataGridView()
        {
            _LoadData();
            _AdjustColomns();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _InitalizeDataGridView();
            
        }

        private void ctlShowData1_OnClose(object obj)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = Convert.ToInt32(dgvTestTypes.CurrentRow.Cells["ID"].Value);
            new frmUpdateTestType(TestTypeID).ShowDialog();
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
