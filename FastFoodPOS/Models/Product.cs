
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

        public static readonly string DEFAULT_IMAGE_PATH = "Resources\\product_default.png";

        public void Save()
        {
            using (var cmd = new OleDbCommand("INSERT INTO [products]([name], [category], [price], [is_available], [image]) VALUES (?, ?, ?, ?, ?)", Database.GetConnection()))
            {
                Database.BindParameters(cmd, Name, Category, Price, IsAvailable, GetUploadedImagePath());
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        public void ToggleAvailability()
        {
            Update(
                Name,
                Category,
                Price,
                Image,
                !IsAvailable
                );
        }

        public void Remove()
        {
            Update(Name, Category, Price, Image, IsAvailable, true);
        }

        public void Update(string newName, string newCategory, decimal newPrice, string newImage)
        {
            Update(newName, newCategory, newPrice, newImage, IsAvailable, IsDeleted);
        }

        public void Update(string newName, string newCategory, decimal newPrice, string newImage, bool isAvailable)
        {
            Update(newName, newCategory, newPrice, newImage, isAvailable, IsDeleted);
        }

        public void Update(string newName, string newCategory, decimal newPrice, string newImage, bool isAvailable, bool isDeleted)
        {
            string uploadedImage = GetUploadedImagePath(newImage);
            using (var cmd = new OleDbCommand("UPDATE [products] SET [name]=?, [category]=?, [price]=?, [image]=?, [is_available]=?, [is_deleted]=? WHERE [id]=?", Database.GetConnection()))
            {
                Database.BindParameters(cmd, newName, newCategory, newPrice, uploadedImage, isAvailable, isDeleted, Id);
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
            Name = newName;
            Category = newCategory;
            Price = newPrice;
            this.IsAvailable = isAvailable;
            this.IsDeleted = isDeleted;
            Image = uploadedImage;

        }

        private string GetUploadedImagePath(string source)
        {
            string filename = Image;
            if (source.Equals(DEFAULT_IMAGE_PATH)) return DEFAULT_IMAGE_PATH;
            if (source.Equals(Image)) return Image;

            if (Image.Equals(DEFAULT_IMAGE_PATH))
                filename = "product-"+ DateTime.Now.Ticks+".jpg";

            return Util.CopyImage(source, filename);
        }
        
        private string GetUploadedImagePath()
        {
            string filename = "product-" + DateTime.Now.Ticks + ".jpg";
            if( DEFAULT_IMAGE_PATH.Equals(Image))
                return DEFAULT_IMAGE_PATH;
            return Util.CopyImage(Image, filename);
        }

        public static Product Find(int id)
        {
            Product result = null;
            using (var cmd = new OleDbCommand("SELECT * FROM [products] WHERE [id]=?", Database.GetConnection()))
            {
                Database.BindParameters(cmd, id);
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) result = ConvertReaderToProduct(reader);
                }
                Database.GetConnection().Close();
            }
            return result;
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
