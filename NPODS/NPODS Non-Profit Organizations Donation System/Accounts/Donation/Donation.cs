namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donation
{
    public class Donation
    {
        public bool enabled { get; set; }
        public DonationTier[] DonationTiers { get; set; }

        public Donation(bool enabled, DonationTier[] donationTiers)
        {
            this.enabled = enabled;
            DonationTiers = donationTiers;
        }
    }
}
