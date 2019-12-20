using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller
{
    class DatabaseAccess
    {
        private const string FOLDER_DATA = "../../data/";
        private const string PATH_LOGIN = FOLDER_DATA + "logins.json";

        private static readonly DatabaseAccess instance = new DatabaseAccess();

        private DatabaseAccess() { }

        public static DatabaseAccess getInstance()
        {
            return instance;
        }

        public Dictionary<string, string> GetLoginInfos()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(PATH_LOGIN))
                {
                    Dictionary<string, string> output = JsonConvert.DeserializeObject<Dictionary<string, string>>(streamReader.ReadToEnd());
                    return output ?? new Dictionary<string, string>();
                }
            }
            catch (FileNotFoundException)
            {
                using (StreamWriter streamWriter = File.CreateText(PATH_LOGIN))
                {
                    byte[] temp = Encoding.UTF8.GetBytes("passwordhash1");
                }
                return GetLoginInfos();
            }
        }
    }
}
