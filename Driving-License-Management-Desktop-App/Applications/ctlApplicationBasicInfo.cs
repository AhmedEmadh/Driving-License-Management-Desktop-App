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

namespace Driving_License_Management_Desktop_App.Applications
{
    public partial class ctlApplicationBasicInfo : UserControl
    {
        public event Action<object> OnLinkClick;
        void OnLinkClick_handler()
        {
            Action<object> handler = OnLinkClick;
            if (handler != null)
            {
                handler(this);
            }
        }
        private int _ApplicationID;
        clsApplication _Application;
        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }
            set
            {
                _Application = clsApplication.FindBaseApplication(value);
                if (_Application != null)
                {
                    _ApplicationID = value;
                    lblAppID.Text = _Application.ApplicationID.ToString();
                    lblApplicant.Text = _Application.ApplicantPersonInfo.FullName;
                    lblCreatedBy.Text = _Application.CreatedByUserInfo.UserName;
                    lblDate.Text = _Application.ApplicationDate.ToString();
                    lblFees.Text = _Application.PaidFees.ToString();
                    lblStatus.Text = _Application.StatusText;
                    lblStatusDate.Text = _Application.LastStatusDate.ToString();
                    lblType.Text = _Application.ApplicationTypeInfo.Title;
                }
                else
                {
                    _SetValuesToDefault();
                }
            }
        }
        void _SetValuesToDefault()
        {
            lblAppID.Text = "???";
            lblApplicant.Text = "???";
            lblCreatedBy.Text = "???";
            lblDate.Text = "???";
            lblFees.Text = "???";
            lblStatus.Text = "???";
            lblStatusDate.Text = "???";
            lblType.Text = "???";
        }
        public ctlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private void ctlApplicationBasicInfo_Load(object sender, EventArgs e)
        {

        }

        private void llblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnLinkClick_handler();
            if (_Application != null)
            {
                new frmPersonDetails(_Application.ApplicantPersonInfo.PersonID).ShowDialog();
            }
        }
    }
}
