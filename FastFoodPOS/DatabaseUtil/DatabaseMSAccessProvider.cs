using System;
using System.Data.Common;
using System.Data.OleDb;

namespace FastFoodPOS.DatabaseUtil
{
    class DatabaseMSAccessProvider : DatabaseProvider
    {
        private OleDbConnection connection = null;
        public override DbConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new OleDbConnection(Util.GetConfig("ConnectionString"));
            }
            return connection;
        }

        public override DbCommand CreateCommand(string query)
        {
            return new OleDbCommand(query, GetConnection() as OleDbConnection);
        }

        public override void BindParameters(DbCommand _cmd, params object[] parameters)
        {
            OleDbCommand cmd = _cmd as OleDbCommand;
            cmd.Parameters.Clear();
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue("@p" + (i+1), parameters[i]);
            }
        }

        public override bool IsExist(string table, string column, object value)
        {
            bool result = false;
            using(var cmd = CreateCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = ?"))
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
            return day.ToShortDateString();
        }


        public override string FormatDateTime(DateTime date)
        {
            return date.ToString();
        }
    }
}
