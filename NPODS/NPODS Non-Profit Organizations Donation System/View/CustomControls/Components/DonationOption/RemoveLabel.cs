using System;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View
{
    class RemoveLabel : Label
    {
        //public delegate void StatusUpdateHandler(object sender, ProgressEventArgs e);
        //public event StatusUpdateHandler OnUpdateStatus;
        public RemoveLabel() : base()
        {
            base.AutoSize = true;
            base.BackColor = System.Drawing.Color.DarkRed;
            base.Location = new System.Drawing.Point(8, 17);
            base.Margin = new System.Windows.Forms.Padding(5, 13, 5, 5);
            base.Name = "lbl_removeOption";
            base.Size = new System.Drawing.Size(15, 15);
            base.TabIndex = 4;
            base.Text = "X";
            base.Click += new System.EventHandler(removeLabel_Click);
        }
        private void removeLabel_Click(object sender, EventArgs e)
        {
            Label delete = (Label)sender;
            DonationFlowPanel groupBox = (DonationFlowPanel)delete.Parent;
            FlowLayoutPanel flowPanel = (FlowLayoutPanel)groupBox.Parent;
            flowPanel.Controls.Remove(groupBox);
            

        //editDonationOptions.donationGroupBoxes.Remove(groupBox);
        }
    }
}
