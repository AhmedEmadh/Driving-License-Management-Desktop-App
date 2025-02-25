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
    public partial class ctlDriverLicenses : UserControl
    {
        int _DriverID;
        clsDriver _Driver;
        DataTable _dtDriverLocalLicensesHistory;
        DataTable _dtDriverLocalLicensesHistorySorted;

        DataTable _dtInternationalLicensesHistory;
        DataTable _dtInternationalLicensesHistorySorted;

        public int DriverID
        {
            get
            {
                return _DriverID;
            }
            set
            {
                _Driver = clsDriver.FindByDriverID(value);
                if (_Driver != null)
                {
                    _DriverID = value;
                    _SetValues();
                }
            }
        }
        void _SetLocal()
        {
            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses(_DriverID);
            if (_dtDriverLocalLicensesHistory.Rows.Count > 0)
            {
                _dtDriverLocalLicensesHistorySorted = _dtDriverLocalLicensesHistory.AsEnumerable()
                                   .OrderByDescending(row => row.Field<int>("LicenseID"))
                                   .CopyToDataTable();
            }
            else
            {
                _dtDriverLocalLicensesHistorySorted = _dtDriverLocalLicensesHistory.Clone(); // Create an empty DataTable with the same schema
            }
            dgvLocalLicenseHistory.DataSource = _dtDriverLocalLicensesHistorySorted;
            lblRecordCountLocal.Text = dgvLocalLicenseHistory.Rows.Count.ToString();

        }
        void _SetInternational()
        {
            _dtInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);
            if (_dtInternationalLicensesHistory.Rows.Count > 0)
            {
                _dtInternationalLicensesHistorySorted = _dtInternationalLicensesHistory.AsEnumerable()
                                   .OrderByDescending(row => row.Field<int>("LicenseID"))
                                   .CopyToDataTable();
            }
            else
            {
                _dtInternationalLicensesHistorySorted = _dtInternationalLicensesHistory.Clone(); // Create an empty DataTable with the same schema
            }
            dgvInternationalLicenseHistory.DataSource = _dtInternationalLicensesHistorySorted;
            lblCountInternational.Text = dgvInternationalLicenseHistory.Rows.Count.ToString();
        }
        void _SetValues()
        {
            _SetLocal();
            _SetInternational();
        }
        public ctlDriverLicenses()
        {
            InitializeComponent();
        }
        int _GetCurrentDataRowLicenseID()
        {
            int CurrentRow = dgvLocalLicenseHistory.CurrentRow.Index;
            int LocalDrivingLicenseApplicationID = int.Parse(dgvLocalLicenseHistory.CurrentRow.Cells[0].Value.ToString());
            return LocalDrivingLicenseApplicationID;
        }
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = _GetCurrentDataRowLicenseID();
            new frmShowLicenseInfo(LicenseID).ShowDialog();
        }
    }
}
