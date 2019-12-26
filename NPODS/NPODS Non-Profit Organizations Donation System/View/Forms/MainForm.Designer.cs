using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls;
using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption.PaymentOptions;
using NPODS_Non_Profit_Organizations_Donation_System.View.UserControls.Header;

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
            this.editDonationOptions1 = new NPODS_Non_Profit_Organizations_Donation_System.editDonationOptions();
            this.browseOrganizations1 = new NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.Browser.BrowseOrganizations();
            this.organizationDashboard1 = new NPODS_Non_Profit_Organizations_Donation_System.OrganizationDashboard();
            this.accountPopup1 = new NPODS_Non_Profit_Organizations_Donation_System.View.UserControls.Header.AccountPopup();
            this.headerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.HeaderControl();
            this.registerControl1 = new NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.RegisterControl();
            this.loginControl1 = new NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.LoginControl();
            this.chooseDonationOption1 = new NPODS_Non_Profit_Organizations_Donation_System.chooseDonationOption();
            this.organizationInfo1 = new NPODS_Non_Profit_Organizations_Donation_System.organizationInfo();
            this.editOrganizationInfo1 = new NPODS_Non_Profit_Organizations_Donation_System.editOrganizationInfo();
            this.paymentOption1 = new NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption.PaymentOptions.PaymentOption();
            this.SuspendLayout();
            // 
            // editDonationOptions1
            // 
            this.editDonationOptions1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDonationOptions1.Location = new System.Drawing.Point(0, 65);
            this.editDonationOptions1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editDonationOptions1.Name = "editDonationOptions1";
            this.editDonationOptions1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editDonationOptions1.Size = new System.Drawing.Size(1136, 570);
            this.editDonationOptions1.TabIndex = 14;
            this.editDonationOptions1.Visible = false;
            // 
            // browseOrganizations1
            // 
            this.browseOrganizations1.Location = new System.Drawing.Point(0, 66);
            this.browseOrganizations1.Name = "browseOrganizations1";
            this.browseOrganizations1.OnOrgClick = null;
            this.browseOrganizations1.Size = new System.Drawing.Size(1123, 563);
            this.browseOrganizations1.TabIndex = 13;
            // 
            // organizationDashboard1
            // 
            this.organizationDashboard1.Location = new System.Drawing.Point(0, 65);
            this.organizationDashboard1.Name = "organizationDashboard1";
            this.organizationDashboard1.Size = new System.Drawing.Size(1123, 565);
            this.organizationDashboard1.TabIndex = 12;
            this.organizationDashboard1.Visible = false;
            // 
            // accountPopup1
            // 
            this.accountPopup1.Location = new System.Drawing.Point(892, 65);
            this.accountPopup1.Name = "accountPopup1";
            this.accountPopup1.OnEditAccountClick = null;
            this.accountPopup1.OnLogOutClick = null;
            this.accountPopup1.OnViewDashboardClick = null;
            this.accountPopup1.Size = new System.Drawing.Size(244, 114);
            this.accountPopup1.TabIndex = 8;
            this.accountPopup1.Visible = false;
            // 
            // headerControl1
            // 
            this.headerControl1.AccountPopup = null;
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
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.Transparent;
            this.registerControl1.Location = new System.Drawing.Point(275, 177);
            this.registerControl1.Margin = new System.Windows.Forms.Padding(1);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.OnOrganizationRegister = null;
            this.registerControl1.Size = new System.Drawing.Size(548, 380);
            this.registerControl1.TabIndex = 3;
            this.registerControl1.Visible = false;
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.Transparent;
            this.loginControl1.Location = new System.Drawing.Point(409, 271);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.OnLogin = null;
            this.loginControl1.Size = new System.Drawing.Size(367, 231);
            this.loginControl1.TabIndex = 9;
            this.loginControl1.Visible = false;
            // 
            // chooseDonationOption1
            // 
            this.chooseDonationOption1.Location = new System.Drawing.Point(0, 65);
            this.chooseDonationOption1.Name = "chooseDonationOption1";
            this.chooseDonationOption1.OnBackPress = null;
            this.chooseDonationOption1.Organization = null;
            this.chooseDonationOption1.Size = new System.Drawing.Size(1150, 565);
            this.chooseDonationOption1.TabIndex = 7;
            this.chooseDonationOption1.Visible = false;
            // 
            // organizationInfo1
            // 
            this.organizationInfo1.Location = new System.Drawing.Point(0, 65);
            this.organizationInfo1.Name = "organizationInfo1";
            this.organizationInfo1.Size = new System.Drawing.Size(1150, 584);
            this.organizationInfo1.TabIndex = 4;
            this.organizationInfo1.Visible = false;
            // 
            // editOrganizationInfo1
            // 
            this.editOrganizationInfo1.Location = new System.Drawing.Point(0, 65);
            this.editOrganizationInfo1.Name = "editOrganizationInfo1";
            this.editOrganizationInfo1.OnEditDonatePress = null;
            this.editOrganizationInfo1.Size = new System.Drawing.Size(1153, 565);
            this.editOrganizationInfo1.TabIndex = 11;
            this.editOrganizationInfo1.Visible = false;
            // 
            // paymentOption1
            // 
            this.paymentOption1.Location = new System.Drawing.Point(0, 65);
            this.paymentOption1.Name = "paymentOption1";
            this.paymentOption1.OnBackPress = null;
            this.paymentOption1.OnPaymentValidated = null;
            this.paymentOption1.Organization = null;
            this.paymentOption1.Size = new System.Drawing.Size(1021, 565);
            this.paymentOption1.TabIndex = 7;
            this.paymentOption1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 624);
            this.Controls.Add(this.editDonationOptions1);
            this.Controls.Add(this.browseOrganizations1);
            this.Controls.Add(this.organizationDashboard1);
            this.Controls.Add(this.accountPopup1);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.registerControl1);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.chooseDonationOption1);
            this.Controls.Add(this.organizationInfo1);
            this.Controls.Add(this.editOrganizationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPODS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderControl headerControl1;
        private RegisterControl registerControl1;
        private organizationInfo organizationInfo1;
        private PaymentOption paymentOption1;
        private chooseDonationOption chooseDonationOption1;
        private AccountPopup accountPopup1;
        private LoginControl loginControl1;
        private editOrganizationInfo editOrganizationInfo1;
        private OrganizationDashboard organizationDashboard1;
        private View.CustomControls.UserControls.Browser.BrowseOrganizations browseOrganizations1;
        private editDonationOptions editDonationOptions1;
    }
}

