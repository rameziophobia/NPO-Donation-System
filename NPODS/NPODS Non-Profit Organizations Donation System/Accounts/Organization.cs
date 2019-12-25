using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using NPODS_Non_Profit_Organizations_Donation_System.Transactions;
using System.Collections.Generic;
using NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    public class Organization : Account
    {
        public string Description { get; set; }
        public string LogoFilePath { get; set; }
        public bool Certified { get; private set; }
        public List<MiscDonation> MiscDonations { get; set; }
        public Donation SubscriptionDonation { get; set; }
        public Donation SingleDonation { get; set; }
        public DonationGoal DonationGoal { get; set; }
        public OrganizationStatistics OrganizationStatistics { get; set; }
        public string OrganizationUrl { get; set; }

        public Organization(string email, string name) : base(email, name)
        {
            Description = "";
            LogoFilePath = "";
            Certified = false;
            MiscDonations = new List<MiscDonation>();
            SubscriptionDonation = NullDonation.getInstance();
            SingleDonation = NullDonation.getInstance();
            DonationGoal = new DonationGoal(false, 0, 0); // NullDonationGoal ?
            OrganizationStatistics = new OrganizationStatistics();
        }

        public void recieve(Transaction transaction)
        {
            transactionHistory.Add(transaction);
            saveToDatabase();
        }

        protected override void saveToDatabase()
        {
            DatabaseAccess.getInstance().saveOrganisation(this);
        }
    }
}
