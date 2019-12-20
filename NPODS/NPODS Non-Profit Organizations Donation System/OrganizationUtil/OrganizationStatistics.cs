using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil {
    public class OrganizationStatistics {
        public int NumberOfSubs { get; private set; }
        public int TotalNumberOfSubs { get; private set; }
        public DateTime lastUpdate { get; private set; }
        public bool hasMoneyDonations;
        public bool hasMiscDonations;

        private int[] monthlySubs;

        public OrganizationStatistics() {
            NumberOfSubs = 0;
            monthlySubs = new int[12];
            resetMonthlySubs();
            lastUpdate = DateTime.Now;

            hasMoneyDonations = false;
            hasMiscDonations = false;
        }
        private void resetMonthlySubs() {
            for (int i = 0; i < 12; i++) {
                monthlySubs[i] = 0;
            }
        }
        public void increaseMonthlySubs(int increments) {
            if (lastUpdate.Month != DateTime.Now.Month) {
                resetMonthlySubs();
                TotalNumberOfSubs += NumberOfSubs;
                monthlySubs[lastUpdate.Month - 1] = NumberOfSubs;
                NumberOfSubs = increments;
            } else {
                NumberOfSubs += increments;
            }
            lastUpdate = DateTime.Now;
        }

        public int[] getMonthlySubs() {
           increaseMonthlySubs(0);
           return monthlySubs;
        }

    }
}
