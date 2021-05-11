using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }

        public void Save()
        {
            using (var cmd = new OleDbCommand("INSERT INTO [products]([name], [category], [price], [is_available], [image]) VALUES (?, ?, ?, ?, ?)", Database.GetConnection()))
            {
                Database.BindParameters(cmd, Name, Category, Price, IsAvailable, "images/default-image.jpg");
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();
            using (var cmd = new OleDbCommand("SELECT * FROM [products] WHERE [is_deleted]=false", Database.GetConnection()))
            {
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(ConvertReaderToProduct(reader));
                    }
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        public static Product ConvertReaderToProduct(OleDbDataReader reader)
        {
            Product result = new Product { 
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Category = reader.GetString(2),
                Price = reader.GetDecimal(3),
                IsAvailable = reader.GetBoolean(4),
                Image = reader.GetString(5),
                IsDeleted = reader.GetBoolean(6)
            };
            return result;
        }
    }
}
