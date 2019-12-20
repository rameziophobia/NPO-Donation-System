using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public class FileDatabaseAccess : DatabaseAccess
    {
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
    }
}
