using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil
{
    //todo implements onMonthly Interface
    public class DonationGoal
    {
        private bool monthly;
        public int CurentProgress { get; private set; }
        public int Value { get; private set; }

        public DonationGoal(int value, bool monthly = false)
        {
            this.Value = value;
            this.monthly = monthly;
        }

        public void onMonthly()
        {
            if(monthly)
                this.CurentProgress = 0;
        }
    }
}
