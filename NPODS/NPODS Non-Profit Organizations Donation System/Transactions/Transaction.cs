using NPODS_Non_Profit_Organizations_Donation_System.Accounts;

namespace NPODS_Non_Profit_Organizations_Donation_System.Transactions
{
    public abstract class Transaction
    {
        private readonly Organization organization;
        private readonly Donor donor;
        private readonly System.DateTime date;
        private readonly int value;

        public Transaction(Organization organization, Donor donor, int value)
        {
            this.organization = organization;
            this.donor = donor;
            this.value = value;
            this.date = System.DateTime.Now;
            donor.pay(this);
            organization.recieve(this);
        }
    }
}
