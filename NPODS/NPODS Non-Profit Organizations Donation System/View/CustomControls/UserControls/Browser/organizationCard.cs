using System;
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
            
        }
    }
}
