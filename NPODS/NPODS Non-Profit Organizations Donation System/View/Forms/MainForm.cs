﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;

namespace NPODS_Non_Profit_Organizations_Donation_System {
    public partial class MainForm : Form {
        private const string MSG_LOGOUT_CONFIRM = "Are you sure you want to logout?";
        private const string MSG_LOGOUT_CONFRIM_TITLE = "Logout Confirm";

        private UserControl lastActiveUserControl;
        private Account currentAccount;
        private bool isCurrentAccountOrganization;

        public MainForm () {
            InitializeComponent ();
        }

        private void login (Account account, bool isOrganization) {
            headerControl1.ShowAccount (account);
            isCurrentAccountOrganization = isOrganization;
            currentAccount = account;
            switchControls (tempHome1);
        }

        private void logout () {
            DialogResult response = MessageBox.Show (MSG_LOGOUT_CONFIRM, MSG_LOGOUT_CONFRIM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes) {
                headerControl1.Logout ();
            }
        }

        private void switchControls (UserControl userControl) {
            if (userControl != lastActiveUserControl) {
                userControl.Visible = true;
                lastActiveUserControl.Visible = false;
                lastActiveUserControl = userControl;
            }
        }

        private void MainForm_Load (object sender, EventArgs e) {
            lastActiveUserControl = tempHome1;
            headerControl1.OnAboutUsClick += () => MessageBox.Show ("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            headerControl1.OnLoginClick += () => switchControls (loginControl1);
            headerControl1.OnRegisterClick += () => switchControls (registerControl1);
            headerControl1.OnHomeClick += () => switchControls (tempHome1);
            headerControl1.AccountPopup = accountPopup1;

            Organization organization = new Organization (
                "Instagram@hydra.com",
                "This is a dummy org") {
                LogoFilePath = "Iceland.png",
                Description = "ignore the name. there's no ice here",
                MiscDonations = new List<MiscDonation> { new MiscDonation ("Ramesbasdahdsuihdy.com") },
                SubscriptionDonation = new SubscriptionDonation (new DonationTier[] { new DonationTier ("plz", "send help", 54.2f) }),
                SingleDonation = new SingleDonation (new DonationTier[] { new DonationTier ("plz", "send help", 50.2f) }),
                DonationGoal = new DonationGoal (true, 500f, 8458f),
                OrganizationStatistics = new OrganizationStatistics ()
            };
            organization.SingleDonation.customEnabled = true;
            tempHome1.OnTempClick = () => {
                switchControls (organizationInfo1);
                organizationInfo1.updateOrganisation (organization);
            };
            organizationInfo1.OnDonatePress += () => {
                switchControls (chooseDonationOption1);
                initializeChooseDonation (organization);
            };
            chooseDonationOption1.OnBackPress += () => {
                switchControls (organizationInfo1);
                organizationInfo1.updateOrganisation (organization);
            };

            paymentOption1.OnBackPress += () => {
                switchControls (chooseDonationOption1);
                initializeChooseDonation (organization);
            };

            accountPopup1.OnViewDashboardClick += () => {
                if (isCurrentAccountOrganization) {
                    MessageBox.Show ("WIP (ORG)", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show ("WIP (Donor)", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            accountPopup1.OnEditAccountClick += () => {
                if (isCurrentAccountOrganization) {
                    MessageBox.Show ("WIP (ORG)", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show ("WIP (Donor)", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };;
            accountPopup1.OnLogOutClick += logout;

            loginControl1.OnLogin += login;
        }
        private void initializeChooseDonation (Organization organization) {
            chooseDonationOption1.Organization = organization;
            chooseDonationOption1.setAvailableTypes ();
            chooseDonationOption1.setDefaultOption ();
            chooseDonationOption1.updateDefault ();
        }
    }
}