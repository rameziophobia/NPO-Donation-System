using NPODS_Non_Profit_Organizations_Donation_System.Transactions;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public class Account
    {
        public string Email { get; set; }
        public string Name { get; set; }
        protected List<Transaction> transactionHistory;
        protected List<Subscription> currentSubscriptions; 
        public Account(string email, string name)
        {
            this.Email = email;
            this.Name = name;
            transactionHistory = new List<Transaction>();
            currentSubscriptions = new List<Subscription>();
        }
        public void addSubscription(Subscription subscription)
        {
            currentSubscriptions.Add(subscription);
        }
    }
}
