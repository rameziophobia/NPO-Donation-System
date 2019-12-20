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
    public partial class RegisterControl : UserControl
    {
        public RegisterControl ()
        {
            InitializeComponent();
        }

        private void cbo_accountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_accountType.SelectedItem.ToString().Trim() == "Donor")
            {
                txt_organizationUrl.Hide();
                lbl_organizationUrl.Hide();
                lbl_gender.Show();
                cbo_gender.Show();
                lbl_dayOfBirth.Show();
                dtp_birthday.Show();
            } else
            {
                txt_organizationUrl.Show();
                lbl_organizationUrl.Show();
                lbl_gender.Hide();
                cbo_gender.Hide();
                lbl_dayOfBirth.Hide();
                dtp_birthday.Hide();
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (!(txt_password.Text.Equals(txt_confirmPassword.Text)))
            {
                lbl_errorMessage.Text = "error: the two passwords do not match";
                return;
            }

            string email = txt_email.Text;
            string password = txt_password.Text;
            string name = txt_name.Text;

            if (cbo_accountType.SelectedItem.ToString().Trim() == "Donor")
            {
                Donor donor = new Donor(email, name);
                donor.Gender = cbo_gender.SelectedItem.ToString().Trim();
                donor.Birthday = dtp_birthday.Value;
            }
            else
            {
                Organization organization = new Organization(email, name);
                organization.OrganizationUrl = txt_organizationUrl.Text;
                
            }
        }
    }
}
