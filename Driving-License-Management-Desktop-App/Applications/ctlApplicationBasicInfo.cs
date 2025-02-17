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
        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }
            set
            {
                clsApplication application = clsApplication.FindBaseApplication(value);
                if (application != null)
                {
                    _ApplicationID = value;
                    lblAppID.Text = application.ApplicationID.ToString();
                    lblApplicant.Text = application.ApplicantPersonInfo.FullName;
                    lblCreatedBy.Text = application.CreatedByUserInfo.UserName;
                    lblDate.Text = application.ApplicationDate.ToString();
                    lblFees.Text = application.PaidFees.ToString();
                    lblStatus.Text = application.StatusText;
                    lblStatusDate.Text = application.LastStatusDate.ToString();
                    lblType.Text = application.ApplicationTypeInfo.Title;
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
        }
    }
}
