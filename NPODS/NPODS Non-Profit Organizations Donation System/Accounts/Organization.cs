using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donation;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    class Organization : Account
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoFilePath { get; set; }
        public string Email { get; set; }
        public bool Certified { get; private set; }
        public MiscDonation[] MiscDonations { get; set; }
        public SubDonation SubDonation { get; set; }
        public SingleDonation SingleDonation { get; set; }
        public DonationGoal DonationGoal { get; set; }
        public OrganizationStatistics OrganizationStatistics { get; set; }

        public Organization(string email, string pasword, string name, string description, string logoFilePath, bool certified, MiscDonation[] miscDonations, SubDonation subDonation, SingleDonation singleDonation, Donation.DonationGoal donationGoal, OrganizationStatistics organizationStatistics): base(email, pasword)
        {
            Name = name;
            Description = description;
            Email = email;
            LogoFilePath = logoFilePath;
            Certified = certified;
            MiscDonations = miscDonations;
            SubDonation = subDonation;
            SingleDonation = singleDonation;
            DonationGoal = donationGoal;
            OrganizationStatistics = organizationStatistics;
        }
    }
}
