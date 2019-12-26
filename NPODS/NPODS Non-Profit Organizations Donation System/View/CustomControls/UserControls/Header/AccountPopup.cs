using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.UserControls.Header
{
    public partial class AccountPopup : UserControl
    {
        public delegate void OnButtonClick();

        public OnButtonClick OnViewDashboardClick { get; set; }
        public OnButtonClick OnEditAccountClick { get; set; }
        public OnButtonClick OnLogOutClick { get; set; }

        public AccountPopup()
        {
            InitializeComponent();
            btn_viewDashboard.Click += new EventHandler((sender, e) => OnViewDashboardClick());
            btn_viewDashboard.Click += hidePopup;
            btn_editAccount.Click += new EventHandler((sender, e) => OnEditAccountClick());
            btn_editAccount.Click += hidePopup;
            btn_logOut.Click += new EventHandler((sender, e) => OnLogOutClick());
            btn_logOut.Click += hidePopup;
        }

        private void hidePopup(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void flowLayoutPanel1_MouseLeave(object sender, System.EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(MousePosition)))
                return;
            Visible = false;
        }
    }
}
