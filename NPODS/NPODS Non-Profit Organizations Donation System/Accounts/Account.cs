using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public class Account
    {
        private string email;
        // todo https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local
        private string password;
        //todo transactionHistory
        //todo currentSubscriptions
        //todo account dataBase ? a3mellaha interface IAccountDB
        public Account(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void changePassword(string oldPassword, string newPassword)
        {
            if (oldPassword.Equals(password)){
                password = newPassword;
            }
        }
    }

}
