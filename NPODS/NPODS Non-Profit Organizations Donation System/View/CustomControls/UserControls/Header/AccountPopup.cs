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

            btn_viewDashboard.Click += new System.EventHandler((sender, e) => OnViewDashboardClick());
            btn_editAccount.Click += new System.EventHandler((sender, e) => OnEditAccountClick());
            btn_logOut.Click += new System.EventHandler((sender, e) => OnLogOutClick());
        }

        private void flowLayoutPanel1_MouseLeave(object sender, System.EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(MousePosition)))
                return;
            Visible = false;
        }

        private void btn_logOut_Click(object sender, System.EventArgs e)
        {
            Visible = false;
        }
    }
}
