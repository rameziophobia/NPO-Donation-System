using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption;
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
        private Donation donationOption;
        private int defaultOptionFlag = 0;

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
            pnl_customDonation.Visible = false;

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
                defaultOptionFlag += 1;
            }
            if (!(Organization.SubscriptionDonation is NullDonation))
            {
                btn_subscription.Visible = true;
                defaultOptionFlag += 10;
            }
            if (Organization.MiscDonations.Count > 0)
            {
                defaultOptionFlag += 100;
                btn_miscellaneous.Visible = true;
            }
        }
        public void setDefaultOption()
        {
            if (defaultOptionFlag % 2 == 1)
            {
                donationOption = Organization.SingleDonation;
                selectColor(btn_singlePayment);
            }
            else if ((defaultOptionFlag / 10) % 10 == 1)
            {
                donationOption = Organization.SubscriptionDonation;
                selectColor(btn_subscription);
            }
            else if ((defaultOptionFlag / 100) % 10 == 1)
            {
                selectColor(btn_miscellaneous);
            }
        }
        public void updateDefault()
        {
            pnl_displayOptions.Controls.Clear();
            if (donationOption == null && (defaultOptionFlag / 100) % 10 == 1)
            {
                pnl_displayOptions.Controls.AddRange(getMiscOptionsButtons(Organization.MiscDonations).ToArray());
                pnl_customDonation.Visible = false;
            }
            else
            {
                try
                {
                    pnl_displayOptions.Controls.AddRange(donationOption.getOptions().ToArray());
                    pnl_customDonation.Visible = donationOption.customEnabled;
                }
                catch (Exception ex)
                {
                    if (ex is NullReferenceException)
                    {
                        pnl_displayOptions.Controls.Add(lbl_noOptions);
                        lbl_noOptions.Visible = true;
                    }
                    else
                    {
                        throw;
                    }
                }

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackPress();
        }
    }
}
