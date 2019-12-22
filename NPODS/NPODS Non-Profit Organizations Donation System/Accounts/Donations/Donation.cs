using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public abstract class Donation
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
        public virtual List<DonationButton> getOptions()
        {
            List<DonationButton> btns_donation = new List<DonationButton>();
            for (int i = 0; i < DonationTiers.Count; i++)
            {
                DonationButton btn = new DonationButton();
                btn.Lbl_tierName.Text = DonationTiers[i].Name;
                btn.Lbl_donationValue.Text = DonationTiers[i].Value.ToString() + "$";
                btn.Lbl_description.Text = DonationTiers[i].Description;
                btns_donation.Add(btn);
            }
            return btns_donation;
        }
        public virtual bool isNull()
        {
            return false;
        }
    }
}
