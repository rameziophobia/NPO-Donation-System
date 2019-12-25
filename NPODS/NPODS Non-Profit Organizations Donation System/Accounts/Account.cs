using NPODS_Non_Profit_Organizations_Donation_System.Transactions;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public abstract class Account
    {
        public string Email { get; set; }
        public string Name { get; set; }
        [System.NonSerialized] public List<Transaction> transactionHistory;
        public List<Subscription> currentSubscriptions;
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
            saveToDatabase();
        }

        protected abstract void saveToDatabase();
    }
}
