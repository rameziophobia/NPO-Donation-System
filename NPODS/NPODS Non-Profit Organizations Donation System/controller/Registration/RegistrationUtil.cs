using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NPODS_Non_Profit_Organizations_Donation_System.Controller.Registration
{
    class RegistrationUtil
    {
        private static readonly RegistrationUtil instance = new RegistrationUtil();
        private DatabaseAccess databaseAccess;
        private List<Organization> organizations;
        private List<Donor> donors;

        private RegistrationUtil()
        {
            databaseAccess = DatabaseAccess.getInstance();
            organizations = databaseAccess.loadOrganizations();
            donors = databaseAccess.loadDonors();
        }

        public static RegistrationUtil getInstance()
        {
            return instance;
        }

        internal void registerOrganization(Organization organization, string password)
        {
            using (SHA256 sha = SHA256.Create())
                password = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
            if (organizations.Any(org => org.Email.Equals(organization.Email)))
            {
                throw new EmailAlreadyExistsException();
            }
            else
            {
                organizations.Add(organization);
                databaseAccess.saveOrganizations(organizations);
                databaseAccess.addLogin(organization.Email, password, AccountType.Organization);
            }
        }

        internal void registerDonor(Donor donor, string password)
        {
            using (SHA256 sha = SHA256.Create())
                password = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
            if (donors.Any(org => org.Email.Equals(donor.Email)))
            {
                throw new EmailAlreadyExistsException();
            }
            else
            {
                donors.Add(donor);
                databaseAccess.saveDonors(donors);
                databaseAccess.addLogin(donor.Email, password, AccountType.Donor);
            }
        }
    }
}
