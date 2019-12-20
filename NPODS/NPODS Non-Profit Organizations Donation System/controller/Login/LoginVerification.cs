using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.Login
{
    public class LoginVerification
    {
        private readonly Dictionary<string, string> loginInfos;

        public LoginVerification()
        {
            loginInfos = DatabaseAccess.DatabaseAccess.getInstance().GetLoginInfos();
        }

        public bool VerifyUser(string email, string password)
        {
            email = email.ToLower();
            if (loginInfos.ContainsKey(email))
            {
                using (SHA256 sha = SHA256.Create())
                {
                    return loginInfos[email] == Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
                }
            }
            else
            {
                throw new UserNotRegisteredException(email);
            }
        }
    }
}
