using System;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;


namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class OrganizationCard : UserControl
    {
        public OrganizationCard()
        {
            InitializeComponent();
        }

      
        private void OrgDesc_Click(object sender, EventArgs e)
        {

        }

        private void OrgName_Click(object sender, EventArgs e)
        {

        }

        
        private void LogoPic_Click(object sender, EventArgs e)
        {

        }


        public void display( Organization org)
        {
            OrgName.Text = org.Name;
            OrgDesc.Text = org.Description;
            


        }

        private void OrgPic_Click(object sender, EventArgs e)
        {

        }

        private void OrganizationCard_Load(object sender, EventArgs e)
        {

        }
    }
}
