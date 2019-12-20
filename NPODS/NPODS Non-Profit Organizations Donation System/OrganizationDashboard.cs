﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System {
    public partial class OrganizationDashboard : Form {
        private bool isExpanded;
        private readonly int pnl_side_MAXWIDTH;
        private readonly int pnl_side_MINWIDTH;
        private readonly Dictionary<Button, String> hiddenText;
        public OrganizationDashboard() {
            InitializeComponent();
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
                if(pnl_side.Width < pnl_side_MAXWIDTH)
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

        private void Fpl_Main_Paint(object sender, PaintEventArgs e) {

        }

        private void Dbr_Stats_Load(object sender, EventArgs e) {

        }
    }
}
