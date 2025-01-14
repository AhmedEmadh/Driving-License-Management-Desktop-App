﻿using System;
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
    public partial class ctlManagePersons : UserControl
    {

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


        public string Value
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
        public string ButtonValue
        {
            set { button2.Text = "add " + value; }
        }
        public ctlManagePersons()
        {
            InitializeComponent();
        }
        public ctlManagePersons(string Value)
        {
            InitializeComponent();
            label5.Text = Value;
        }
        
        private void UserControl2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnAdd_handler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClose_Handler();
        }
    }
}
