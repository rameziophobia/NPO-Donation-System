using Newtonsoft.Json;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public class FileDatabaseAccess : DatabaseAccess
    {
        private const string PATH_FOLDER_DATA = "data/";
        private const string PATH_FILE_ORG = PATH_FOLDER_DATA + "Organizations.json";
        private const string PATH_FILE_DONOR = PATH_FOLDER_DATA + "Donors.json";
        private const string PATH_FILE_LOGINS = PATH_FOLDER_DATA + "logins.json";

        private static readonly DatabaseAccess instance = new FileDatabaseAccess();

        public static DatabaseAccess getInstance()
        {
            return instance;
        }

        private FileDatabaseAccess()
        {
            
        }

        protected override List<LoginInfo> getLoginInfosFromDb()
        {
            return readJson<List<LoginInfo>>(PATH_FILE_LOGINS);
        }

        protected override List<Organization> loadOrganizationsFromDb()
        {
            return readJson<List<Organization>>(PATH_FILE_ORG);
        }

        protected override void saveOrganizationsToDb(List<Organization> organizations)
        {
            writeJson(PATH_FILE_ORG, organizations);
        }

        protected override void saveDonorsToDb(List<Donor> donors)
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

        protected override List<Donor> loadDonorsFromDb()
        {
            return readJson<List<Donor>>(PATH_FILE_DONOR);
        }

        protected override void saveLoginsToDb(List<LoginInfo> infos)
        {
            writeJson(PATH_FILE_LOGINS, infos);
        }
    }
}