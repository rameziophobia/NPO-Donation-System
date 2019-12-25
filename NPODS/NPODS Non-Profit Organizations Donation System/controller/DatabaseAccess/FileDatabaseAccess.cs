using Newtonsoft.Json;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System;
using System.Collections.Generic;
using System.IO;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public class FileDatabaseAccess : DatabaseAccess
    {
        private const string PATH_FOLDER_DATA = "../../data/";
        private const string PATH_FILE_ORG = PATH_FOLDER_DATA + "Organizations.json";
        private const string PATH_FILE_DONOR = PATH_FOLDER_DATA + "Donors.json";
        private const string PATH_FILE_LOGINS = PATH_FOLDER_DATA + "logins.json";

        private readonly Dictionary<CacheKeys, object> cache;

        enum CacheKeys
        {
            LOGINS,
            ORGANIZATIONS,
            DONORS
        }

        private static readonly DatabaseAccess instance = new FileDatabaseAccess();

        public static DatabaseAccess getInstance()
        {
            return instance;
        }

        protected FileDatabaseAccess()
        {
            cache = new Dictionary<CacheKeys, object>();
        }

        public override List<LoginInfo> LoadLoginInfos()
        {
            if (!cache.ContainsKey(CacheKeys.LOGINS))
            {
                cache[CacheKeys.LOGINS] = readJson<List<LoginInfo>>(PATH_FILE_LOGINS);
            }

            return (List<LoginInfo>) cache[CacheKeys.LOGINS];
        }

        public override List<Organization> loadOrganizations()
        {
            if (!cache.ContainsKey(CacheKeys.ORGANIZATIONS))
            {
                cache[CacheKeys.ORGANIZATIONS] = readJson<List<Organization>>(PATH_FILE_ORG);
            }

            return (List<Organization>) cache[CacheKeys.ORGANIZATIONS];
        }

        public override void SaveOrganizations(List<Organization> organizations)
        {
            cache[CacheKeys.ORGANIZATIONS] = organizations;
            writeJson(PATH_FILE_ORG, organizations);
        }

        internal override void SaveDonors(List<Donor> donors)
        {
            cache[CacheKeys.DONORS] = donors;
            writeJson(PATH_FILE_DONOR, donors);
        }

        private void writeJson(string path, object obj)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(JsonConvert.SerializeObject(obj));
            }
        }

        private T readJson<T>(string filePath) where T : class, new()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd()) ?? new T();
                }
            }
            catch (FileNotFoundException)
            {
                using (StreamWriter streamWriter = File.CreateText(filePath))
                {
                }

                return new T();
            }
            catch (JsonReaderException)
            {
                //todo log exception
                //todo raise exception ?
                return new T();
            }
            catch (DirectoryNotFoundException)
            {
                string temp = filePath.Substring(0, filePath.Length - filePath.LastIndexOf('/') - 1);
                try
                {
                    Directory.CreateDirectory(temp);
                }
                catch (UnauthorizedAccessException)
                {
                    return null;
                }

                return readJson<T>(filePath);
            }
        }

        internal override List<Donor> loadDonors()
        {
            if (!cache.ContainsKey(CacheKeys.DONORS))
            {
                cache[CacheKeys.DONORS] = readJson<List<Donor>>(PATH_FILE_DONOR);
            }

            return (List<Donor>) cache[CacheKeys.DONORS];
        }

        internal override void addLogin(string email, string password, AccountType accountType)
        {
            List<LoginInfo> logins = LoadLoginInfos();
            logins.Add(new LoginInfo(email, password, accountType));
            cache[CacheKeys.LOGINS] = logins;
            writeJson(PATH_FILE_LOGINS, logins);
        }

        internal override void saveOrganisation(Organization organization)
        {
            var orgs = loadOrganizations();
            if (!orgs.Contains(organization))
            {
                orgs.Add(organization);
            }
            SaveOrganizations(orgs);
        }
        
        internal override void saveDonor(Donor donor)
        {
            var donors = loadDonors();
            if (!donors.Contains(donor))
            {
                donors.Add(donor);
            }
            SaveDonors(donors);
        }
    }
}