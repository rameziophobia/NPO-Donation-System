using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class HeaderControl : UserControl
    {
        public delegate void OnButtonClick();
        public OnButtonClick OnLoginClick { get; set; }
        public OnButtonClick OnRegisterClick { get; set; }
        public OnButtonClick OnHomeClick { get; set; }
        public OnButtonClick OnAboutUsClick { get; set; }

        public HeaderControl()
        {
            InitializeComponent();
        }

        private void btn_aboutUs_Click(object sender, EventArgs e)
        {
            OnAboutUsClick();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            OnLoginClick();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            OnHomeClick();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            OnRegisterClick();
        }
    }
}
