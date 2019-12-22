using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class chooseDonationOption : UserControl
    {
        public Organization Organization { get; set; }
        public delegate void OnButtonClick();
        public OnButtonClick OnBackPress { get; set; }

        private readonly System.Drawing.Color COLOR_SELECTED = System.Drawing.Color.FromArgb(199, 236, 238);
        private readonly System.Drawing.Color COLOR_NOT_SELECTED = System.Drawing.Color.FromArgb(199, 216, 238);
        private List<Donation> availableTypes = new List<Donation>();

        public chooseDonationOption()
        {
            InitializeComponent();
        }

        private void btn_singlePayment_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(Organization.SingleDonation.getOptions().ToArray());
            pnl_customDonation.Visible = Organization.SingleDonation.customEnabled;
        }

        private void btn_subscription_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(Organization.SubscriptionDonation.getOptions().ToArray());
            pnl_customDonation.Visible = Organization.SubscriptionDonation.customEnabled;
        }

        private void btn_miscellaneous_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(getMiscOptionsButtons(Organization.MiscDonations).ToArray());
        }

        private void selectColor(Button button)
        {
            btn_singlePayment.BackColor = COLOR_NOT_SELECTED;
            btn_subscription.BackColor = COLOR_NOT_SELECTED;
            btn_miscellaneous.BackColor = COLOR_NOT_SELECTED;
            button.BackColor = COLOR_SELECTED;
        }

        private List<DonationButton> getMiscOptionsButtons(List<MiscDonation> miscDonations)
        {
            List<DonationButton> btns = new List<DonationButton>();
            foreach (MiscDonation miscDonation in miscDonations)
            {
                DonationButton btn = new DonationButton();
                btn.Lbl_donationValue.Visible = false;
                btn.Lbl_monthly.Visible = false;
                btn.Lbl_tierName.Visible = false;
                btn.Lbl_description.Text = miscDonation.Link;
                btns.Add(btn);
            }
            return btns;
        }

        public void setAvailableTypes()
        {
            if (!(Organization.SingleDonation is NullDonation)) 
            {
                btn_singlePayment.Visible = true;
                availableTypes.Add(Organization.SingleDonation);
            }
            if (!(Organization.SubscriptionDonation is NullDonation))
            {
                btn_subscription.Visible = true;
                availableTypes.Add(Organization.SubscriptionDonation);
            }
            if(Organization.MiscDonations.Count > 0)
            {
                btn_miscellaneous.Visible = true;
            }
        }
        public void updateDefault()
        {
            pnl_displayOptions.Controls.Clear();
            if (availableTypes.Count > 0)
            {
                pnl_displayOptions.Controls.AddRange(availableTypes[0].getOptions().ToArray());
                pnl_customDonation.Visible = availableTypes[0].customEnabled;
            }
            else if (Organization.MiscDonations.Count > 0)
            {
                pnl_displayOptions.Controls.AddRange(getMiscOptionsButtons(Organization.MiscDonations).ToArray());
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackPress();
        }
    }
}
