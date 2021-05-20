using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.DatabaseUtil
{
    abstract class DatabaseProvider
    {
        public abstract DbConnection GetConnection();
        public abstract DbCommand CreateCommand(string query);
        public abstract void BindParameters(DbCommand cmd, params object[] parameters);
    }
}
