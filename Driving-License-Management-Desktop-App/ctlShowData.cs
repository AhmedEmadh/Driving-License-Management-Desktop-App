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
    public partial class ctlShowData : UserControl
    {

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public event Action<object> OnClose;
        void OnClose_handler()
        {
            Action<object> Close_action = OnClose;
            if (Close_action != null)
            {
                Close_action(this);
            }
        }

        public ctlShowData()
        {
            InitializeComponent();
        }
        public ctlShowData(string title)
        {
            InitializeComponent();
            lblTitle.Text = title;
        }
        private void ctlShowData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClose_handler();
        }
    }
}
