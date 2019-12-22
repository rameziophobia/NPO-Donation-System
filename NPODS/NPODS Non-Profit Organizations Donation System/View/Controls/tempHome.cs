using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.Controls
{
    public partial class tempHome : UserControl
    {
        public delegate void OnButtonClick();

        public OnButtonClick OnTempClick { get; set; }

        public tempHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnTempClick();
        }
    }
}
