using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Controller.Registration;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
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
            }
            else
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
            if (requiredInfoMissing())
            {
                return;
            }
            if (!(txt_password.Text.Equals(txt_confirmPassword.Text)))
            {
                lbl_errorMessage.Text = "error: the two passwords do not match";
                return;
            }

            string email = txt_email.Text.ToLower();

            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                lbl_errorMessage.Text = "error: Invalid Email";
                return;
            }

            string name = txt_name.Text;

            RegistrationUtil registrationUtil = RegistrationUtil.getInstance();


            if (cbo_accountType.SelectedItem.ToString().Trim() == "Donor")
            {
                Donor donor = getDonorAccount(email, name);
                try
                {
                    registrationUtil.registerDonor(donor, txt_password.Text);
                }
                catch (EmailAlreadyExistsException)
                {
                    lbl_errorMessage.Text = "error: this donor email already exists";
                    return;
                }
            }
            else
            {
                Organization organization = getOrganizationAccount(email, name);
                try
                {
                    registrationUtil.registerOrganization(organization, txt_password.Text);
                }
                catch (EmailAlreadyExistsException)
                {
                    lbl_errorMessage.Text = "error: this organization email already exists";
                    return;
                }
            }
            lbl_errorMessage.Text = "Success";
        }

        private Organization getOrganizationAccount(string email, string name)
        {
            Organization organization = new Organization(email, name);
            organization.OrganizationUrl = txt_organizationUrl.Text;
            return organization;
        }

        private Donor getDonorAccount(string email, string name)
        {
            Donor donor = new Donor(email, name);
            donor.Gender = cbo_gender.SelectedItem.ToString().Trim();
            donor.Birthday = dtp_birthday.Value;
            return donor;
        }

        private bool requiredInfoMissing()
        {
            if (cbo_accountType.SelectedItem is null)
            {
                lbl_errorMessage.Text = "error: account type is required";
                return true;
            }
            else if (cbo_gender.SelectedItem is null && cbo_gender.Visible)
            {
                lbl_errorMessage.Text = "error: gender field is required";
                return true;
            }
            else if (txt_name.Text.Equals("") ||
               txt_password.Text.Equals("") ||
               txt_confirmPassword.Text.Equals(""))
            {
                lbl_errorMessage.Text = "error: please fill the required fields";
                return true;
            }
            return false;
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            cbo_accountType.SelectedIndex = 0;
        }

        private void RegisterControl_VisibleChanged(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_name.Text = "";
            txt_password.Text = "";
            txt_confirmPassword.Text = "";
            txt_organizationUrl.Text = "";
            cbo_accountType.SelectedIndex = 0;
            cbo_gender.SelectedIndex = -1;
            dtp_birthday.Value = DateTime.Now;
        }
    }
}
