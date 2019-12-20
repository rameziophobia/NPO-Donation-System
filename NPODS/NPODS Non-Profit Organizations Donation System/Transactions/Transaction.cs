using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.Transaction
{
    class Transaction
    {
        private OrganizationCard organization;
        private Donor donor;
        //todo date
        private int value;
        private IPaymentMethod paymentMethod;

        public Transaction(OrganizationCard organization, Donor donor, int value)
        {
            this.organization = organization;
            this.donor = donor;
            this.value = value;
        }
        //todo private paymentMethod
    }
}
