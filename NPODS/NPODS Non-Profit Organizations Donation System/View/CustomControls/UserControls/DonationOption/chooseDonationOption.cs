using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption;
using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Transactions;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class chooseDonationOption : UserControl
    {
        public Organization Organization { get; set; }
        public delegate void OnButtonClick();
        public OnButtonClick OnBackPress { get; set; }
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DonationButton.OnButtonClick OnDonatePress { get; set; }
        public DonationButton.OnButtonClick OnMiscPress { get; set; }
        public Donor CurrentAccount { get; internal set; }

        private readonly System.Drawing.Color COLOR_SELECTED = System.Drawing.Color.FromArgb(199, 236, 238);
        private readonly System.Drawing.Color COLOR_NOT_SELECTED = System.Drawing.Color.FromArgb(199, 216, 238);
        private Donation donationOption;
        private bool defaultOptionDone = false;
        private bool perMonth;

        public chooseDonationOption()
        {
            InitializeComponent();
            OnDonatePress += (value, isMonthly) =>
            {
                paymentOption2.Organization = this.Organization;
                paymentOption2.Visible = true;
                pnl_chooseDisplayOption.Visible = false;
                paymentOption2.Dock = DockStyle.Fill;
                paymentOption2.OnPaymentValidated += () =>
                {
                    if (isMonthly)
                    {
                        new Subscription(Organization, CurrentAccount, value);
                    }
                    else
                    {
                        new SingleTransaction(Organization, CurrentAccount, value);
                    }
                };
            };
            //OnMiscPress += () =>
            //{
            //};
            paymentOption2.OnBackPress += () =>
            {
                paymentOption2.Visible = false;
                pnl_chooseDisplayOption.Visible = true;
                paymentOption2.Dock = DockStyle.None;
            };
        }

        private void btn_singlePayment_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(getOptions(Organization.SingleDonation.DonationTiers, false).ToArray());
            pnl_customDonation.Visible = Organization.SingleDonation.customEnabled;
        }

        private void btn_subscription_Click(object sender, EventArgs e)
        {
            selectColor((Button)sender);
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(getOptions(Organization.SubscriptionDonation.DonationTiers, true).ToArray());
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
        public List<DonationButton> getOptions(DonationTier[] donationTiers, bool isMonthly)
        {
            List<DonationButton> btns_donation = new List<DonationButton>();
            for (int i = 0; i < donationTiers.Length; i++)
            {
                DonationButton btn = new DonationButton(OnDonatePress, donationTiers[i].Value);
                btn.Lbl_tierName.Text = donationTiers[i].Name;
                btn.Lbl_donationValue.Text = donationTiers[i].Value.ToString() + "$";
                btn.Lbl_monthly.Visible = isMonthly;
                btn.isMonthly = isMonthly;
                btn.Lbl_description.Text = donationTiers[i].Description;
                btns_donation.Add(btn);
            }
            return btns_donation;
        }

        private List<DonationButton> getMiscOptionsButtons(List<MiscDonation> miscDonations)
        {
            List<DonationButton> btns = new List<DonationButton>();
            foreach (MiscDonation miscDonation in miscDonations)
            {
                DonationButton btn = new DonationButton(OnMiscPress);
                btn.Lbl_donationValue.Visible = false;
                btn.Lbl_monthly.Visible = false;
                btn.Lbl_tierName.Visible = false;
                btn.Lbl_description.Visible = false;
                btn.Link_description.Visible = true;
                btn.Link_description.MouseClick += Link_description_MouseClick;
                btn.Link_description.Text = miscDonation.Link;
                btns.Add(btn);
            }
            return btns;
        }

        private void Link_description_MouseClick(object sender, MouseEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            Process.Start("http://" + link.Text);
        }

        public void setAvailableTypes()
        {
            pnl_displayOptions.Controls.Clear();
            if (!(Organization.SingleDonation is NullDonation))
            {
                donationOption = Organization.SingleDonation;
                selectColor(btn_singlePayment);
                perMonth = false;
                btn_singlePayment.Visible = true;
                defaultOptionDone = true;
            }
            if (!(Organization.SubscriptionDonation is NullDonation))
            {
                if (!defaultOptionDone)
                {
                    donationOption = Organization.SubscriptionDonation;
                    selectColor(btn_subscription);
                    perMonth = true;
                }
                btn_subscription.Visible = true;
            }
            displayDonationOptions();
            if (Organization.MiscDonations.Count > 0)
            {
                btn_miscellaneous.Visible = true;
            }

        }
        public void displayDonationOptions()
        {
            try
            {
                pnl_displayOptions.Controls.AddRange(getOptions(donationOption.DonationTiers, perMonth).ToArray());
                pnl_customDonation.Visible = donationOption.customEnabled;
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    if (Organization.MiscDonations.Count > 0)
                    {
                        selectColor(btn_miscellaneous);
                        pnl_displayOptions.Controls.AddRange(getMiscOptionsButtons(Organization.MiscDonations).ToArray());
                        pnl_customDonation.Visible = false;
                    }
                    else
                    {
                        pnl_displayOptions.Controls.Add(lbl_noOptions);
                        lbl_noOptions.Visible = true;
                    }
                }
                else
                {
                    throw;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackPress();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int donationValue = 0;
            try
            {
                donationValue = Convert.ToInt32(txt_customValue.Text);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    donationValue = -1;
                }
            }
            if (donationValue > 0)
            {
                OnDonatePress(donationValue, perMonth); // todo ana 7atet random var xD
            }
            else
            {
                MessageBox.Show("Please, enter a value greater than 0.", "Value equal or less than 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

