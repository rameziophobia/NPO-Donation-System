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
    public partial class org_card : UserControl
    {

        Organization org1 = new Organization("fhehg", "fggfef");
        Organization org2 = new Organization("fhehg", "fggfef");
        Organization org3 = new Organization("fhehg", "fggfef");
        Organization org4 = new Organization("fhehg", "fggfef");

        public org_card()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Org_card_Load(object sender, EventArgs e)
        {

        }

      
       

        private void Organization1_Load(object sender, EventArgs e)
        {
            organization1.display(org1);
        }

        private void Organization2_Load(object sender, EventArgs e)
        {
            organization2.display(org2);
        }

        private void Organization4_Load_1(object sender, EventArgs e)
        {
            organization4.display(org4);

        }

        private void Organization3_Load_1(object sender, EventArgs e)
        {
            organization3.display(org3);

        }
    }
}
