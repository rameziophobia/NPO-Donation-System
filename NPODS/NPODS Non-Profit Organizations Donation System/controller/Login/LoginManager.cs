using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.Login
{
    public class LoginManager
    {
        public LoginInfo getUser(string email, string password)
        {
            List<LoginInfo> loginInfos = DatabaseAccess.DatabaseAccess.getInstance().loadLoginInfos();
            email = email.ToLower();
            LoginInfo loginInfo = loginInfos.Find((match) => match.Email == email);
            if (!(loginInfo is null))
            {
                using (SHA256 sha = SHA256.Create())
                {
                    string inputPasswordHash = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
                    if (loginInfo.PasswordHash == inputPasswordHash)
                    {
                        return loginInfo;
                    }
                    else
                    {
                        throw new WrongPasswordException();
                    }
                }
            }
            else
            {
                throw new UserNotRegisteredException(email);
            }
        }

        internal Organization findOrganization(string email)
        {
            email = email.ToLower();
            return DatabaseAccess.DatabaseAccess.getInstance().loadOrganizations().Find((match) => match.Email == email);
        }
        internal Donor findDonor(string email)
        {
            email = email.ToLower();
            return DatabaseAccess.DatabaseAccess.getInstance().loadDonors().Find((match) => match.Email == email);
        }
    }
}
