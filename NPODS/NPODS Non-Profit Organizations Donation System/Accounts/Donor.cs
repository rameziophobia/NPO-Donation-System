using NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess;
using NPODS_Non_Profit_Organizations_Donation_System.Payment;
using NPODS_Non_Profit_Organizations_Donation_System.Transactions;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public class Donor : Account
    {
        public string Gender { set; get; }
        public System.DateTime Birthday { set; get; }
        [System.NonSerialized] public IPaymentMethod PaymentMethod;
        public Donor(string email, string name) : base(email, name)
        {
        }

        public void pay(Transaction transaction)
        {
            try
            {
                PaymentMethod.verifyPayment(transaction);
            }
            catch
            {
                return;
            }
            PaymentMethod.pay(transaction);
            transactionHistory.Add(transaction);
            saveToDatabase();
        }

        protected override void saveToDatabase()
        {
            DatabaseAccess.getInstance().saveDonor(this);
        }
    }
}
