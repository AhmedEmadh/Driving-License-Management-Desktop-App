﻿using Driving_License_Management_BusinessLogic;
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
    public partial class frmListInternationalLicenseApplications : Form
    {
        int _InternationalLicenseID;
        clsInternationalLicense _InternationalLicense;
        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }
        void _ReloadData()
        {
            dgvDrivers.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
        }
        void _AdjustColomns()
        {
            dgvDrivers.Columns[0].Width = 175;
            dgvDrivers.Columns[1].Width = 100;
            dgvDrivers.Columns[2].Width = 75;
            dgvDrivers.Columns[3].Width = 200;
            dgvDrivers.Columns[4].Width = 200;
            dgvDrivers.Columns[5].Width = 200;
            dgvDrivers.Columns[6].Width = 200;
            dgvDrivers.Columns[7].Width = 200;
        }
        void _InitalizeDataGridView()
        {
            _ReloadData();
            _AdjustColomns();
        }
        private void frmListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _InitalizeDataGridView();
        }
        int _GetInternationalLicenseID()
        {
            //return int From Data Grid View at Current Row with Cell Index 0
            return int.Parse(dgvDrivers.CurrentRow.Cells[0].Value.ToString());
        }
        private void ctlManagePersons1_OnClose(object obj)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _InternationalLicenseID = _GetInternationalLicenseID();
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            new frmPersonDetails(_InternationalLicense.DriverInfo.PersonID).ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _InternationalLicenseID = _GetInternationalLicenseID();
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            new frmInternationalDriverLicenseInfo(_InternationalLicenseID).ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _InternationalLicenseID = _GetInternationalLicenseID();
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            new frmShowLicenseHistory(_InternationalLicense.DriverInfo.PersonID).ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmNewInternationalLicenseApplication().ShowDialog();
            _ReloadData();
        }
    }
}
