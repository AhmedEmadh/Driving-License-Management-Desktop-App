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
    public partial class ctlPersonInformationWithFilter : UserControl
    {
        public string SearchText
        {
            get
            {
                return tbSearchBar.Text;
            }
            set
            {
                tbSearchBar.Text = value;
            }
        }

        public bool FilterEnabled
        {
            get
            {
                return groupBox1.Enabled;
            }
            set
            {
                groupBox1.Enabled = value;
            }
        }

        public event Action<object> OnAdd;
        public void OnAdd_handler()
        {
            Action<object> Add_action = OnAdd;
            if (Add_action != null)
            {
                Add_action(this);
            }
        }
        public event Action<object> OnSearch;
        public void OnSearch_handler()
        {
            Action<object> handler = OnSearch;
            if (handler != null)
            {
                handler(this);
            }
        }
        public bool ShowAddPersonButton
        {
            get
            {
                return btnAdd.Visible;
            }
            set
            {
                btnAdd.Visible = value;
            }
        }
        public int PersonID
        {
            get
            {
                return ctlPersonInformation1.PersonID;
            }
            set
            {
                ctlPersonInformation1.PersonID = value;
            }
        }
        public event Action<object> OnPersonSelected;
        void OnPersonSelected_handler()
        {
            Action<object> PersonSelected_action = OnPersonSelected;
            if (PersonSelected_action != null)
            {
                PersonSelected_action(this);
            }
        }
        public int SelectedIndex
        {
            get
            {
                return cbCategory.SelectedIndex;
            }
            set
            {
                cbCategory.SelectedIndex = value;
            }
        }

        public ctlPersonInformationWithFilter()
        {
            InitializeComponent();
        }
        public ctlPersonInformationWithFilter(int PersonID)
        {
            InitializeComponent();
            ctlPersonInformation1.PersonID = PersonID;
        }
        private void ctlPersonInformationWithFilter_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
        }
        private void SearchByPersonID()
        {
            int personId;
            if (int.TryParse(tbSearchBar.Text, out personId))
            {
                ctlPersonInformation1.PersonID = personId;
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.");
            }
        }
        private void SearchByNationalNum()
        {
            ctlPersonInformation1.PersonNationalNo = tbSearchBar.Text;
        }
        private void Search()
        {
            switch (cbCategory.SelectedItem.ToString())
            {
                case "Person ID":
                    SearchByPersonID();
                    break;
                case "National No":
                    SearchByNationalNum();
                    break;
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            
        }


        private void tbSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);  // Call the search button click event
                e.SuppressKeyPress = true;   // Prevents the beep sound
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddEditPersonInfo().ShowDialog();
        }

        private void ctlPersonInformation1_OnPersonSelected(object obj)
        {
            OnPersonSelected_handler();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
