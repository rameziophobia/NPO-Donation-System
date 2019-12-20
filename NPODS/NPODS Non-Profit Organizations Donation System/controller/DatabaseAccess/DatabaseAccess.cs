using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public abstract class DatabaseAccess
    {
        private static readonly DatabaseAccess instance = new FileDatabaseAccess();

        protected DatabaseAccess() { }

        public static DatabaseAccess getInstance()
        {
            return instance;
        }

        public abstract Dictionary<string, string> GetLoginInfos();
    }
}
