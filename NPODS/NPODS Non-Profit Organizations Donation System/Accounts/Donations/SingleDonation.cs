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
            List<DonationButton> btns_donation = new List<DonationButton>();
            for (int i = 0; i < base.DonationTiers.Length; i++)
            {
                DonationButton btn = new DonationButton();
                btn.Lbl_tierName.Text = base.DonationTiers[i].Name;
                btn.Lbl_donationValue.Text = base.DonationTiers[i].Value.ToString();
                btn.Lbl_monthly.Visible = false;
                btn.Lbl_description.Text = base.DonationTiers[i].Description;
                btns_donation.Add(btn);
            }
            return btns_donation;
        }
    }
}
