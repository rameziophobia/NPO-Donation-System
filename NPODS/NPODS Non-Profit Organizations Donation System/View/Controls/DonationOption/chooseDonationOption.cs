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

        private readonly System.Drawing.Color COLOR_SELECTED = System.Drawing.Color.FromArgb(199, 236, 238);
        private readonly System.Drawing.Color COLOR_NOT_SELECTED = System.Drawing.Color.FromArgb(199, 216, 238);

        public chooseDonationOption()
        {
            InitializeComponent();
        }


        private void btn_singlePayment_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(Organization.SingleDonation.getOptions().ToArray());
        }

        private void btn_subscription_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(Organization.SubscriptionDonation.getOptions().ToArray());
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

        public void updateDefault()
        {
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(Organization.SingleDonation.getOptions().ToArray());
        }
    }
}
