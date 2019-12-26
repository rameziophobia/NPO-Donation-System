using NPODS_Non_Profit_Organizations_Donation_System.Accounts;

namespace NPODS_Non_Profit_Organizations_Donation_System.Transactions
{
    class SubscriptionTransaction : Transaction
    {
        public SubscriptionTransaction(Organization organization, Donor donor, int value) : base(organization, donor, value)
        {
        }
    }
}
