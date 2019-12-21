namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public class Account
    {
        public string Email { get; set; }
        public string Name { get; set; }
        // todo https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local
        //todo transactionHistory
        //todo currentSubscriptions
        //todo account dataBase ? a3mellaha interface IAccountDB
        public Account(string email, string name)
        {
            this.Email = email;
            this.Name = name;
        }

    }

}
