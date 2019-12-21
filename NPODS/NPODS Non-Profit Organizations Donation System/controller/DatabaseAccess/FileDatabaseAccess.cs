using Newtonsoft.Json;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public class FileDatabaseAccess : DatabaseAccess
    {

        private const string PATH_ORG = "../../data/Organizations.json";
        private const string PATH_DON = "../../data/Donors.json";

        public override Dictionary<string, string> GetLoginInfos()
        {
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(Encoding.UTF8.GetString(Properties.Resources.logins))
                    ?? new Dictionary<string, string>();
            }
            catch (FileNotFoundException)
            {
                //using (StreamWriter streamWriter = File.CreateText(PATH_LOGIN))
                //{
                //}
                //return GetLoginInfos();
                return null;
            }
            catch (JsonReaderException)
            {
                //todo log exception
                //todo raise exception ?
                return new Dictionary<string, string>();
            }
        }

        public override List<Organization> loadOrganizations()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(PATH_ORG))
                {
                    return JsonConvert.DeserializeObject<List<Organization>>(streamReader.ReadToEnd()) ?? new List<Organization>();
                }
            }
            catch (FileNotFoundException)
            {
                using (StreamWriter streamWriter = File.CreateText(PATH_ORG))
                {
                }
                return loadOrganizations();
            }
            catch (JsonReaderException)
            {
                //todo log exception
                //todo raise exception ?
                return new List<Organization>();
            }
        }

        public override void SaveOrganizations(List<Organization> organizations)
        {
            writeJson(PATH_ORG, organizations);
        }

        internal override void SaveDonors(List<Donor> donors)
        {
            writeJson(PATH_DON, donors);
        }

        private static void writeJson(string path, object obj)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(JsonConvert.SerializeObject(obj));
            }
        }

        internal override List<Donor> loadDonors()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(PATH_DON))
                {
                    return JsonConvert.DeserializeObject<List<Donor>>(streamReader.ReadToEnd()) ?? new List<Donor>();
                }
            }
            catch (FileNotFoundException)
            {
                using (StreamWriter streamWriter = File.CreateText(PATH_DON))
                {
                }
                return loadDonors();
            }
            catch (JsonReaderException)
            {
                //todo log exception
                //todo raise exception ?
                return new List<Donor>();
            }
        }


    }
}
