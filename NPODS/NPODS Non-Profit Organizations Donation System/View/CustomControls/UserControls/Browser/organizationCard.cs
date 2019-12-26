using System;
using System.Drawing;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using static NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.Browser.BrowseOrganizations;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class OrganizationCard : UserControl
    {
        public Organization OrgToShow { get; set; }
        public OrganizationCard()
        {
            InitializeComponent();
        }
        public void display( Organization org)
        {
            txt_orgName.Text = org.Name;
            txt_orgDescription.Text = org.Description;
            try
            {
                string logoFilePath = org.LogoFilePath;
                pic_orgLogo.Image = new Bitmap(logoFilePath);
            }
            catch (Exception ex)
            {
                if (ex is System.IO.FileNotFoundException || ex is ArgumentException)
                {
                    pic_orgLogo.Image = Properties.Resources.defaultImage;
                }
                else
                {
                    throw;
                }
            }
            pic_orgBanner.Image = new Bitmap(Properties.Resources.Banner);
            
        }
    }
}
