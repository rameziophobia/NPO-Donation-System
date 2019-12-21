using Newtonsoft.Json;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public class FileDatabaseAccess : DatabaseAccess
    {
        private const string PATH_FOLDER_DATA = "../../data/";
        private const string PATH_FILE_ORG = PATH_FOLDER_DATA + "Organizations.json";
        private const string PATH_FILE_DONOR = PATH_FOLDER_DATA + "Donors.json";
        private const string PATH_FILE_LOGINS = PATH_FOLDER_DATA + "logins.json";

        public override Dictionary<string, string> GetLoginInfos()
        {
            return readJson<Dictionary<string, string>>(PATH_FILE_LOGINS);
        }

        public override List<Organization> loadOrganizations()
        {
            return readJson<List<Organization>>(PATH_FILE_ORG);
        }

        public override void SaveOrganizations(List<Organization> organizations)
        {
            writeJson(PATH_FILE_ORG, organizations);
        }

        internal override void SaveDonors(List<Donor> donors)
        {
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
        }

        internal override List<Donor> loadDonors()
        {
            return readJson<List<Donor>>(PATH_FILE_DONOR);
        }

        internal override void addLogin(string email, string password)
        {
            var logins = GetLoginInfos();
            logins[email] = password;
            writeJson(PATH_FILE_LOGINS, logins);
        }
    }
}
