using System;
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

        public override void ImportTables()
        {
            using (var cmd = CreateCommand(Properties.Settings.Default.MySQLTables))
            {
                GetConnection().Open();
                cmd.ExecuteNonQuery();
                GetConnection().Close();
            }
        }

        public override string FormatShortDate(DateTime day)
        {
            return day.ToString("yyyy-MM-dd");
        }

        public override string QUERY_SALES_BETWEEN_1{
            get{ return "SELECT * FROM SalesView WHERE day BETWEEN  CAST('@@from' AS DATE) AND CAST('@@to' AS DATE)"; }
        }

        public override string FormatDateTime(DateTime date)
        {
            return date.ToString("YYYY-MM-DD HH:MM:SS");
        }

        public override string QUERY_GET_TRANSACTIONS{
            get { return "SELECT * FROM `TransactionsView` WHERE DATE(`date_created`)=@p1"; }
        }

        public override string QUERY_GENERATE_TRANSACTION_ID {
            get { return "SELECT COUNT(*) FROM `transactions` WHERE DATE(`date_created`)=DATE(NOW())"; }
        }
    }
}
