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
            if(txt_value.Text == "Value")
            {
                txt_value.Text = "";
                txt_value.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
    }
}
