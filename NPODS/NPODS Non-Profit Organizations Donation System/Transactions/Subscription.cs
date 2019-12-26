using NPODS_Non_Profit_Organizations_Donation_System.Accounts;

namespace NPODS_Non_Profit_Organizations_Donation_System.Transactions
{
    public class Subscription
    {
        private readonly Organization organization;
        private readonly Donor donor;
        private readonly int value;
        public Subscription(Organization organization, Donor donor, int value)
        {
            this.organization = organization;
            this.donor = donor;
            this.value = value;
            donor.addSubscription(this);
            organization.addSubscription(this);
        }

        public void onMonthly()
        {
            new SubscriptionTransaction(organization, donor, value);
        }
    }
}
