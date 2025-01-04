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
    public partial class frmMainMenu : Form
    {
        Form _CallerForm;
        public frmMainMenu()
        {
            InitializeComponent();
        }
        public frmMainMenu(Form form)
        {
            InitializeComponent();
            _CallerForm = form;
            form.Hide();
        }
    }
}
