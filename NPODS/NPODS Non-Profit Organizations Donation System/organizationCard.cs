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

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class OrganizationCard: UserControl
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }

      
      

        private void OrgPic_Click(object sender, EventArgs e)
        {

        }

        private void Organization_Load(object sender, EventArgs e)
        {   

        }

        private void OrgLogo_Click(object sender, EventArgs e)
        {

        }

        



        public void display(Organization org)
        {
            OrgName.Text = org.Name;
            OrgDesc.Text = org.Description;
            OrgLogo.Image = new Bitmap("C:/Users/Beshoy/Desktop/212.jpg");
            OrgPic.Image = new Bitmap("C:/Users/Beshoy/Desktop/images.jpg");

        }
    }
}
