using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
        public decimal Total { 
            get{
                return Orders.Sum((Order item) => item.Subtotal);
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
            Orders.ForEach((Order item) => item.Save(Id));
            using (var cmd = new OleDbCommand("INSERT INTO [transactions]([id], [user_id], [cash], [date_created]) VALUES (?, ?, ?, ?)", Database.GetConnection()))
            {
                Database.BindParameters(cmd, Id, Cashier.Id, Cash, Date.ToString());
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        public void GenerateId()
        {
            string result = DateTime.Now.ToString("yyyyMMdd");
            using (var cmd = new OleDbCommand("SELECT COUNT(*) FROM [transactions] WHERE FIX([date_created])=?", Database.GetConnection()))
            {
                Database.BindParameters(cmd, DateTime.Now.ToShortDateString());
                Database.GetConnection().Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                Database.GetConnection().Close();
                result += count.ToString("D3");
            }
            Id = result;
        }

        public static DateTime today;

        public static List<Transaction> fakeData()
        {
            today = new DateTime();
            Console.WriteLine(today.ToString());
            List<Transaction> result = new List<Transaction>();
            return result;
        }
    }
}
