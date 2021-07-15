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
        public abstract void BindParameters(DbCommand _cmd, params object[] parameters);
        public abstract bool IsExist(string table, string column, object value);
        public abstract string FormatShortDate(DateTime day);
        public abstract string FormatDateTime(DateTime date);

        public virtual void ImportTables() { }

        public virtual string QUERY_SALES_BETWEEN_1{
            get{ return "SELECT * FROM SalesView WHERE day BETWEEN #@@from# AND #@@to#"; }
        }

        public virtual string QUERY_GET_TRANSACTIONS {
            get { return "SELECT * FROM `TransactionsView` WHERE FIX(`date_created`)=@p1"; }
        }

        public virtual string QUERY_GENERATE_TRANSACTION_ID {
            get { return "SELECT COUNT(*) FROM `transactions` WHERE FIX(`date_created`)=FIX(NOW())"; }
        }
    }
}
