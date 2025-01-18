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
    public partial class ctlShowDataWithFilter : UserControl
    {

        public event Action<Object> OnClose;
        void OnClose_Handler()
        {
            Action<Object> handler = OnClose;
            if (handler != null)
            {
                handler(this);
            }
        }
        public ContextMenuStrip contextMenuStrip
        {
            get
            {
                return ctlShowData1.ContextMenuStrip;
            }
            set
            {
                ctlShowData1.ContextMenuStrip = value;
            }
        }

        public ctlShowDataWithFilter()
        {
            InitializeComponent();
        }

        private void ctlShowDataWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void ctlShowData1_OnClose(object obj)
        {
            OnClose_Handler();
        }
    }
}
