using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption
{
    public class DonationButton : FlowLayoutPanel
    {
        public Label Lbl_tierName { get; set; }
        public Label Lbl_donationValue = new System.Windows.Forms.Label();
        public Label Lbl_monthly = new System.Windows.Forms.Label();
        public Label Lbl_description = new System.Windows.Forms.Label();
        public DonationButton(): base()
        {
            Lbl_tierName = new Label();
            Lbl_donationValue = new Label();
            Lbl_monthly = new Label();
            Lbl_description = new Label();
            initialize_labels();
            base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            base.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.Location = new System.Drawing.Point(428, 15);
            base.Margin = new System.Windows.Forms.Padding(30, 15, 3, 3);
            base.Name = "panel";
            base.Size = new System.Drawing.Size(166, 142);
            base.TabIndex = 6;
            base.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_displayOptions_MouseClick);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_displayOptions_MouseDown);
            base.MouseEnter += new System.EventHandler(this.pnl_displayOptions_MouseEnter);
            base.MouseLeave += new System.EventHandler(this.pnl_displayOptions_MouseLeave);
        }
        private void initialize_labels()
        {
            initialize_tierName();
            initialize_donationValue();
            initialize_monthly();
            initialize_description();
        }
        private void initialize_tierName()
        {
            Lbl_tierName.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_tierName.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_tierName.Location = new System.Drawing.Point(0, 0);
            Lbl_tierName.Name = "Lbl_tierName";
            Lbl_tierName.Size = new System.Drawing.Size(166, 25);
            Lbl_tierName.TabIndex = 3;
            Lbl_tierName.Text = "Saied";
            Lbl_tierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(Lbl_tierName);
        }
        private void initialize_donationValue()
        {
            Lbl_donationValue.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_donationValue.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_donationValue.Location = new System.Drawing.Point(0, 25);
            Lbl_donationValue.Name = "lvl_donationValue";
            Lbl_donationValue.Size = new System.Drawing.Size(166, 30);
            Lbl_donationValue.TabIndex = 2;
            Lbl_donationValue.Text = "12$";
            Lbl_donationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(Lbl_donationValue);
        }
        private void initialize_monthly()
        {
            Lbl_monthly.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_monthly.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_monthly.Location = new System.Drawing.Point(0, 55);
            Lbl_monthly.Name = "Lbl_monthly";
            Lbl_monthly.Size = new System.Drawing.Size(166, 17);
            Lbl_monthly.TabIndex = 1;
            Lbl_monthly.Text = "PER MONTH";
            Lbl_monthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(Lbl_monthly);
        }
        private void initialize_description()
        {
            Lbl_description.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_description.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_description.Location = new System.Drawing.Point(0, 72);
            Lbl_description.Name = "Lbl_description";
            Lbl_description.Size = new System.Drawing.Size(166, 70);
            Lbl_description.TabIndex = 0;
            Lbl_description.Text = "Blalalalal";
            this.Controls.Add(Lbl_description);
        }
        private void pnl_displayOptions_MouseEnter(object sender, EventArgs e)
        {
        }
        private void pnl_displayOptions_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnl_displayOptions_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void pnl_displayOptions_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
