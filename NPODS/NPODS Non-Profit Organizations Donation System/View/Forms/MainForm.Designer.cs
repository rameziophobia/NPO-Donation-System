namespace NPODS_Non_Profit_Organizations_Donation_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.RegisterControl();
            this.headerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.HeaderControl();
            this.tempHome1 = new NPODS_Non_Profit_Organizations_Donation_System.View.Controls.tempHome();
            this.chooseDonationOption1 = new NPODS_Non_Profit_Organizations_Donation_System.chooseDonationOption();
            this.organizationInfo1 = new NPODS_Non_Profit_Organizations_Donation_System.organizationInfo();
            this.org_card2 = new NPODS_Non_Profit_Organizations_Donation_System.org_card();
            this.SuspendLayout();
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.Location = new System.Drawing.Point(367, 218);
            this.registerControl1.Margin = new System.Windows.Forms.Padding(1);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(731, 468);
            this.registerControl1.TabIndex = 3;
            this.registerControl1.Visible = false;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.headerControl1.Location = new System.Drawing.Point(0, 2);
            this.headerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.OnAboutUsClick = null;
            this.headerControl1.OnHomeClick = null;
            this.headerControl1.OnLoginClick = null;
            this.headerControl1.OnRegisterClick = null;
            this.headerControl1.Size = new System.Drawing.Size(1515, 85);
            this.headerControl1.TabIndex = 8;
            // 
            // tempHome1
            // 
            this.tempHome1.Location = new System.Drawing.Point(427, 279);
            this.tempHome1.Margin = new System.Windows.Forms.Padding(5);
            this.tempHome1.Name = "tempHome1";
            this.tempHome1.OnTempClick = null;
            this.tempHome1.Size = new System.Drawing.Size(608, 325);
            this.tempHome1.TabIndex = 6;
            // 
            // chooseDonationOption1
            // 
            this.chooseDonationOption1.Location = new System.Drawing.Point(211, 244);
            this.chooseDonationOption1.Margin = new System.Windows.Forms.Padding(5);
            this.chooseDonationOption1.Name = "chooseDonationOption1";
            this.chooseDonationOption1.OnBackPress = null;
            this.chooseDonationOption1.Organization = null;
            this.chooseDonationOption1.Size = new System.Drawing.Size(1006, 456);
            this.chooseDonationOption1.TabIndex = 7;
            this.chooseDonationOption1.Visible = false;
            this.chooseDonationOption1.Load += new System.EventHandler(this.ChooseDonationOption1_Load_1);
            // 
            // organizationInfo1
            // 
            this.organizationInfo1.Location = new System.Drawing.Point(0, 80);
            this.organizationInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.organizationInfo1.Name = "organizationInfo1";
            this.organizationInfo1.OnDonatePress = null;
            this.organizationInfo1.Size = new System.Drawing.Size(1515, 719);
            this.organizationInfo1.TabIndex = 4;
            this.organizationInfo1.Visible = false;
            this.organizationInfo1.Load += new System.EventHandler(this.organizationInfo1_Load);
            // 
            // org_card2
            // 
            this.org_card2.AutoScroll = true;
            this.org_card2.Location = new System.Drawing.Point(0, 80);
            this.org_card2.Name = "org_card2";
            this.org_card2.Size = new System.Drawing.Size(1515, 703);
            this.org_card2.TabIndex = 9;
            this.org_card2.Load += new System.EventHandler(this.Org_card2_Load_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 768);
            this.Controls.Add(this.org_card2);
            this.Controls.Add(this.registerControl1);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.tempHome1);
            this.Controls.Add(this.chooseDonationOption1);
            this.Controls.Add(this.organizationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPODS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private LoginControl loginControl1;
        private RegisterControl registerControl1;
        private organizationInfo organizationInfo1;
        private View.Controls.tempHome tempHome1;
        private chooseDonationOption chooseDonationOption1;
        private org_card org_card1;
        private HeaderControl headerControl1;
        private org_card org_card2;
    }
}

