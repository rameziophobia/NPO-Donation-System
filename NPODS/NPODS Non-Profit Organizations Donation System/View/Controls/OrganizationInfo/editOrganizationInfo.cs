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
            if(file_chooseImage.ShowDialog() == DialogResult.OK)
            {
                pic_orgLogo.Image = new Bitmap(file_chooseImage.FileName);
            }
        }

        private void btn_rmvPhoto_Click(object sender, EventArgs e)
        {
            pic_orgLogo.Image = new Bitmap(Properties.Resources.defaultImage);
        }
    }
}
