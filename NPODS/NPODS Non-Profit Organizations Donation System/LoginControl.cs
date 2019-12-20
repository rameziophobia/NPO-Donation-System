using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.controller;

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
            Console.WriteLine(loginVerification.verifyUser(txt_email.Text, txt_password.Text));
        }
    }
}
