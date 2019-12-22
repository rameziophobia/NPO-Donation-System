using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class MainForm : Form
    {
        private UserControl lastActiveUserControl;
        private Account currentAccount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void login(Account account)
        {
            headerControl1.ShowAccount(account);
            currentAccount = account;
            switchControls(tempHome1);
        }

        private void logout()
        {
            DialogResult response = MessageBox.Show("Are you sure you want to logout?", "Logout Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
            headerControl1.Logout();
            }
        }

        private void switchControls(UserControl userControl)
        {
            userControl.Visible = true;
            lastActiveUserControl.Visible = false;
            lastActiveUserControl = userControl;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lastActiveUserControl = tempHome1;
            headerControl1.OnAboutUsClick += () => MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            headerControl1.OnLoginClick += () => switchControls(loginControl1);
            headerControl1.OnRegisterClick += () => switchControls(registerControl1);
            headerControl1.OnHomeClick += () => switchControls(tempHome1);
            headerControl1.AccountPopup = accountPopup1;

            Organization organization = new Organization(
                    "Instagram@hydra.com",
                    "This is a dummy org")
            {
                LogoFilePath = "Iceland.png",
                Description = "ignore the name. there's no ice here",
                MiscDonations = new List<MiscDonation> { new MiscDonation("Ramesbasdahdsuihdy.com") },
                SingleDonation = new SingleDonation(new DonationTier[] { }),
                DonationGoal = new DonationGoal(true, 500f, 8458f),
                OrganizationStatistics = new OrganizationStatistics()
            };
            organization.SingleDonation.customEnabled = true;
            tempHome1.OnTempClick = () =>
            {
                switchControls(organizationInfo1);
                organizationInfo1.updateOrganisation(organization);
            };
            organizationInfo1.OnDonatePress += () =>
            {
                switchControls(chooseDonationOption1);
                chooseDonationOption1.Organization = organization;
                chooseDonationOption1.setAvailableTypes();
                chooseDonationOption1.setDefaultOption();
                chooseDonationOption1.updateDefault();
            };
            chooseDonationOption1.OnBackPress += () =>
            {
                switchControls(organizationInfo1);
                organizationInfo1.updateOrganisation(organization);
            };

            accountPopup1.OnViewDashboardClick += () => MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            accountPopup1.OnEditAccountClick += () => MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            accountPopup1.OnLogOutClick += logout;

            loginControl1.OnLogin += login;
        }
    }
}
