using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class MainForm : Form
    {
        private UserControl lastActiveUserControl;
        public MainForm()
        {
            InitializeComponent();

            lastActiveUserControl = tempHome1;
            headerControl1.OnAboutUsClick = () => MessageBox.Show("WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            headerControl1.OnLoginClick = () => switchControls(loginControl1);
            headerControl1.OnRegisterClick = () => switchControls(registerControl1);
            headerControl1.OnHomeClick = () => switchControls(tempHome1);

            Organization organization = new Organization(
                    "Instagram@hydra.com",
                    "This is a dummy org")
            {
                LogoFilePath = "Iceland.png",
                Description = "ignore the name. there's no ice here",
                MiscDonations = new List<MiscDonation> { new MiscDonation("Ramesbasdahdsuihdy.com") },
                SingleDonation = new SingleDonation(new DonationTier[] {}),
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
        }
        private void switchControls(UserControl userControl)
        {
            userControl.Visible = true;
            lastActiveUserControl.Visible = false;
            lastActiveUserControl = userControl;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }

        private void organizationInfo1_Load(object sender, System.EventArgs e)
        {

        }

        private void chooseDonationOption1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
