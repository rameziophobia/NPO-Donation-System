using NPODS_Non_Profit_Organizations_Donation_System.Transactions;

namespace NPODS_Non_Profit_Organizations_Donation_System.Payment
{
    //strategy pattern ?
    interface IPaymentMethod
    {
        bool verifyPayment(Transaction transaction);
        void pay(Transaction transaction);
    }
}
