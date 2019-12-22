using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using NPODS_Non_Profit_Organizations_Donation_System.Transactions;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public class Organization : Account
    {
        public string Description { get; set; }
        public string LogoFilePath { get; set; }
        public bool Certified { get; private set; }
        public DonationOptions DonationOptions { get; set; }
        public DonationGoal DonationGoal { get; set; }
        public OrganizationStatistics OrganizationStatistics { get; set; }
        public string OrganizationUrl { get; set; }

        public Organization(string email, string name) : base(email, name)
        {
            Description = "";
            LogoFilePath = "";
            Certified = false;
            DonationOptions = new DonationOptions();
            DonationGoal = new DonationGoal(false, 0, 0); // NullDonationGoal ?
            OrganizationStatistics = new OrganizationStatistics();
        }

        public void recieve(Transaction transaction)
        {
            transactionHistory.Add(transaction);
        }

    }
}
