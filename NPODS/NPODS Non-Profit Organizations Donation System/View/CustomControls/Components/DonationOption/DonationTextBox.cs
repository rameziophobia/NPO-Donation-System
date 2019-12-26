using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    class DonationTextBox : TextBox
    {
        private bool firstClick = true;

        public DonationTextBox() : this(0, "Value", 0)
        {
        }
        public DonationTextBox(int i, string watermark, int tabIndex) : base()
        {
            base.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.ForeColor = System.Drawing.SystemColors.WindowFrame;
            base.Location = new System.Drawing.Point(253, 9);
            base.Margin = new System.Windows.Forms.Padding(5);
            base.Name = "txt_value0";
            base.Size = new System.Drawing.Size(100, 33);
            base.TabIndex = 1;
            base.Text = watermark;
            base.Click += new System.EventHandler(donationTextBox_Click);
        }
        private void donationTextBox_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                this.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                firstClick = false;
            }
        }
    }
}
