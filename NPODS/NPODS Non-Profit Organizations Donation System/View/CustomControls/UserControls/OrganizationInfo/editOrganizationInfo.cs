using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System;
using System.Drawing;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System.IO;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class editOrganizationInfo : UserControl
    {
        private Organization organization;
        public editOrganizationInfo()
        {
            InitializeComponent();
        }

        private void btn_edit_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnl_changePhoto.Visible)
            {
                pnl_changePhoto.Visible = false;
            }
            else
            {
                pnl_changePhoto.Visible = true;
            }

        }
        private void btn_uploadPhoto_Click(object sender, EventArgs e)
        {
            if (file_chooseImage.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(file_chooseImage.FileName);
                string newPath = @"..\..\Resources/Images/OrganizationLogos/" + organization.Name + extension;
                pic_orgLogo.Image = new Bitmap(Properties.Resources.defaultImage);
                File.Copy(file_chooseImage.FileName,newPath,true);
                pic_orgLogo.Image = new Bitmap(file_chooseImage.FileName);
                organization.LogoFilePath = file_chooseImage.FileName;
            }
        }
        private void btn_rmvPhoto_Click(object sender, EventArgs e)
        {
            pic_orgLogo.Image = new Bitmap(Properties.Resources.defaultImage);
            organization.LogoFilePath = Properties.Resources.defaultImage.ToString();
        }
        public void updateOrgDetails(Organization organization)
        {
            this.organization = organization;
            txt_goalAmount.Text = Convert.ToString((int)this.organization.DonationGoal.Target);
            try
            {
                pic_orgLogo.Image = new Bitmap(this.organization.LogoFilePath);
            }
            catch(Exception ex)
            {
                if(ex is ArgumentException)
                {
                    pic_orgLogo.Image = new Bitmap(Properties.Resources.defaultImage);
                }
            }
            lbl_donated.Text = Convert.ToString(organization.DonationGoal.CurrentProgress);
            pbr_goal.Value = (int)organization.DonationGoal.CurrentProgress;
            rtb_orgDescription.Text = this.organization.Description;
        }
        private void setDonationGoal()
        {
            int donationValue = (int)organization.DonationGoal.Target;
            try
            {
                donationValue = Convert.ToInt32(txt_goalAmount.Text);
                if (donationValue  >= 0)
                {
                    organization.DonationGoal.Target = donationValue;
                    pbr_goal.Maximum = (int)donationValue;

                }
                else
                {
                    throw new FormatException();
                }
            }
            catch(Exception ex)
            {
                if(ex is FormatException)
                {
                    MessageBox.Show("Donation value must be greater than or equal zero.", "Donation Value Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
        private void setDescription()
        {
            organization.Description = rtb_orgDescription.Text;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            setDonationGoal();
            setDescription();
            organization.saveToDatabase();
        }
    }
}
