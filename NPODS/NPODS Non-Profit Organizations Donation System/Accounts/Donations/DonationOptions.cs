using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class DonationOptions
    {
        public List<MiscDonation> MiscDonations { get; set; }
        public Donation SubscriptionDonation { get; set; }
        public Donation SingleDonation { get; set; }
        
        public DonationOptions()
        {
            MiscDonations = new List<MiscDonation>();
            SubscriptionDonation = NullDonation.getInstance();
            SingleDonation = NullDonation.getInstance();
        }

        public void appendSubscriptionDonation(DonationTier donationTier)
        {
            if (SubscriptionDonation.isNull())
            {
                SubscriptionDonation = new SubscriptionDonation();
            }
            SubscriptionDonation.DonationTiers.Add(donationTier);
        }
        public void appendSingleDonation(DonationTier donationTier)
        {
            if (SingleDonation.isNull())
            {
                SingleDonation = new SingleDonation();
            }
            SingleDonation.DonationTiers.Add(donationTier);
        }
        public void appendMiscDonation(string link)
        {
            MiscDonations.Add(new MiscDonation(link));
        }

        internal void enableCustomSubscription()
        {
            if (SubscriptionDonation.isNull())
            {
                SubscriptionDonation = new SubscriptionDonation();
            }
            SubscriptionDonation.customEnabled = true;
        }

        internal void enableCustomSingleDonation()
        {
            if (SingleDonation.isNull())
            {
                SingleDonation = new SingleDonation();
            }
            SingleDonation.customEnabled = true;
        }
        internal void disableCustomSubscription()
        {
            SubscriptionDonation.customEnabled = false;
        }

        internal void disableCustomSingleDonation()
        {
            SingleDonation.customEnabled = false;
        }
    }
}
