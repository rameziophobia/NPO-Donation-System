using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NPODS_Non_Profit_Organizations_Donation_System {
    public partial class OrganizationDashboard : Form {
        private bool isExpanded;
        private readonly int pnl_side_MAXWIDTH;
        private readonly int pnl_side_MINWIDTH;
        private readonly Dictionary<Button, String> hiddenText;
        private readonly List<DateTime> dates;
        private readonly Color accentMain = ColorTranslator.FromHtml("#7ed6df");
        private readonly Color accentSub = ColorTranslator.FromHtml("#c7ecee");
        private DateTime dt;
        private Organization org;
        private Chart chart;

        public OrganizationDashboard() {
            InitializeComponent();
            panel1.BackColor = accentMain;
            pnl_side.BackColor = accentSub;
            pnl_side_MAXWIDTH = 190;
            pnl_side_MINWIDTH = 70;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);

            isExpanded = true;
            tmr_panelAnimation.Start();
            hiddenText = new Dictionary<Button, string>();
            int index = 1;
            foreach (Button s in this.pnl_side.Controls.OfType<Button>()) {
                hiddenText.Add(s, s.Text);
                index++;
            }
            pnl_side.Width = pnl_side_MINWIDTH;

            dates = new List<DateTime>();

            dt = DateTime.Now;                          //todo set graphing year
            for (int i = 1; i <= 12; i++)
                dates.Add(new DateTime(dt.Year, i, 1));

            setOrganization(new Organization("example@email.com", "NOTAPASS123")); //todo set organization
            this.pic_Banner.Image = org.banner;
            this.pic_Banner.BringToFront();
            updateLabels();
        }
        private void updateLabels() {
            lbl_noSubs_value.Text = org.Stats.NumberOfSubs.ToString();
            lbl_TotalSubs_value.Text = org.Stats.TotalNumberOfSubs.ToString();
            lbl_noUnique_value.Text = org.Stats.NumberOfSubs.ToString();
            dtp_lastModified.Value = org.Stats.lastUpdate;

            foreach(Control c in dbr_Info.Controls) {
                c.BringToFront();
            }
        }
        public void setOrganization(Organization organization) {
            this.org = organization;
            setRegions();
            updateChart();
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        private void Panel2_MouseEnter(object sender, EventArgs e) {
            isExpanded = false;
            tmr_panelAnimation.Start();
        }

        private void Panel2_MouseLeave(object sender, EventArgs e) {
            isExpanded = true;
            tmr_panelAnimation.Start();
        }

        private void Timer1_Tick_1(object sender, EventArgs e) {
            if (isExpanded) {
                foreach (Button s in hiddenText.Keys) {
                    s.Text = "";
                    s.ImageAlign = ContentAlignment.MiddleRight;
                }
                if (pnl_side.Width > pnl_side_MINWIDTH)
                    pnl_side.Width -= 10;
                if (pnl_side.Width < pnl_side_MINWIDTH) {
                    tmr_panelAnimation.Stop();
                    this.Refresh();
                    isExpanded = false;
                }
            } else {
                if (pnl_side.Width < pnl_side_MAXWIDTH)
                    pnl_side.Width += 10;
                if (pnl_side.Width > pnl_side_MAXWIDTH) {
                    tmr_panelAnimation.Stop();
                    this.Invalidate();
                    isExpanded = true;
                }
                foreach (Button s in hiddenText.Keys) {
                    s.Text = hiddenText[s];
                    s.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
            this.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e) {
            isExpanded = !isExpanded;
            tmr_panelAnimation.Start();
        }

        private void Btn_Info_Click(object sender, EventArgs e) {
            this.fpl_Main.ScrollControlIntoView(dbr_Info);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void Btn_sideStatistics_Click(object sender, EventArgs e) {
            this.fpl_Main.ScrollControlIntoView(dbr_Stats);
        }

        private void Btn_sideMoneyDonations_Click(object sender, EventArgs e) {
            this.fpl_Main.ScrollControlIntoView(dbr_MoneyDonations);

        }

        private void Btn_sideMiscDonations_Click(object sender, EventArgs e) {
            this.fpl_Main.ScrollControlIntoView(dbr_MiscDonations);
        }
        private void setRegions() {
            this.pic_Banner.BringToFront();
            setVisibility("Money", org.Stats.hasMoneyDonations);
            setVisibility("Misc", org.Stats.hasMiscDonations);
            this.Invalidate();
        }
        private void setVisibility(string name, bool isEnabled) {
            switch (name){
                case "Money":
                    dbr_MoneyDonations.Visible = isEnabled;
                    btn_sideMoneyDonations.Visible = isEnabled;
                    break;
                case "Misc":
                    dbr_MiscDonations.Visible = isEnabled;
                    btn_sideMiscDonations.Visible = isEnabled;
                    break;
            }
        }
        private void updateChart() {
            chart = this.cht_Main;
            Axis XA = chart.ChartAreas[0].AxisX;
            Axis YA = chart.ChartAreas[0].AxisY;
            Series S = chart.Series[0];

            foreach (DateTime d in dates)
                S.Points.AddXY(d,org.Stats.getMonthlySubs()[d.Month - 1]);

            S.LegendText = "Year " + dt.Year;

            S.XValueType = ChartValueType.Date;
            XA.MajorGrid.Enabled = false;
            XA.LabelStyle.Format = "MMM";

            XA.IntervalType = DateTimeIntervalType.Months;
            XA.Interval = 1;

            chart.Update();
            chart.BringToFront();
            pic_Banner.BringToFront();
            chart.Show();
        }

    }
}



