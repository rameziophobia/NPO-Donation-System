using NPODS_Non_Profit_Organizations_Donation_System.Accounts;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.Login
{
    public class LoginInfo
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public AccountType AccountType { get; set; }

        public LoginInfo(string email, string passwordHash, AccountType accountType)
        {
            Email = email;
            PasswordHash = passwordHash;
            AccountType = accountType;
        }
    }
}
