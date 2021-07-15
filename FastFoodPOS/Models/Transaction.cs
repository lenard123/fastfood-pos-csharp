using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Transaction
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Cash { get; set; }
        public int CashierId { get; set; }

        private decimal _total = -1;
        public decimal Total { 
            get{
                if (Orders == null && _total > -1)
                    return _total;
                return GetOrders().Sum((Order item) => item.Subtotal);
            } 
        }

        public decimal Change
        {
            get{
                return Cash - Total;
            }
        }

        List<Order> Orders = null;
        User Cashier = null;

        public Transaction(List<Order> Orders, User Cashier)
        {
            this.Orders = Orders;
            this.Cashier = Cashier;
            this.CashierId = Cashier.Id;
        }

        public Transaction(decimal total)
        {
            this._total = total;
        }

        public User GetCashier()
        {
            if (Cashier == null) Cashier = User.Find(CashierId);
            return Cashier;
        }

        public List<Order> GetOrders()
        {
            if (Orders == null) Orders = Order.GetAll(Id);
            return Orders;
        }

        public void Save()
        {
            GenerateId();
            using (var cmd = Database.CreateCommand("INSERT INTO `transactions`(`id`, `user_id`, `cash`) VALUES (@p1, @p2, @p3)"))
            {
                Database.BindParameters(cmd, Id, Cashier.Id, Cash);
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
            Orders.ForEach((Order item) => item.Save(Id));
        }

        public void GenerateId()
        {
            string result = DateTime.Now.ToString("yyyyMMdd");
            //using (var cmd = Database.CreateCommand("SELECT COUNT(*) FROM `transactions` WHERE FIX(`date_created`)=FIX(NOW())"))
            using (var cmd = Database.CreateCommand(Database.GetProvider().QUERY_GENERATE_TRANSACTION_ID))
            {
                Database.GetConnection().Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                Database.GetConnection().Close();
                result += count.ToString("D3");
            }
            Id = result;
        }

        public static List<Transaction> GetTransactions(DateTime date)
        {
            var result = new List<Transaction>();
            //using (var cmd = Database.CreateCommand("SELECT * FROM `TransactionsView` WHERE FIX(`date_created`)=@p1"))
            using (var cmd = Database.CreateCommand(Database.GetProvider().QUERY_GET_TRANSACTIONS))
            {
                Database.BindParameters(cmd, Database.GetProvider().FormatShortDate(date));
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read()) result.Add(ConvertReaderToTransaction(reader));
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        public static List<Transaction> GetAllTransactions()
        {
            var result = new List<Transaction>();
            using (var cmd = Database.CreateCommand("SELECT * FROM `TransactionsView`"))
            {
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) result.Add(ConvertReaderToTransaction(reader));
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        private static Transaction ConvertReaderToTransaction(DbDataReader reader)
        {
            return new Transaction(reader.GetDecimal(4))
            {
                Id = reader.GetString(0),
                CashierId = reader.GetInt16(1),
                Date = reader.GetDateTime(2),
                Cash = reader.GetDecimal(3)
            };
        }
    }
}
