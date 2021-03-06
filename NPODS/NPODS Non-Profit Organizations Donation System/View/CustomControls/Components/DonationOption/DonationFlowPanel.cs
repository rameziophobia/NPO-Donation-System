﻿using NPODS_Non_Profit_Organizations_Donation_System.View;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    class DonationFlowPanel : FlowLayoutPanel
    {
        public RemoveLabel lbl_remove = new RemoveLabel();
        public DonationComboBox cbo_donation { get; private set; }
        public DonationTextBox txt_donationValue { get; private set; }
        public DonationTextBox txt_donationName { get; private set; }
        public DonationTextBox txt_donationDescription { get; private set; }


        public DonationFlowPanel(int i) : base()
        {
            cbo_donation = new DonationComboBox(i);
            txt_donationName = new DonationTextBox(i, "Name", 1);
            txt_donationValue = new DonationTextBox(i, "Value", 1);
            txt_donationDescription = new DonationTextBox(i, "Description", 5);
            txt_donationDescription.Size = new System.Drawing.Size(620, 32);
            base.Controls.Add(lbl_remove);
            base.Controls.Add(cbo_donation);
            base.Controls.Add(txt_donationName);
            base.Controls.Add(txt_donationValue);
            base.Controls.Add(txt_donationDescription);

            base.ForeColor = System.Drawing.SystemColors.Control;
            base.Location = new System.Drawing.Point(18, 19);
            base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            base.Name = "flowLayoutPanel1";
            base.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            base.Size = new System.Drawing.Size(1104, 53);
            base.TabIndex = 2;
            this.cbo_donation.SelectedIndexChanged += new System.EventHandler(this.cbo_donation_SelectedIndexChanged);
        }

        private void cbo_donation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbo_donation.SelectedItem.ToString().Trim() == "Miscellaneous")
            {
                txt_donationValue.Hide();
            }
            else
            {
                txt_donationValue.Show();
            }
        }

    }
}
