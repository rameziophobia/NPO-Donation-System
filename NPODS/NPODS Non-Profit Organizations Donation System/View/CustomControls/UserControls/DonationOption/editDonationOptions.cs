using System;
using System.Windows.Forms;


namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class editDonationOptions : UserControl
    {
        public editDonationOptions()
        {
            InitializeComponent();
        }
        private void txt_value_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Value" || textBox.Text == "Description")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void btn_addOption_MouseClick(object sender, MouseEventArgs e)
        {
            DonationFlowPanel grpBox = new DonationFlowPanel(donationGroupBoxes.Count + 1);
            this.donationGroupBoxes.Add(grpBox);
            pnl_options.Controls.Add(grpBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label delete = (Label)sender;
            Console.WriteLine(sender.GetType());
            GroupBox groupBox = (GroupBox)delete.Parent;
            pnl_options.Controls.Remove(groupBox);
        }

        private void txt_description_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Value" || textBox.Text == "Description")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void btn_addOption_Click(object sender, EventArgs e)
        {

        }
    }
}
