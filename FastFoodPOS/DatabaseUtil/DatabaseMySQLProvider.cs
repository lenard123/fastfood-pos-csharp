using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace FastFoodPOS.DatabaseUtil
{
    class DatabaseMySQLProvider : DatabaseProvider
    {

        private MySqlConnection connection = null;

        public override DbConnection GetConnection()
        {
            if (connection == null)
            {
                string host = Util.GetConfig("host");
                string user = Util.GetConfig("user");
                string pass = Util.GetConfig("pass");
                string db = Util.GetConfig("db");
                string connection_strng = "SERVER=" + host + ";DATABASE=" + db + ";UID=" + user + ";PASSWORD=" + pass + ";";
                connection = new MySqlConnection(connection_strng);
            }
            return connection;
        }

        public override DbCommand CreateCommand(string query)
        {
            return new MySqlCommand(query, GetConnection() as MySqlConnection);
        }

        public override void BindParameters(DbCommand _cmd, params object[] parameters)
        {
            MySqlCommand cmd = _cmd as MySqlCommand;
            cmd.Parameters.Clear();
            cmd.Parameters.Clear();
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue("@p" + (i+1), parameters[i]);
            }
        }

        public override bool IsExist(string table, string column, object value)
        {
            bool result = false;
            using (var cmd = CreateCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = ?"))
            {
                BindParameters(cmd, value);
                GetConnection().Open();
                result = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
                GetConnection().Close();
            }
            return result;
        }

        public override string FormatShortDate(DateTime day)
        {
            return day.ToString("yyyy-MM-dd");
        }

        public override string QUERY_SALES_BETWEEN_1{
            get{ return "SELECT * FROM SalesView WHERE day BETWEEN  CAST('@@from' AS DATE) AND CAST('@@to' AS DATE)"; }
        }
    }
}
