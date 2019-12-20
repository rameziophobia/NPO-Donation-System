namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class Donation
    {
        private DonationTier[] donationTiers;

        public bool customEnabled { get; set; }
        public DonationTier[] DonationTiers { get => donationTiers; set => donationTiers = value; }

        public Donation(DonationTier[] donationTiers)
        {
            customEnabled = false;
            DonationTiers = donationTiers;
        }
    }
}
