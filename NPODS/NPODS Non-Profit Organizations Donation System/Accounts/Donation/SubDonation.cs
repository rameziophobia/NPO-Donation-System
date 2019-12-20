namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donation
{
    public class SubDonation : Donation
    {
        public SubDonation(bool enabled, DonationTier[] donationTiers) : base(enabled, donationTiers)
        {
        }
    }
}
