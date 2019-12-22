using System;
using System.Drawing;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption
{
    public class DonationButton : UserControl
    {
        private FlowLayoutPanel pnl_optionPnl = new FlowLayoutPanel();
        public Label Lbl_tierName { get; set; }
        public Label Lbl_donationValue { get; set; }
        public Label Lbl_monthly { get; set; }
        public Label Lbl_description { get; set; }
        private Boolean enterFlag;
        private readonly Color baseColor = Color.FromArgb(126, 214, 223);
        private readonly Color mouseEnterColor = Color.FromArgb(179, 194, 214);
        private readonly Color mouseDownColor = Color.FromArgb(204, 212, 222);

        public DonationButton() : base()
        {
            Lbl_tierName = new Label();
            Lbl_donationValue = new Label();
            Lbl_monthly = new Label();
            Lbl_description = new Label();
            initialize_panel();
            initialize_labels();

            base.BackColor = Color.Red;
            base.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            base.Location = new Point(428, 15);
            base.Margin = new Padding(30, 15, 3, 3);
            base.Name = "panel";
            base.Size = new Size(168, 144);
            base.TabIndex = 6;
            this.Controls.Add(pnl_optionPnl);
            this.MouseClick += new MouseEventHandler(this.pnl_displayOptions_MouseClick);
            this.MouseDown += new MouseEventHandler(this.pnl_displayOptions_MouseDown);
            this.MouseUp += new MouseEventHandler(this.pnl_displayOptions_MouseEnter);
            this.MouseEnter += new EventHandler(this.pnl_displayOptions_MouseEnter);
            this.MouseLeave += new EventHandler(this.pnl_displayOptions_MouseLeave);
            foreach (Control childs in Controls)
            {
                foreach (Control child in childs.Controls)
                {
                    setEvents(child);
                }
                setEvents(childs);
            }
        }

        private void setEvents(Control child)
        {
            child.MouseEnter += (s, e) => this.pnl_displayOptions_MouseEnter(s, e);
            child.MouseLeave += (s, e) => this.OnMouseLeave(e);
            child.MouseUp += (s, e) => this.pnl_displayOptions_MouseEnter(s, e);
            child.MouseClick += (s, e) => this.pnl_displayOptions_MouseClick(s, e);
            child.MouseDown += (s, e) => this.pnl_displayOptions_MouseDown(s, e);
        }

        private void initialize_panel()
        {
            this.pnl_optionPnl.BackColor = this.baseColor;
            this.pnl_optionPnl.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.pnl_optionPnl.Location = new Point(428, 15);
            this.pnl_optionPnl.Margin = new Padding(30, 15, 3, 3);
            this.pnl_optionPnl.Name = "panel";
            this.pnl_optionPnl.Size = new Size(166, 142);
            this.pnl_optionPnl.TabIndex = 6;
            this.pnl_optionPnl.Dock = DockStyle.Fill;
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
            Lbl_tierName.Dock = DockStyle.Top;
            Lbl_tierName.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Lbl_tierName.Location = new Point(0, 0);
            Lbl_tierName.Name = "Lbl_tierName";
            Lbl_tierName.Size = new Size(166, 25);
            Lbl_tierName.TabIndex = 3;
            Lbl_tierName.Text = "Saied";
            Lbl_tierName.TextAlign = ContentAlignment.MiddleCenter;
            this.pnl_optionPnl.Controls.Add(Lbl_tierName);
        }
        private void initialize_donationValue()
        {
            Lbl_donationValue.Dock = DockStyle.Top;
            Lbl_donationValue.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Lbl_donationValue.Location = new Point(0, 25);
            Lbl_donationValue.Name = "lvl_donationValue";
            Lbl_donationValue.Size = new Size(166, 30);
            Lbl_donationValue.TabIndex = 2;
            Lbl_donationValue.Text = "12$";
            Lbl_donationValue.TextAlign = ContentAlignment.MiddleCenter;
            this.pnl_optionPnl.Controls.Add(Lbl_donationValue);
        }
        private void initialize_monthly()
        {
            Lbl_monthly.Dock = DockStyle.Top;
            Lbl_monthly.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Lbl_monthly.Location = new Point(0, 55);
            Lbl_monthly.Name = "Lbl_monthly";
            Lbl_monthly.Size = new Size(166, 17);
            Lbl_monthly.TabIndex = 1;
            Lbl_monthly.Text = "PER MONTH";
            Lbl_monthly.TextAlign = ContentAlignment.MiddleCenter;
            this.pnl_optionPnl.Controls.Add(Lbl_monthly);
        }
        private void initialize_description()
        {
            Lbl_description.Dock = DockStyle.Top;
            Lbl_description.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            Lbl_description.Location = new Point(0, 72);
            Lbl_description.Name = "Lbl_description";
            Lbl_description.Size = new Size(166, 70);
            Lbl_description.TabIndex = 0;
            Lbl_description.Text = "Blalalalal";
            this.pnl_optionPnl.Controls.Add(Lbl_description);
        }
        private void pnl_displayOptions_MouseEnter(object sender, EventArgs e)
        {
            enterFlag = true;
            this.pnl_optionPnl.BackColor = this.mouseEnterColor;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return; //suppress mouse leave event handling

            if (enterFlag)
            {
                enterFlag = false;
                pnl_displayOptions_MouseLeave();
            }

            base.OnMouseLeave(e);
        }
        private void pnl_displayOptions_MouseLeave(object sender, EventArgs e)
        {
            pnl_displayOptions_MouseLeave();
        }
        private void pnl_displayOptions_MouseLeave()
        {
            this.pnl_optionPnl.BackColor = this.baseColor;
        }

        private void pnl_displayOptions_MouseDown(object sender, MouseEventArgs e)
        {
            this.pnl_optionPnl.BackColor = this.mouseDownColor;
        }
        private void pnl_displayOptions_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
