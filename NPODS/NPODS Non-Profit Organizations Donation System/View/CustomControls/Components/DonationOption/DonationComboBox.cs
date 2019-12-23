using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    class DonationComboBox : ComboBox
    {

        public DonationComboBox(int i) : base()
        {
            base.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            base.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.FormattingEnabled = true;
            base.Items.AddRange(new object[] {
            "Subscription",
            "Single Payment",
            "Miscellaneous"});
            base.Location = new System.Drawing.Point(33, 9);
            base.Margin = new System.Windows.Forms.Padding(5);
            base.Name = "cbo_donationOption0";
            base.Size = new System.Drawing.Size(210, 32);
            base.TabIndex = 0;
        }
    }
}
