using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.View.UserControls.Header;
using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class HeaderControl : UserControl
    {
        private const string USER_WELCOME = "Hi, ";

        public delegate void OnButtonClick();
        public OnButtonClick OnLoginClick { get; set; }
        public OnButtonClick OnRegisterClick { get; set; }
        public OnButtonClick OnHomeClick { get; set; }
        public OnButtonClick OnAboutUsClick { get; set; }
        public AccountPopup AccountPopup { get; set; }

        public HeaderControl()
        {
            InitializeComponent();
            this.BringToFront();
            btn_home.Click += new EventHandler((sender, e) => OnHomeClick());
            btn_aboutUs.Click += new EventHandler((sender, e) => OnAboutUsClick());
            btn_login.Click += new EventHandler((sender, e) => OnLoginClick());
            btn_register.Click += new EventHandler((sender, e) => OnRegisterClick());
        }

        internal void Logout()
        {
            lbl_username.Visible = false;
            btn_login.Visible = true;
            btn_register.Visible = true;
        }

        public void ShowAccount(Account account)
        {
            lbl_username.Text = USER_WELCOME + account.Name;
            lbl_username.Visible = true;
            btn_login.Visible = false;
            btn_register.Visible = false;
        }

        private void lbl_username_MouseEnter(object sender, EventArgs e)
        {
            AccountPopup.Visible = true;
            AccountPopup.BringToFront();
        }
    }
}
