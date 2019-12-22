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
            this.tempHome1 = new NPODS_Non_Profit_Organizations_Donation_System.View.Controls.tempHome();
            this.registerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.RegisterControl();
            this.loginControl1 = new NPODS_Non_Profit_Organizations_Donation_System.LoginControl();
            this.headerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.HeaderControl();
            this.organizationInfo1 = new NPODS_Non_Profit_Organizations_Donation_System.organizationInfo();
            this.chooseDonationOption1 = new NPODS_Non_Profit_Organizations_Donation_System.chooseDonationOption();
            this.SuspendLayout();
            // 
            // tempHome1
            // 
            this.tempHome1.Location = new System.Drawing.Point(320, 227);
            this.tempHome1.Name = "tempHome1";
            this.tempHome1.OnTempClick = null;
            this.tempHome1.Size = new System.Drawing.Size(456, 264);
            this.tempHome1.TabIndex = 6;
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.Location = new System.Drawing.Point(275, 177);
            this.registerControl1.Margin = new System.Windows.Forms.Padding(1);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(548, 380);
            this.registerControl1.TabIndex = 3;
            this.registerControl1.Visible = false;
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.Transparent;
            this.loginControl1.Location = new System.Drawing.Point(377, 260);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(367, 231);
            this.loginControl1.TabIndex = 2;
            this.loginControl1.Visible = false;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.OnAboutUsClick = null;
            this.headerControl1.OnHomeClick = null;
            this.headerControl1.OnLoginClick = null;
            this.headerControl1.OnRegisterClick = null;
            this.headerControl1.Size = new System.Drawing.Size(1136, 65);
            this.headerControl1.TabIndex = 0;
            // 
            // organizationInfo1
            // 
            this.organizationInfo1.Location = new System.Drawing.Point(0, 65);
            this.organizationInfo1.Name = "organizationInfo1";
            this.organizationInfo1.OnDonatePress = null;
            this.organizationInfo1.Size = new System.Drawing.Size(1136, 584);
            this.organizationInfo1.TabIndex = 4;
            this.organizationInfo1.Visible = false;
            this.organizationInfo1.Load += new System.EventHandler(this.organizationInfo1_Load);
            // 
            // chooseDonationOption1
            // 
            this.chooseDonationOption1.Location = new System.Drawing.Point(0, 65);
            this.chooseDonationOption1.Name = "chooseDonationOption1";
            this.chooseDonationOption1.Size = new System.Drawing.Size(1136, 565);
            this.chooseDonationOption1.TabIndex = 7;
            this.chooseDonationOption1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 624);
            this.Controls.Add(this.chooseDonationOption1);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.organizationInfo1);
            this.Controls.Add(this.registerControl1);
            this.Controls.Add(this.tempHome1);
            this.Controls.Add(this.loginControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPODS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderControl headerControl1;
        private LoginControl loginControl1;
        private RegisterControl registerControl1;
        private organizationInfo organizationInfo1;
        private View.Controls.tempHome tempHome1;
        private chooseDonationOption chooseDonationOption1;
    }
}

