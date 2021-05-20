using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Database
    {

        private static OleDbConnection Connection = null;

        public static OleDbConnection GetConnection()
        {
            if (Connection == null)
            {
                Connection = new OleDbConnection(Util.GetConfig("ConnectionString"));
            }
            return Connection;
        }

        public static void BindParameters(OleDbCommand cmd, params object[] parameters)
        {
            cmd.Parameters.Clear();
            for(int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue("p" + i, parameters[i]);
            }
        }

        public static bool IsExist(string table, string column, object value)
        {
            bool result = false;
            using (var cmd = new OleDbCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = ?", GetConnection()))
            {
                BindParameters(cmd, value);
                GetConnection().Open();
                result = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
                GetConnection().Close();
            }
            return result;
        }
    }
}
