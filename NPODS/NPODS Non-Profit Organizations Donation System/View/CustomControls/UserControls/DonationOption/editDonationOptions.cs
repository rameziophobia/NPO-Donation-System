using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using System;
using System.Windows.Forms;


namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class editDonationOptions : UserControl
    {
        private DonationOptions donationOptions;

        public editDonationOptions()
        {
            InitializeComponent();
            this.VisibleChanged += new EventHandler(this.onVisibleChanged);
        }

        private void btn_addOption_MouseClick(object sender, MouseEventArgs ev)
        {
            DonationFlowPanel grpBox = new DonationFlowPanel(donationGroupBoxes.Count + 1);
            this.donationGroupBoxes.Add(grpBox);
            grpBox.lbl_remove.Click += (s, e) =>
            {
                donationGroupBoxes.Remove(grpBox);
            };
            pnl_options.Controls.Add(grpBox);
        }

        private void onVisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                donationOptions = new DonationOptions();
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            foreach(DonationFlowPanel donationGroupBox in donationGroupBoxes)
            {
                int value = 0;
                try
                {
                    value = Convert.ToInt32(donationGroupBox.txt_donationValue.Text);
                }
                catch { }
                    
                appendDonationOption(donationGroupBox.cbo_donation.SelectedItem.ToString(),
                    donationGroupBox.txt_donationName.Text,
                    donationGroupBox.txt_donationDescription.Text,
                    value);
            }
            checkCustomSubscription();
            checkCustomSinglePayment();
            Console.WriteLine("hi");
            // todo display el7aga elli kanet mawgooda already ??
            // todo set current_org.DonationOptions = donationOptions;
        }

        private void appendDonationOption(string type, string name, string description, int value)
        {
            switch (type)
            {
                case "Subscription":
                    donationOptions.appendSubscriptionDonation(new DonationTier(name, description, value));
                    break;
                case "Single Payment":
                    donationOptions.appendSingleDonation(new DonationTier(name, description, value));
                    break;
                case "Miscellaneous":
                    donationOptions.appendMiscDonation(description);
                    break;
            }
        }

        private void checkCustomSubscription()
        {
            if (chk_customSubcription.Checked)
            {
                donationOptions.enableCustomSubscription();
            }
            else
            {
                donationOptions.disableCustomSubscription();
            }
        }

        private void checkCustomSinglePayment()
        {
            if (chk_customSinglePayment.Checked)
            {
                donationOptions.enableCustomSingleDonation();
            }
            else
            {
                donationOptions.disableCustomSingleDonation();
            }
        }
    }
}
