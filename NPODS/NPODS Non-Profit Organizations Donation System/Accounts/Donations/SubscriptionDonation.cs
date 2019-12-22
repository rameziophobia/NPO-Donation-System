using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    class SubscriptionDonation : Donation
    {
        public SubscriptionDonation(List<DonationTier> donationTiers) : base(donationTiers)
        {
        }
        public SubscriptionDonation() : base(new List<DonationTier> { })
        {
        }

    }
}
