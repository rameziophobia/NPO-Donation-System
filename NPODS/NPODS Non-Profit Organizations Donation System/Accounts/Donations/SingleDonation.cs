using NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class SingleDonation : Donation
    {
        public SingleDonation(DonationTier[] donationTiers) : base(donationTiers)
        {
        }
        public override List<DonationButton> getOptions()
        {
            List<DonationButton> btns_donation = base.getOptions();
            foreach(DonationButton btn in btns_donation)
            {
                btn.Lbl_monthly.Visible = false;
            }
            return btns_donation;
        }
    }
}
