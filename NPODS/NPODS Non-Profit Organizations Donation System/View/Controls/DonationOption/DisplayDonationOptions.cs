using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption
{
    public class DisplayDonationOptions : FlowLayoutPanel
    {
        List<DonationButton> btns_donate = new List<DonationButton>();
        public DisplayDonationOptions(Donation donation): base()
        {
            btns_donate = donation.getOptions();
            this.Controls.AddRange(btns_donate.ToArray());
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DisplayDonationOptions
            // 
            this.Name = "DisplayDonationOptions";
            this.Size = new System.Drawing.Size(1071, 633);
            this.ResumeLayout(false);

        }
    }
}
