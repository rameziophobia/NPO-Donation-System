namespace NPODS_Non_Profit_Organizations_Donation_System {
    partial class OrganizationDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel fpl_hidden;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpb_logo = new NPODS_Non_Profit_Organizations_Donation_System.CircularPictureBox();
            this.btn_sideExpand = new System.Windows.Forms.Button();
            this.pnl_side = new System.Windows.Forms.Panel();
            this.btn_sideMoneyDonations = new System.Windows.Forms.Button();
            this.btn_sideMiscDonations = new System.Windows.Forms.Button();
            this.btn_sideStatistics = new System.Windows.Forms.Button();
            this.btn_sideInformation = new System.Windows.Forms.Button();
            this.tmr_panelAnimation = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.fpl_Main = new System.Windows.Forms.Panel();
            this.dbr_MiscDonations = new NPODS_Non_Profit_Organizations_Donation_System.DashboardRegion();
            this.dbr_MoneyDonations = new NPODS_Non_Profit_Organizations_Donation_System.DashboardRegion();
            this.dbr_Stats = new NPODS_Non_Profit_Organizations_Donation_System.DashboardRegion();
            this.cht_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dbr_Info = new NPODS_Non_Profit_Organizations_Donation_System.DashboardRegion();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_Banner = new System.Windows.Forms.PictureBox();
            this.lbl_noSubs = new System.Windows.Forms.Label();
            this.lbl_TotalSubs = new System.Windows.Forms.Label();
            this.lbl_noUnique = new System.Windows.Forms.Label();
            this.lbl_LastModified = new System.Windows.Forms.Label();
            this.lbl_noSubs_value = new System.Windows.Forms.Label();
            this.lbl_TotalSubs_value = new System.Windows.Forms.Label();
            this.lbl_noUnique_value = new System.Windows.Forms.Label();
            this.dtp_lastModified = new System.Windows.Forms.DateTimePicker();
            fpl_hidden = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpb_logo)).BeginInit();
            this.pnl_side.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.fpl_Main.SuspendLayout();
            this.dbr_Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Main)).BeginInit();
            this.dbr_Info.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // fpl_hidden
            // 
            fpl_hidden.Anchor = System.Windows.Forms.AnchorStyles.None;
            fpl_hidden.Location = new System.Drawing.Point(0, 0);
            fpl_hidden.MinimumSize = new System.Drawing.Size(100, 100);
            fpl_hidden.Name = "fpl_hidden";
            fpl_hidden.Size = new System.Drawing.Size(200, 200);
            fpl_hidden.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.cpb_logo);
            this.panel1.Controls.Add(this.btn_sideExpand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 60);
            this.panel1.TabIndex = 0;
            // 
            // cpb_logo
            // 
            this.cpb_logo.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.Logo;
            this.cpb_logo.Location = new System.Drawing.Point(65, 4);
            this.cpb_logo.Name = "cpb_logo";
            this.cpb_logo.Size = new System.Drawing.Size(50, 50);
            this.cpb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpb_logo.TabIndex = 4;
            this.cpb_logo.TabStop = false;
            // 
            // btn_sideExpand
            // 
            this.btn_sideExpand.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sideExpand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sideExpand.BackgroundImage")));
            this.btn_sideExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sideExpand.FlatAppearance.BorderSize = 0;
            this.btn_sideExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideExpand.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sideExpand.Location = new System.Drawing.Point(10, 10);
            this.btn_sideExpand.Name = "btn_sideExpand";
            this.btn_sideExpand.Size = new System.Drawing.Size(40, 40);
            this.btn_sideExpand.TabIndex = 2;
            this.btn_sideExpand.UseVisualStyleBackColor = false;
            this.btn_sideExpand.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnl_side
            // 
            this.pnl_side.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_side.Controls.Add(this.btn_sideMoneyDonations);
            this.pnl_side.Controls.Add(this.btn_sideMiscDonations);
            this.pnl_side.Controls.Add(this.btn_sideStatistics);
            this.pnl_side.Controls.Add(this.btn_sideInformation);
            this.pnl_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_side.Location = new System.Drawing.Point(0, 60);
            this.pnl_side.Name = "pnl_side";
            this.pnl_side.Size = new System.Drawing.Size(193, 752);
            this.pnl_side.TabIndex = 1;
            this.pnl_side.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.pnl_side.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.pnl_side.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // btn_sideMoneyDonations
            // 
            this.btn_sideMoneyDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideMoneyDonations.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sideMoneyDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideMoneyDonations.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.money_donation_resized;
            this.btn_sideMoneyDonations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideMoneyDonations.Location = new System.Drawing.Point(-4, 292);
            this.btn_sideMoneyDonations.Name = "btn_sideMoneyDonations";
            this.btn_sideMoneyDonations.Size = new System.Drawing.Size(197, 84);
            this.btn_sideMoneyDonations.TabIndex = 3;
            this.btn_sideMoneyDonations.Text = "Money Donations";
            this.btn_sideMoneyDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideMoneyDonations.UseVisualStyleBackColor = true;
            this.btn_sideMoneyDonations.Click += new System.EventHandler(this.Btn_sideMoneyDonations_Click);
            this.btn_sideMoneyDonations.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.btn_sideMoneyDonations.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // btn_sideMiscDonations
            // 
            this.btn_sideMiscDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideMiscDonations.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sideMiscDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideMiscDonations.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.misc_donation_resized_transparent;
            this.btn_sideMiscDonations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideMiscDonations.Location = new System.Drawing.Point(-4, 376);
            this.btn_sideMiscDonations.Name = "btn_sideMiscDonations";
            this.btn_sideMiscDonations.Size = new System.Drawing.Size(197, 84);
            this.btn_sideMiscDonations.TabIndex = 2;
            this.btn_sideMiscDonations.Text = "Miscellaneous Donations";
            this.btn_sideMiscDonations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideMiscDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideMiscDonations.UseVisualStyleBackColor = true;
            this.btn_sideMiscDonations.Click += new System.EventHandler(this.Btn_sideMiscDonations_Click);
            this.btn_sideMiscDonations.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.btn_sideMiscDonations.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // btn_sideStatistics
            // 
            this.btn_sideStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideStatistics.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sideStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideStatistics.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.Stats_resized;
            this.btn_sideStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideStatistics.Location = new System.Drawing.Point(-4, 208);
            this.btn_sideStatistics.Name = "btn_sideStatistics";
            this.btn_sideStatistics.Size = new System.Drawing.Size(197, 84);
            this.btn_sideStatistics.TabIndex = 1;
            this.btn_sideStatistics.Text = "Statistics";
            this.btn_sideStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideStatistics.UseVisualStyleBackColor = true;
            this.btn_sideStatistics.Click += new System.EventHandler(this.Btn_sideStatistics_Click);
            this.btn_sideStatistics.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.btn_sideStatistics.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // btn_sideInformation
            // 
            this.btn_sideInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sideInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideInformation.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.data_resized;
            this.btn_sideInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideInformation.Location = new System.Drawing.Point(-4, 124);
            this.btn_sideInformation.Name = "btn_sideInformation";
            this.btn_sideInformation.Size = new System.Drawing.Size(197, 84);
            this.btn_sideInformation.TabIndex = 0;
            this.btn_sideInformation.Text = "Information";
            this.btn_sideInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideInformation.UseVisualStyleBackColor = true;
            this.btn_sideInformation.Click += new System.EventHandler(this.Btn_Info_Click);
            this.btn_sideInformation.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.btn_sideInformation.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // tmr_panelAnimation
            // 
            this.tmr_panelAnimation.Interval = 5;
            this.tmr_panelAnimation.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.fpl_Main);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1382, 752);
            this.MainPanel.TabIndex = 3;
            // 
            // fpl_Main
            // 
            this.fpl_Main.AutoScroll = true;
            this.fpl_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpl_Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fpl_Main.Controls.Add(this.dbr_MiscDonations);
            this.fpl_Main.Controls.Add(this.dbr_MoneyDonations);
            this.fpl_Main.Controls.Add(this.dbr_Stats);
            this.fpl_Main.Controls.Add(this.dbr_Info);
            this.fpl_Main.Dock = System.Windows.Forms.DockStyle.Right;
            this.fpl_Main.Location = new System.Drawing.Point(190, 124);
            this.fpl_Main.Name = "fpl_Main";
            this.fpl_Main.Size = new System.Drawing.Size(1192, 628);
            this.fpl_Main.TabIndex = 2;
            // 
            // dbr_MiscDonations
            // 
            this.dbr_MiscDonations.BackColor = System.Drawing.SystemColors.Control;
            this.dbr_MiscDonations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbr_MiscDonations.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbr_MiscDonations.Location = new System.Drawing.Point(0, 1964);
            this.dbr_MiscDonations.Name = "dbr_MiscDonations";
            this.dbr_MiscDonations.Size = new System.Drawing.Size(1175, 640);
            this.dbr_MiscDonations.TabIndex = 3;
            // 
            // dbr_MoneyDonations
            // 
            this.dbr_MoneyDonations.BackColor = System.Drawing.SystemColors.Control;
            this.dbr_MoneyDonations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbr_MoneyDonations.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbr_MoneyDonations.Location = new System.Drawing.Point(0, 1364);
            this.dbr_MoneyDonations.Name = "dbr_MoneyDonations";
            this.dbr_MoneyDonations.Size = new System.Drawing.Size(1175, 600);
            this.dbr_MoneyDonations.TabIndex = 2;
            // 
            // dbr_Stats
            // 
            this.dbr_Stats.BackColor = System.Drawing.SystemColors.Control;
            this.dbr_Stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbr_Stats.Controls.Add(this.cht_Main);
            this.dbr_Stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbr_Stats.Location = new System.Drawing.Point(0, 763);
            this.dbr_Stats.Name = "dbr_Stats";
            this.dbr_Stats.Size = new System.Drawing.Size(1175, 601);
            this.dbr_Stats.TabIndex = 1;
            // 
            // cht_Main
            // 
            chartArea3.Name = "ChartArea1";
            this.cht_Main.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cht_Main.Legends.Add(legend3);
            this.cht_Main.Location = new System.Drawing.Point(232, 67);
            this.cht_Main.Name = "cht_Main";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cht_Main.Series.Add(series3);
            this.cht_Main.Size = new System.Drawing.Size(690, 484);
            this.cht_Main.TabIndex = 1;
            this.cht_Main.Text = "chart1";
            // 
            // dbr_Info
            // 
            this.dbr_Info.BackColor = System.Drawing.SystemColors.Control;
            this.dbr_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbr_Info.Controls.Add(this.dtp_lastModified);
            this.dbr_Info.Controls.Add(this.lbl_LastModified);
            this.dbr_Info.Controls.Add(this.lbl_noUnique_value);
            this.dbr_Info.Controls.Add(this.lbl_TotalSubs_value);
            this.dbr_Info.Controls.Add(this.lbl_noSubs_value);
            this.dbr_Info.Controls.Add(this.lbl_noUnique);
            this.dbr_Info.Controls.Add(this.lbl_TotalSubs);
            this.dbr_Info.Controls.Add(this.lbl_noSubs);
            this.dbr_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbr_Info.Location = new System.Drawing.Point(0, 0);
            this.dbr_Info.Name = "dbr_Info";
            this.dbr_Info.Size = new System.Drawing.Size(1175, 763);
            this.dbr_Info.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_Banner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 124);
            this.panel2.TabIndex = 1;
            // 
            // pic_Banner
            // 
            this.pic_Banner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Banner.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.Banner;
            this.pic_Banner.Location = new System.Drawing.Point(0, 0);
            this.pic_Banner.Name = "pic_Banner";
            this.pic_Banner.Size = new System.Drawing.Size(1382, 124);
            this.pic_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Banner.TabIndex = 0;
            this.pic_Banner.TabStop = false;
            // 
            // lbl_noSubs
            // 
            this.lbl_noSubs.AutoSize = true;
            this.lbl_noSubs.Location = new System.Drawing.Point(38, 71);
            this.lbl_noSubs.Name = "lbl_noSubs";
            this.lbl_noSubs.Size = new System.Drawing.Size(136, 13);
            this.lbl_noSubs.TabIndex = 1;
            this.lbl_noSubs.Text = "No. of current subscriptions";
            // 
            // lbl_TotalSubs
            // 
            this.lbl_TotalSubs.AutoSize = true;
            this.lbl_TotalSubs.Location = new System.Drawing.Point(38, 155);
            this.lbl_TotalSubs.Name = "lbl_TotalSubs";
            this.lbl_TotalSubs.Size = new System.Drawing.Size(123, 13);
            this.lbl_TotalSubs.TabIndex = 2;
            this.lbl_TotalSubs.Text = "No. of total subscriptions";
            // 
            // lbl_noUnique
            // 
            this.lbl_noUnique.AutoSize = true;
            this.lbl_noUnique.Location = new System.Drawing.Point(38, 239);
            this.lbl_noUnique.Name = "lbl_noUnique";
            this.lbl_noUnique.Size = new System.Drawing.Size(119, 13);
            this.lbl_noUnique.TabIndex = 3;
            this.lbl_noUnique.Text = "No. of Unique Donators";
            // 
            // lbl_LastModified
            // 
            this.lbl_LastModified.AutoSize = true;
            this.lbl_LastModified.Location = new System.Drawing.Point(879, 456);
            this.lbl_LastModified.Name = "lbl_LastModified";
            this.lbl_LastModified.Size = new System.Drawing.Size(70, 13);
            this.lbl_LastModified.TabIndex = 4;
            this.lbl_LastModified.Text = "Last Modified";
            // 
            // lbl_noSubs_value
            // 
            this.lbl_noSubs_value.AutoSize = true;
            this.lbl_noSubs_value.Location = new System.Drawing.Point(203, 71);
            this.lbl_noSubs_value.Name = "lbl_noSubs_value";
            this.lbl_noSubs_value.Size = new System.Drawing.Size(13, 13);
            this.lbl_noSubs_value.TabIndex = 5;
            this.lbl_noSubs_value.Text = "0";
            // 
            // lbl_TotalSubs_value
            // 
            this.lbl_TotalSubs_value.AutoSize = true;
            this.lbl_TotalSubs_value.Location = new System.Drawing.Point(203, 155);
            this.lbl_TotalSubs_value.Name = "lbl_TotalSubs_value";
            this.lbl_TotalSubs_value.Size = new System.Drawing.Size(13, 13);
            this.lbl_TotalSubs_value.TabIndex = 6;
            this.lbl_TotalSubs_value.Text = "0";
            // 
            // lbl_noUnique_value
            // 
            this.lbl_noUnique_value.AutoSize = true;
            this.lbl_noUnique_value.Location = new System.Drawing.Point(203, 239);
            this.lbl_noUnique_value.Name = "lbl_noUnique_value";
            this.lbl_noUnique_value.Size = new System.Drawing.Size(13, 13);
            this.lbl_noUnique_value.TabIndex = 7;
            this.lbl_noUnique_value.Text = "0";
            // 
            // dtp_lastModified
            // 
            this.dtp_lastModified.Enabled = false;
            this.dtp_lastModified.Location = new System.Drawing.Point(972, 450);
            this.dtp_lastModified.Name = "dtp_lastModified";
            this.dtp_lastModified.Size = new System.Drawing.Size(200, 20);
            this.dtp_lastModified.TabIndex = 9;
            // 
            // OrganizationDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 812);
            this.Controls.Add(this.pnl_side);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "OrganizationDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpb_logo)).EndInit();
            this.pnl_side.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.fpl_Main.ResumeLayout(false);
            this.dbr_Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Main)).EndInit();
            this.dbr_Info.ResumeLayout(false);
            this.dbr_Info.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sideExpand;
        private System.Windows.Forms.Panel pnl_side;
        private System.Windows.Forms.Button btn_sideMoneyDonations;
        private System.Windows.Forms.Button btn_sideMiscDonations;
        private System.Windows.Forms.Button btn_sideStatistics;
        private System.Windows.Forms.Button btn_sideInformation;
        private System.Windows.Forms.Timer tmr_panelAnimation;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pic_Banner;
        private System.Windows.Forms.Panel fpl_Main;
        private System.Windows.Forms.Panel panel2;
        private DashboardRegion dbr_MiscDonations;
        private DashboardRegion dbr_MoneyDonations;
        private DashboardRegion dbr_Stats;
        private DashboardRegion dbr_Info;
        private CircularPictureBox cpb_logo;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Main;
        private System.Windows.Forms.Label lbl_noUnique;
        private System.Windows.Forms.Label lbl_TotalSubs;
        private System.Windows.Forms.Label lbl_noSubs;
        private System.Windows.Forms.Label lbl_noUnique_value;
        private System.Windows.Forms.Label lbl_TotalSubs_value;
        private System.Windows.Forms.Label lbl_noSubs_value;
        private System.Windows.Forms.Label lbl_LastModified;
        private System.Windows.Forms.DateTimePicker dtp_lastModified;
    }
}