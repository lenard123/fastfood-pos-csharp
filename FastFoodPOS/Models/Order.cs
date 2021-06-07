using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string TransactionId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal Subtotal {
            get{
                return Quantity * Price;
            }
        }

        Product product = null;

        public Order(Product product)
        {
            this.product = product;
            this.ProductId = product.Id;
            this.Quantity = 1;
            this.Price = product.Price;
        }

        public Order()
        {
            // TODO: Complete member initialization
        }

        public void Save(string transaction_id)
        {
            using (var cmd = Database.CreateCommand("INSERT INTO `orders`(`product_id`, `transaction_id`, `quantity`, `price`) VALUES (@p1, @p2, @p3, @p4)"))
            {
                Database.BindParameters(cmd, ProductId, transaction_id, Quantity, Price);
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }
        
        public Product GetProduct()
        {
            if (product == null)
            {
                product = Product.Find(Id);
            }
            return product;
        }

        public static List<Order> GetAll()
        {
            var result = new List<Order>();
            using (var cmd = Database.CreateCommand("SELECT * FROM `orders`"))
            {
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        result.Add(ConvertReaderToOrder(reader));
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        public static List<Order> GetAll(string id)
        {
            var result = new List<Order>();
            using (var cmd = Database.CreateCommand("SELECT * FROM `orders` WHERE `transaction_id`=@p1"))
            {
                Database.BindParameters(cmd, id);
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) 
                        result.Add(ConvertReaderToOrder(reader));
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        private static Order ConvertReaderToOrder(DbDataReader reader)
        {
            var result = new Order
            {
                Id = reader.GetInt32(0),
                ProductId = reader.GetInt16(1),
                TransactionId = reader.GetString(2),
                Quantity = reader.GetInt16(3),
                Price = reader.GetDecimal(4)
            };
            return result;
        }

    }
}
