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

namespace Driving_License_Management_Desktop_App.Applications
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationType _applicationType;
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _applicationType = clsApplicationType.Find(ApplicationTypeID);
            if(_applicationType != null)
            {
                lblID.Text = _applicationType.ID.ToString();
                tbTitle.Text = _applicationType.Title;
                tbFees.Text = _applicationType.Fees.ToString();
            }
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _applicationType.Title = tbTitle.Text;
            _applicationType.Fees = float.Parse(tbFees.Text);
            if (_applicationType.Save())
            {
                MessageBox.Show("Application Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Update Application Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //Allow only numbers and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                //cout dots in the text
                if ((sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
