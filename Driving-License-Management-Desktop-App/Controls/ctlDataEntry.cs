using Driving_License_Management_Desktop_App.Properties;
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
    public partial class ctlDataEntry : UserControl
    {
        public event Action<object> OnSave;
        void OnSave_Handler(object obj)
        {
            Action<object> handler = OnSave;
            if (handler != null)
            {
                handler(obj);
            }
        }

        public event Action<object> OnClose;
        void OnClose_Handler(object obj)
        {
            Action<object> handler = OnClose;
            if (handler != null)
            {
                handler(obj);
            }
        }
        public event Action<object> OnSetImage;
        void OnSetImage_Handler(object obj)
        {
            Action<object> handler = OnSetImage;
            if (handler != null)
            {
                handler(obj);
            }
        }
        public ctlDataEntry()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSave_Handler(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnClose_Handler(this);
        }

    }
}
