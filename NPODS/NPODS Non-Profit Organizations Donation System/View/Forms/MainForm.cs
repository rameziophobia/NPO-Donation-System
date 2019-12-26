using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using NPODS_Non_Profit_Organizations_Donation_System.Transactions;
using static NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.Browser.BrowseOrganizations;

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
            if (!isOrganization)
            {
                ((Donor)account).PaymentMethod = new Payment.Paypal();
            }
            showOrganizations();    
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
            Organization organization = new Organization (
                "Instagram@hydra.com",
                "This is a dummy org") {
                LogoFilePath = "Iceland.png",
                Description = "ignore the name. there's no ice here",
                DonationGoal = new DonationGoal(true, 500f, 8458f),
                OrganizationStatistics = new OrganizationStatistics(),
                DonationOptions = new DonationOptions(),
            };
            lastActiveUserControl = browseOrganizations1;
            browseOrganizations1.OnOrgClick += (Organization org) =>
            {
                switchControls(organizationInfo1);
                organizationInfo1.updateOrganisation(org);
                organization = org;
            };
            browseOrganizations1.dispalyOrgs(browseOrganizations1.OnOrgClick);

            headerControl1.OnAboutUsClick += () => MessageBox.Show ("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            headerControl1.OnLoginClick += () => switchControls (loginControl1);
            headerControl1.OnRegisterClick += () => switchControls (registerControl1);
            headerControl1.OnHomeClick += () =>
            {
                showOrganizations();
            };
            headerControl1.AccountPopup = accountPopup1;

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
                    switchControls(organizationDashboard1);
                    organizationDashboard1.setOrganization((Organization)currentAccount);
                } else {
                    MessageBox.Show ("WIP (Donor)", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            accountPopup1.OnEditAccountClick += () => {
                if (isCurrentAccountOrganization) {
                    switchControls(editOrganizationInfo1);
                    editOrganizationInfo1.updateOrgDetails((Organization)currentAccount);
                } else {
                    MessageBox.Show ("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            editOrganizationInfo1.OnEditDonatePress += () =>
            {
                switchControls(editDonationOptions1);
                editDonationOptions1.CurrentOrg = organization;
            };
            
            accountPopup1.OnLogOutClick += logout;

            loginControl1.OnLogin += login;

            registerControl1.OnOrganizationRegister += (newOrganization) =>
            {
                editOrganizationInfo1.updateOrgDetails(newOrganization);
                switchControls(editOrganizationInfo1);
            };
        }
        private void showOrganizations()
        {
            switchControls(browseOrganizations1);
            browseOrganizations1.dispalyOrgs(browseOrganizations1.OnOrgClick);
        }
        private void initializeChooseDonation(Organization organization)
        {
            chooseDonationOption1.Organization = organization;
            try
            {
                chooseDonationOption1.CurrentAccount = (Donor)currentAccount;
            }catch(Exception e) { 
            }
            chooseDonationOption1.setAvailableTypes();
        }
    }
}