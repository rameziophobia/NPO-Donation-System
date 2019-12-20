using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        private void btn_aboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
