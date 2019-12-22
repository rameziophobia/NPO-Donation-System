using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class OrganizationDashboard : Form
    {
        private int panel2MaxWidth;
        private int panel2MinWidth;
        private bool isExpanded;
        private Dictionary<Button, String> hiddenText;
        public OrganizationDashboard()
        {
            InitializeComponent();
            panel2MaxWidth = 190;
            panel2MinWidth = 70;
            isExpanded = true;
            timer1.Start();
            hiddenText = new Dictionary<Button, string>();
            foreach (Button s in this.panel2.Controls.OfType<Button>())
            {
                hiddenText.Add(s, s.Text);
            }
            panel2.Width = panel2MinWidth;
            vScrollBar1.Scroll += (sender, e) => { MainFlowPanel.VerticalScroll.Value = vScrollBar1.Value; };
        }

        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            isExpanded = false;
            timer1.Start();
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            isExpanded = true;
            timer1.Start();
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                foreach (Button s in hiddenText.Keys)
                {
                    s.Text = "";
                    s.ImageAlign = ContentAlignment.MiddleRight;
                }
                if (panel2.Width > panel2MinWidth)
                    panel2.Width -= 10;
                if (panel2.Width < panel2MinWidth)
                {
                    timer1.Stop();
                    this.Refresh();
                    isExpanded = false;
                }
            }
            else
            {
                if (panel2.Width < panel2MaxWidth)
                    panel2.Width += 10;
                if (panel2.Width > panel2MaxWidth)
                {
                    timer1.Stop();
                    this.Refresh();
                    isExpanded = true;
                }
                foreach (Button s in hiddenText.Keys)
                {
                    s.Text = hiddenText[s];
                    s.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            vScrollBar1.Value = 0;
            MainFlowPanel.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
