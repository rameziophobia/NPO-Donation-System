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
            lbl_orgName.Text = organization.Name;
            setGoalBar(organization);
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
        private void setGoalBar(Organization organization)
        {
            if(organization.DonationGoal.Target == 0)
            {
                pbr_goal.Visible = false;
            }
            pbr_goal.Value = (int)organization.DonationGoal.CurrentProgress;
            pbr_goal.Maximum = (int)organization.DonationGoal.Target;
        }
        private void btn_donate_Click(object sender, EventArgs e)
        {
            OnDonatePress();

        }
    }
}
