using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
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
            using (var cmd = new OleDbCommand("INSERT INTO [orders]([product_id], [transaction_id], [quantity], [price]) VALUES (?, ?, ?, ?)", Database.GetConnection()))
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

        public static List<Order> GetAll(string id)
        {
            var result = new List<Order>();
            using (var cmd = new OleDbCommand("SELECT * FROM [orders] WHERE [transaction_id]=?", Database.GetConnection()))
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

        private static Order ConvertReaderToOrder(OleDbDataReader reader)
        {
            var result = new Order
            {
                Id = reader.GetInt32(0),
                ProductId = reader.GetInt32(1),
                Quantity = reader.GetInt32(3),
                Price = reader.GetDecimal(4)
            };
            return result;
        }

    }
}
