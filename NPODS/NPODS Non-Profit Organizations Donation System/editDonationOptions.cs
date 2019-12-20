using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class editDonationOptions : UserControl
    {
        public editDonationOptions()
        {
            InitializeComponent();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if(txt_value0.Text == "Value")
            {
                txt_value0.Text = "";
                txt_value0.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void btn_addOption_MouseClick(object sender, MouseEventArgs e)
        {
            DonationGroupBox grpBox = new DonationGroupBox(donationGroupBoxes.Count + 1);
            this.donationGroupBoxes.Add(grpBox);
            pnl_options.Controls.Add(grpBox);
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
