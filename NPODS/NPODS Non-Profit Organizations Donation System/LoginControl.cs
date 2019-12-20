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
            Console.WriteLine(loginVerification.VerifyUser(txt_email.Text, txt_password.Text));
        }
    }
}
