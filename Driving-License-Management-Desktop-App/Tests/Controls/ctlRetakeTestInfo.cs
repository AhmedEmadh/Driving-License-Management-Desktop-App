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

namespace Driving_License_Management_Desktop_App.Tests.Controls
{
    public partial class ctlRetakeTestInfo : UserControl
    {
        clsTestType.enTestType _TestType;
        public clsTestType.enTestType TestType
        {
            get
            {
                return _TestType;
            }
            set
            {
                _TestType = value;
                _SetValues(value);
            }
        }
        void _SetValues(clsTestType.enTestType lTestType)
        {
            lblAppFees.Text = clsTestType.Find((int)lTestType).Fees.ToString();
            lblTotalFees.Text = (int.Parse(lblAppFees.Text) + 5).ToString();
        }

        public ctlRetakeTestInfo()
        {
            InitializeComponent();
        }

        private void ctlRetakeTestInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
