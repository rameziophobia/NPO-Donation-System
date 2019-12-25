using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class SingleDonation : Donation
    {
        public SingleDonation(List<DonationTier> donationTiers) : base(donationTiers)
        {
        }
        public SingleDonation() : base(new List<DonationTier>())
        {
        }
    }
}
