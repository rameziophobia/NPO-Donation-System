using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Properties;

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
            comfirmDonation("Fawry");
        }
        private void btn_paypal_Click(object sender, EventArgs e)
        {
            comfirmDonation("Paypal");
        }
        private void comfirmDonation(string donationMethod)
        {
            DialogResult dr;
            dr = MessageBox.Show("Confirm donating via " + donationMethod + " to '" + Organization.Name + "'.", "Conofirm Donation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Transaction Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackPress();
        }
    }
}
