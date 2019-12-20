using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    class DonationGroupBox : GroupBox
    {
        
        public DonationGroupBox(int i) : base()
        {
            base.Controls.Add(new DonationComboBox(i));
            base.Controls.Add(new DonationTextBox(i));
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.ForeColor = System.Drawing.SystemColors.Control;
            base.Location = new System.Drawing.Point(3, 3 + 61*i);
            base.Name = "groupBox1" + i.ToString();
            base.Size = new System.Drawing.Size(389, 55);
            base.TabIndex = i+1;
            base.TabStop = false;
        }
    }
}
