using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class org_card : UserControl
    {

        

       

        public org_card()
        {
            InitializeComponent();
        }
        
        public void dispalyOrgs()
        {
             List<Organization> orgs = DatabaseAccess.getInstance().loadOrganizations();
            int i = 0;
            while(orgs.Count > i)
            {
               OrganizationCard or = new OrganizationCard();
                or.display(orgs[i]);
                flowLayoutPanel1.Controls.Add(or);
                i++;
                
            }
        }

        private void OrganizationCard1_Load(object sender, System.EventArgs e)
        {
            

        }

        private void Org_card_Load(object sender, System.EventArgs e)
        {


        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
