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

namespace Driving_License_Management_Desktop_App.User
{
    public partial class ctlUserCard : UserControl
    {
        public ctlUserCard()
        {
            InitializeComponent();
        }
        int _UserID;
        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                clsUser user = clsUser.FindByUserID(value);
                if(user != null)
                {
                    _UserID = user.UserID;
                    ctlPersonInformation1.PersonID = user.PersonID;
                    ctlloginInfo1.UserID = user.UserID;
                }
            }
        }
        private void ctlUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
