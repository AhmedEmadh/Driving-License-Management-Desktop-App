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
    public partial class ctlApplicationInfo : UserControl
    {
        public event Action<Object> OnLinkClicked;
        void LinkClicked_handler()
        {
            Action<Object> LinkClicked_action = OnLinkClicked;
            if (LinkClicked_action != null)
            {
                LinkClicked_action(this);
            }
        }
        public ctlApplicationInfo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked_handler();
        }

        private void ctlApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
