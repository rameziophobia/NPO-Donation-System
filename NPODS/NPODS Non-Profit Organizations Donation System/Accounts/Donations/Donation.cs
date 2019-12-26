using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class Donation //todo temp not abstract
    {
        private List<DonationTier> donationTiers;

        public bool customEnabled { get; set; }
        public List<DonationTier> DonationTiers { get => donationTiers; set => donationTiers = value; }

        public Donation(List<DonationTier> donationTiers)
        {
            DonationTiers = donationTiers;
        }

        public Donation(): this(new List<DonationTier>())
        {
            customEnabled = false;
            DonationTiers = donationTiers;
        }
        public virtual bool isNull()
        {
            return false;
        }
    }
}
