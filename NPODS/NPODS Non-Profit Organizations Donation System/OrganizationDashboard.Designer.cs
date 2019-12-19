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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sideExpand = new System.Windows.Forms.Button();
            this.cpb_logo = new NPODS_Non_Profit_Organizations_Donation_System.CircularPictureBox();
            this.pnl_side = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_sideMoneyDonations = new System.Windows.Forms.Button();
            this.btn_sideMiscDonations = new System.Windows.Forms.Button();
            this.btn_sideStatistics = new System.Windows.Forms.Button();
            this.btn_sideInformation = new System.Windows.Forms.Button();
            this.tmr_panelAnimation = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pic_Banner = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpb_logo)).BeginInit();
            this.pnl_side.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sideExpand);
            this.panel1.Controls.Add(this.cpb_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 60);
            this.panel1.TabIndex = 0;
            // 
            // btn_sideExpand
            // 
            this.btn_sideExpand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sideExpand.BackgroundImage")));
            this.btn_sideExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sideExpand.FlatAppearance.BorderSize = 0;
            this.btn_sideExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideExpand.Location = new System.Drawing.Point(10, 10);
            this.btn_sideExpand.Name = "btn_sideExpand";
            this.btn_sideExpand.Size = new System.Drawing.Size(40, 40);
            this.btn_sideExpand.TabIndex = 2;
            this.btn_sideExpand.UseVisualStyleBackColor = true;
            this.btn_sideExpand.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cpb_logo
            // 
            this.cpb_logo.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.Logo;
            this.cpb_logo.Location = new System.Drawing.Point(68, 0);
            this.cpb_logo.Name = "cpb_logo";
            this.cpb_logo.Size = new System.Drawing.Size(63, 60);
            this.cpb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpb_logo.TabIndex = 2;
            this.cpb_logo.TabStop = false;
            // 
            // pnl_side
            // 
            this.pnl_side.Controls.Add(this.panel4);
            this.pnl_side.Controls.Add(this.btn_sideMoneyDonations);
            this.pnl_side.Controls.Add(this.btn_sideMiscDonations);
            this.pnl_side.Controls.Add(this.btn_sideStatistics);
            this.pnl_side.Controls.Add(this.btn_sideInformation);
            this.pnl_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_side.Location = new System.Drawing.Point(0, 60);
            this.pnl_side.Name = "pnl_side";
            this.pnl_side.Size = new System.Drawing.Size(190, 560);
            this.pnl_side.TabIndex = 1;
            this.pnl_side.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.pnl_side.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.pnl_side.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(190, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 124);
            this.panel4.TabIndex = 0;
            // 
            // btn_sideMoneyDonations
            // 
            this.btn_sideMoneyDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sideMoneyDonations.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_sideMoneyDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideMoneyDonations.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.money_donation_resized;
            this.btn_sideMoneyDonations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideMoneyDonations.Location = new System.Drawing.Point(-7, 265);
            this.btn_sideMoneyDonations.Name = "btn_sideMoneyDonations";
            this.btn_sideMoneyDonations.Size = new System.Drawing.Size(197, 84);
            this.btn_sideMoneyDonations.TabIndex = 3;
            this.btn_sideMoneyDonations.Text = "Money Donations";
            this.btn_sideMoneyDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideMoneyDonations.UseVisualStyleBackColor = true;
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
            this.btn_sideMiscDonations.Location = new System.Drawing.Point(-7, 349);
            this.btn_sideMiscDonations.Name = "btn_sideMiscDonations";
            this.btn_sideMiscDonations.Size = new System.Drawing.Size(197, 84);
            this.btn_sideMiscDonations.TabIndex = 2;
            this.btn_sideMiscDonations.Text = "Miscellaneous Donations";
            this.btn_sideMiscDonations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sideMiscDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideMiscDonations.UseVisualStyleBackColor = true;
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
            this.btn_sideStatistics.Location = new System.Drawing.Point(-7, 181);
            this.btn_sideStatistics.Name = "btn_sideStatistics";
            this.btn_sideStatistics.Size = new System.Drawing.Size(197, 84);
            this.btn_sideStatistics.TabIndex = 1;
            this.btn_sideStatistics.Text = "Statistics";
            this.btn_sideStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideStatistics.UseVisualStyleBackColor = true;
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
            this.btn_sideInformation.Location = new System.Drawing.Point(-7, 97);
            this.btn_sideInformation.Name = "btn_sideInformation";
            this.btn_sideInformation.Size = new System.Drawing.Size(197, 84);
            this.btn_sideInformation.TabIndex = 0;
            this.btn_sideInformation.Text = "Information";
            this.btn_sideInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sideInformation.UseVisualStyleBackColor = true;
            this.btn_sideInformation.Click += new System.EventHandler(this.Button2_Click);
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
            this.MainPanel.Controls.Add(this.pic_Banner);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(190, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(825, 560);
            this.MainPanel.TabIndex = 3;
            // 
            // pic_Banner
            // 
            this.pic_Banner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Banner.Image = global::NPODS_Non_Profit_Organizations_Donation_System.Properties.Resources.Banner;
            this.pic_Banner.Location = new System.Drawing.Point(-97, 0);
            this.pic_Banner.Name = "pic_Banner";
            this.pic_Banner.Size = new System.Drawing.Size(922, 124);
            this.pic_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Banner.TabIndex = 0;
            this.pic_Banner.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_Main);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 560);
            this.panel3.TabIndex = 1;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 124);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(825, 436);
            this.pnl_Main.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(825, 124);
            this.panel5.TabIndex = 0;
            // 
            // OrganizationDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pnl_side);
            this.Controls.Add(this.panel1);
            this.Name = "OrganizationDashboard";
            this.Size = new System.Drawing.Size(1015, 620);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpb_logo)).EndInit();
            this.pnl_side.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sideExpand;
        private System.Windows.Forms.Panel pnl_side;
        private CircularPictureBox cpb_logo;
        private System.Windows.Forms.Button btn_sideMoneyDonations;
        private System.Windows.Forms.Button btn_sideMiscDonations;
        private System.Windows.Forms.Button btn_sideStatistics;
        private System.Windows.Forms.Button btn_sideInformation;
        private System.Windows.Forms.Timer tmr_panelAnimation;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pic_Banner;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel panel5;
    }
}