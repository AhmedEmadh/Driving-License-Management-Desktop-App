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
    public partial class ctlManagePeople : UserControl
    {
        string SearchBarText
        {
            get { return tbSearch.Text; }
            set { tbSearch.Text = value; }
        }
        Image Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public DataTable Data
        {
            get { return (DataTable)dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; }
        }


        public event Action<Object> OnSearch;
        void OnSearch_handler()
        {
            Action<Object> Search_action = OnSearch;
            if (Search_action != null)
            {
                Search_action(this);
            }
        }
        public event Action<Object> OnSearchTextChange;
        void OnSearchTextChange_handler()
        {
            Action<Object> SearchTextChange_action = OnSearchTextChange;
            if (SearchTextChange_action != null)
            {
                SearchTextChange_action(this);
            }
        }

        public string SearchText
        {
            get { return tbSearch.Text; }
            set { tbSearch.Text = value; }
        }

        public event Action<Object> OnAdd;
        void OnAdd_handler()
        {
            Action<Object> Add_action = OnAdd;
            if (Add_action != null)
            {
                Add_action(this);
            }
        }
        public event Action<Object> OnClose;
        void OnClose_Handler()
        {
            Action<Object> Close_Action = OnClose;
            if (Close_Action != null)
            {
                Close_Action(this);
            }
        }


        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public ContextMenuStrip contextMenuStrip
        {
            set { dataGridView1.ContextMenuStrip = value; }
            get { return dataGridView1.ContextMenuStrip; }
        }
        public string ButtonValue
        {
            set { btnAddPerson.Text = "add " + value; }
        }
        public Button CloseButton
        {
            get { return btnClose; }
            set { btnClose = value; }
        }


        public ctlManagePeople()
        {
            InitializeComponent();
        }
        public ctlManagePeople(string Value)
        {
            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 10;
            dataGridView1.Columns[2].Width = 10;
            dataGridView1.Columns[3].Width = 10;
            InitializeComponent();
            label4.Text = Value;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            tbSearch.Visible = false;
        }
        public string AddButtonText
        {
            get { return btnAddPerson.Text; }
            set { btnAddPerson.Text = value; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OnAdd_handler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClose_Handler();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnSearchTextChange_handler();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int index = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                switch (index)
                {
                    case 0:
                        col.Width = 60;
                        break;
                    case 1:
                        col.Width = 70;
                        break;
                    case 2:
                        col.Width = 70;
                        break;
                    case 3:
                        col.Width = 70;
                        break;
                    default:
                        col.Width = 80; // Set your desired default width
                        break;
                }
                index++;
            }
        }
        void _ChangeSearchBarVisibility()
        {
            if (comboBox1.SelectedItem.ToString() == "None")
            {
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ChangeSearchBarVisibility();

        }
    }
}
