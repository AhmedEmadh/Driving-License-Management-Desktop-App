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
    public partial class ctlFormTitle : UserControl
    {
        public string titleName
        {
            set
            {
                label1.Text = value;
            }
            get
            {
                return label1.Text;
            }
        }
        public Image picture
        {
            set
            {
                pictureBox1.Image = value;
            }
            get
            {
                return pictureBox1.Image;
            }
        }

        public ctlFormTitle()
        {
            InitializeComponent();
        }

        private void ctlFormTitle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
