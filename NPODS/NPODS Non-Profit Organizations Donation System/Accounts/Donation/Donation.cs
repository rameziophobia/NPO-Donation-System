using NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donation
{
    public abstract class Donation
    {
        public bool enabled { get; set; }
        public DonationTier[] DonationTiers { get; set; }

        public Donation(bool enabled, DonationTier[] donationTiers)
        {
            this.enabled = enabled;
            DonationTiers = donationTiers;
        }
        public abstract List<DonationButton> getOptions();
    }
}
