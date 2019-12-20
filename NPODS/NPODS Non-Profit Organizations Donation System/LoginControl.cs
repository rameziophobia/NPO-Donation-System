using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class LoginControl : UserControl
    {
        private readonly LoginVerification loginVerification;

        public LoginControl()
        {
            loginVerification = new LoginVerification();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string password = txt_password.Text;
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine(loginVerification.VerifyUser(email, password));
            }
        }
    }
}
