using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller
{
    public class LoginVerification
    {
        private readonly Dictionary<string, string> loginInfos;

        public LoginVerification()
        {
            loginInfos = DatabaseAccess.getInstance().GetLoginInfos();
        }

        public bool verifyUser(string email, string password)
        {
            if (loginInfos.ContainsKey(email))
            {
                using(SHA256 sha = SHA256.Create())
                {
                    return loginInfos[email] == Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
                }
            }
            return false;
        }
    }
}
