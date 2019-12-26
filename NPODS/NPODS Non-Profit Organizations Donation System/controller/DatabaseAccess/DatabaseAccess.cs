using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public abstract class DatabaseAccess
    {
        private static readonly DatabaseAccess instance = FileDatabaseAccess.getInstance();

        private readonly Dictionary<CacheKeys, object> cache;

        private enum CacheKeys
        {
            LOGINS,
            ORGANIZATIONS,
            DONORS
        }

        protected DatabaseAccess()
        {
            cache = new Dictionary<CacheKeys, object>();
        }

        public static DatabaseAccess getInstance()
        {
            return instance;
        }

        public List<LoginInfo> loadLoginInfos()
        {
            if (!cache.ContainsKey(CacheKeys.LOGINS))
            {
                cache[CacheKeys.LOGINS] = getLoginInfosFromDb();
            }

            return (List<LoginInfo>) cache[CacheKeys.LOGINS];
        }

        protected abstract List<LoginInfo> getLoginInfosFromDb();

        public List<Organization> loadOrganizations()
        {
            if (!cache.ContainsKey(CacheKeys.ORGANIZATIONS))
            {
                cache[CacheKeys.ORGANIZATIONS] = loadOrganizationsFromDb();
            }

            return (List<Organization>) cache[CacheKeys.ORGANIZATIONS];
        }
        protected abstract List<Organization> loadOrganizationsFromDb();

        public void saveOrganizations(List<Organization> organizations)
        {
            cache[CacheKeys.ORGANIZATIONS] = organizations;
            saveOrganizationsToDb(organizations);
        }
        protected abstract void saveOrganizationsToDb(List<Organization> organizations);

        public List<Donor> loadDonors()
        {
            if (!cache.ContainsKey(CacheKeys.DONORS))
            {
                cache[CacheKeys.DONORS] = loadDonorsFromDb();
            }

            return (List<Donor>) cache[CacheKeys.DONORS];
        }
        protected abstract List<Donor> loadDonorsFromDb();

        public void saveDonors(List<Donor> donors)
        {
            cache[CacheKeys.DONORS] = donors;
            saveDonorsToDb(donors);
        }
        protected abstract void saveDonorsToDb(List<Donor> donors);

        public void addLogin(string email, string password, AccountType accountType)
        {
            List<LoginInfo> logins = loadLoginInfos();
            logins.Add(new LoginInfo(email, password, accountType));
            cache[CacheKeys.LOGINS] = logins;
            saveLoginsToDb(logins);
        }

        protected abstract void saveLoginsToDb(List<LoginInfo> infos);

        public void saveOrganisation(Organization organization)
        {
            var orgs = loadOrganizations();
            if (!orgs.Contains(organization))
            {
                orgs.Add(organization);
            }
            saveOrganizations(orgs);
        }
        
        public void saveDonor(Donor donor)
        {
            var donors = loadDonors();
            if (!donors.Contains(donor))
            {
                donors.Add(donor);
            }
            saveDonors(donors);
        }
    }
}
