using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.DatabaseUtil
{
    class Database
    {
        private static DatabaseProvider Provider = null;

        public static DbConnection GetConnection()
        {
            return GetProvider().GetConnection();
        }


        public static DbCommand CreateCommand(string query)
        {
            return GetProvider().CreateCommand(query);
        }

        public static DatabaseProvider GetProvider()
        {
            if (Provider == null)
            {
                if (Util.GetConfig("DbProvider") == "MSACCESS")
                {
                    Provider = new DatabaseMSAccessProvider();
                }
                else if (Util.GetConfig("DbProvider") == "MYSQL")
                {
                    Provider = new DatabaseMySQLProvider();
                }
            }
            return Provider;
        }
        
        public static void BindParameters(DbCommand cmd, params object[] parameters)
        {
            GetProvider().BindParameters(cmd, parameters);
        }

        public static bool IsExist(string table, string column, object value)
        {
            return GetProvider().IsExist(table, column, value);
        }

        public static bool IsValidConnection()
        {
            try
            {
                GetConnection().Open();
                GetConnection().Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
