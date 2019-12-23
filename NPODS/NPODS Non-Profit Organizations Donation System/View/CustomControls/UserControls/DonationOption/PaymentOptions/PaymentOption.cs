using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption.PaymentOptions
{
    public partial class PaymentOption : UserControl
    {
        public Organization Organization { get; set; }
        public delegate void OnButtonClick();
        public OnButtonClick OnBackPress { get; set; }
        public PaymentOption()
        {
            InitializeComponent();
        }

        private void btn_fawry_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm donating via Fawry to '"
                                              + Organization.Name
                                              + "'.", "Conofirm Donation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Transaction Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_paypal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm donating " + "via PayPal to '" + Organization.Name + "'.", "Conofirm Donation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Transaction Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackPress();
        }
    }
}
