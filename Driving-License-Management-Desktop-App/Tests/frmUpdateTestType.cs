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
    public partial class frmUpdateTestType : Form
    {
        clsTestType _TestType;
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestType = clsTestType.Find(TestTypeID);
            if (_TestType != null)
            {
                lblID.Text = _TestType.ID.ToString();
                tbTitle.Text = _TestType.Title;
                tbDescription.Text = _TestType.Description;
                tbFees.Text = _TestType.Fees.ToString();
            }
            else
            {
                MessageBox.Show("Test Type not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.Title = tbTitle.Text;
            _TestType.Description = tbDescription.Text;
            _TestType.Fees = float.Parse(tbFees.Text);
            if (_TestType.Save())
            {
                MessageBox.Show("Test Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Update Test Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
