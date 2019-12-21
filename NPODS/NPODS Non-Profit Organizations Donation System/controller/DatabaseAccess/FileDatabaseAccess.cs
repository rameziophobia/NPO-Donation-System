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

        public override Organization[] loadOrganizations()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(PATH_ORG))
                {
                    return JsonConvert.DeserializeObject<Organization[]>(streamReader.ReadToEnd()) ?? new Organization[0];
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
                return new Organization[0];
            }
        }

        public override void SaveOrganizations(Organization[] organizations)
        {
            using (StreamWriter streamWriter = new StreamWriter(PATH_ORG))
            {
                streamWriter.Write(JsonConvert.SerializeObject(organizations));
            }
        }
    }
}
