using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    class DonationTextBox : TextBox
    {
        
        public DonationTextBox(int i) : base()
        {
            base.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.ForeColor = System.Drawing.SystemColors.WindowFrame;
            base.Location = new System.Drawing.Point(260, 16);
            base.Margin = new System.Windows.Forms.Padding(15);
            base.Name = "txt_value" + i.ToString();
            base.Size = new System.Drawing.Size(114, 33);
            base.TabIndex = 1;
            base.Text = "Value";
            base.Click += new System.EventHandler(this.donationTextBox_Click);
        }
        private void donationTextBox_Click(object sender, EventArgs e)
        {
            if (this.Text == "Value")
            {
                this.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
    }
}
