using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    class Organization : Account
    {
        private bool certified;
        public string Description { get; set; }
        // ! goal
        private DonationGoal donationGoal = new DonationGoal(0);
        public DonationGoal DonationGoal 
        {
            get => donationGoal;
            set => donationGoal = value;
        }
        //todo NonMoneyDonation
        //todo acceptedPaymentMethods list<EPaymentMethod> .. msh 3agbani remove, add interface lihom we option el donor ye set his Pmethod
        //todo logo image ?
        //todo addEvent ? event yb2a special donation goal for purpose X in time T example: 3ayzin ngm3 x le yoom  el yateem (before day d)
        //todo donationStatistics
        public Organization(string email, string password) : base(email, password)
        {
            this.certified = false;
        }

        private void setCertified()
        {
            certified = true;
        }

        public void applyForCertification() 
        {
            //todo applyForCertification
        }


    }
}
