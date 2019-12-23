using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class LoginControl : UserControl
    {
        public delegate void OnAction(Account account, bool isOrganization);

        public OnAction OnLogin { get; set; }

        private const string LOGIN_STATUS_MSG_INVALID_PASSWORD = "Invalid Password";
        private const string LOGIN_STATUS_MSG_NOT_REGISTERED = "User Not Registered";
        private const string LOGIN_STATUS_MSG_INVALID_EMAIL = "Invalid Email";

        private readonly LoginManager loginManager;

        public LoginControl()
        {
            loginManager = new LoginManager();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();

            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                showLoginStatus(LOGIN_STATUS_MSG_INVALID_EMAIL);
                return;
            }

            string password = txt_password.Text;
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    LoginInfo loginInfo = loginManager.getUser(email, password);
                    if (loginInfo.AccountType == AccountType.Donor) // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
                    {
                        OnLogin(loginManager.findDonor(loginInfo.Email), false);
                    }
                    else
                    {
                        OnLogin(loginManager.findOrganization(loginInfo.Email), true);
                    }
                }
                catch (UserNotRegisteredException)
                {
                    showLoginStatus(LOGIN_STATUS_MSG_NOT_REGISTERED);
                }
                catch (WrongPasswordException)
                {
                    showLoginStatus(LOGIN_STATUS_MSG_INVALID_PASSWORD);
                }
            }
            else
            {
                hideLoginStatus();
            }
        }

        private void showLoginStatus(string MSG)
        {
            lbl_loginStatus.Text = MSG;
            lbl_loginStatus.Visible = true;
        }

        private void hideLoginStatus()
        {
            lbl_loginStatus.Visible = false;
        }

        private void btn_recoverPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginControl_VisibleChanged(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_password.Text = "";
            chk_rememberMe.Checked = false;
            hideLoginStatus();
        }
    }
}
