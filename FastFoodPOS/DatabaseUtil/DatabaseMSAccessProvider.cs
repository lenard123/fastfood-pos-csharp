using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                cmd.Parameters.AddWithValue("p" + i, parameters[i]);
            }
        }
    }
}
