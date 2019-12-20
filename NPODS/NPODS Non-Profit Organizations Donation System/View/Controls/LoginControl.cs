using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class LoginControl : UserControl
    {
        private const string LOGIN_STATUS_MSG_INVALID_PASSWORD = "Invalid Password";
        private const string LOGIN_STATUS_MSG_NOT_REGISTERED = "User Not Registered";

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
                try
                {
                    if (loginVerification.VerifyUser(email, password))
                    {
                        lbl_loginStatus.Text = "(WIP) Succes";
                    }
                    else
                    {
                        lbl_loginStatus.Text = LOGIN_STATUS_MSG_INVALID_PASSWORD;
                    }
                }
                catch (UserNotRegisteredException)
                {
                    lbl_loginStatus.Text = LOGIN_STATUS_MSG_NOT_REGISTERED;
                }
                lbl_loginStatus.Visible = true;
            }
        }

        private void btn_recoverPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
