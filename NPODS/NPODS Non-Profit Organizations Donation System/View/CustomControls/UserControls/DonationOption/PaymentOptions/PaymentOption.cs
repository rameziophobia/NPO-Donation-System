using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Transactions;
using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption.PaymentOptions
{
    public partial class PaymentOption : UserControl
    {
        public Organization Organization { get; set; }
        public delegate void OnButtonClick();
        public OnButtonClick OnBackPress { get; set; }
        public delegate void onPaymentValidated();
        public onPaymentValidated OnPaymentValidated { get; set; }
        public PaymentOption()
        {
            InitializeComponent();
        }

        private void btn_fawry_Click(object sender, EventArgs e)
        {
            confirmDonation("Fawry");
        }
        private void btn_paypal_Click(object sender, EventArgs e)
        {
            confirmDonation("Paypal");
        }
        private void confirmDonation(string donationMethod)
        {
            DialogResult dr;
            dr = MessageBox.Show("Confirm donating via " + donationMethod + " to '" + Organization.Name + "'.", "Conofirm Donation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Transaction Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            OnPaymentValidated();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackPress();
        }
    }
}
