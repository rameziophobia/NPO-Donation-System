﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    class Donor : Account
    {
        public Donor(string email, string password) : base(email, password)
        {
            //todo gender
            //todo day of birth
        }
    }
}
