using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Payment;

namespace NPODS_Non_Profit_Organizations_Donation_System.Transaction
{
    class Transaction
    {
        private Organization organization;
        private Donor donor;
        //todo date
        private int value;
        private IPaymentMethod paymentMethod;

        public Transaction(Organization organization, Donor donor, int value)
        {
            this.organization = organization;
            this.donor = donor;
            this.value = value;
        }
        //todo private paymentMethod
    }
}
