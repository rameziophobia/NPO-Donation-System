using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.Browser
{
    public partial class BrowseOrganizations : UserControl
    {
        public delegate void OnPanelClick(Organization organization);
        public OnPanelClick OnOrgClick { get; set; }
        public BrowseOrganizations()
        {
            InitializeComponent();
        }
        public void dispalyOrgs(OnPanelClick onOrgClick)
        {
            List<Organization> orgs = DatabaseAccess.getInstance().loadOrganizations();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0;i < orgs.Count ; i++)
            {
                OrganizationCard org = new OrganizationCard();
                org.display(orgs[i]);
                Organization currentOrg = orgs[i]; 
                org.getBtnMoreInfo().Click += (s, e) => onOrgClick(currentOrg);
                flowLayoutPanel1.Controls.Add(org);
            }
        }
    }
}
