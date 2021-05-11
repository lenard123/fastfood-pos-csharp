using System;
using System.Collections.Generic;
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
    }
}
