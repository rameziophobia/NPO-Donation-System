namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public interface IDonationOptions
    {
        void appendSubscriptionDonation (DonationTier donationTier);
        void appendSingleDonation (DonationTier donationTier);
        void appendMiscDonation (string link);
        void enableCustomSubscription();
        void enableCustomSingleDonation ();
        void disableCustomSubscription();
        void disableCustomSingleDonation ();
    }
}