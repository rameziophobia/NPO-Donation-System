using NPODS_Non_Profit_Organizations_Donation_System.Transactions;

namespace NPODS_Non_Profit_Organizations_Donation_System.Payment
{
    class Paypal : IPaymentMethod
    {
        public void pay(Transaction transaction)
        {
        }

        public bool verifyPayment(Transaction transaction)
        {
            return true;
        }
    }
}
