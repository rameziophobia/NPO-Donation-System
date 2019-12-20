using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class editOrganizationInfo : UserControl
    {
        public editOrganizationInfo()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
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
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            pic_orgLogo.Image = null;
        }
    }
}
