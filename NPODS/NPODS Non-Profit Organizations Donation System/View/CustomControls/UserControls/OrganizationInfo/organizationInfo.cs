using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class organizationInfo : UserControl
    {
        public delegate void OnButtonClick();
        public OnButtonClick OnDonatePress { get; set; }

        public organizationInfo()
        {
            InitializeComponent();
        }

        public void updateOrganisation(Organization organization)
        {
            lbl_description.Text = organization.Description;
            lbl_donated.Text = "US$" + organization.DonationGoal.CurrentProgress.ToString();
            lbl_goal.Text = "pledged of US$ "+ organization.DonationGoal.Target.ToString() + " goal.";
            pbr_goal.Maximum = (int)organization.DonationGoal.Target;
            lbl_goal.Text = organization.DonationGoal.Target.ToString();
            lbl_orgName.Text = organization.Name;
            try
            {
                string logoFilePath = organization.LogoFilePath;
                pic_orgLogo.Image = new Bitmap(logoFilePath);
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is ArgumentException)
                {
                    pic_orgLogo.Image = Properties.Resources.defaultImage;
                }
                else
                {
                    throw;
                }
            }
        }

        private void btn_donate_Click(object sender, EventArgs e)
        {
            OnDonatePress();

        }
    }
}
