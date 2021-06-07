
using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

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
        public string newImage { get; set; }

        public static readonly string DEFAULT_IMAGE_PATH = "Resources\\product_default.png";

        public Product Clone()
        {
            return new Product
            {
                Id = this.Id,
                Name = this.Name,
                Category = this.Category,
                Price = this.Price,
                IsAvailable = this.IsAvailable,
                Image = this.Image,
                IsDeleted = this.IsDeleted,
                newImage = this.newImage
            };
        }

        public void Copy(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Category = product.Category;
            this.Price = product.Price;
            this.IsAvailable = product.IsAvailable;
            this.Image = product.Image;
            this.IsDeleted = product.IsDeleted;
            this.newImage = product.newImage;
        }

        public void Save()
        {
            using (var cmd = Database.CreateCommand("INSERT INTO `products`(`name`, `category`, `price`, `is_available`, `image`) VALUES (@p1, @p2, @p3, @p4, @p5)"))
            {
                Database.BindParameters(cmd, Name, Category, Price, IsAvailable, GetUploadedImagePath());
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        public bool ContainsOr(string query)
        {
            query = query.ToUpper();
            string[] words = query.Split(' ');
            string product = (Name + Category).ToUpper();
            return words.Any((word) => product.Contains(word));
        }

        public bool ContainsAnd(string query)
        {
            query = query.ToUpper();
            string[] words = query.Split(' ');
            string product = (Name + Category).ToUpper();
            return words.All((word) => product.Contains(word));
        }

        public void ToggleAvailability()
        {
            this.IsAvailable = !this.IsAvailable;
            Update();
        }


        public void Recover()
        {
            this.IsDeleted = false;
            this.IsAvailable = false;
            Update();
        }

        public void Remove()
        {
            this.IsDeleted = true;
            Update();
        }

        public static List<Product> GetAllDeleted()
        {
            var result = new List<Product>();
            using (var cmd = Database.CreateCommand("SELECT * FROM `products` WHERE is_deleted=true"))
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

        public void Update()
        {
            string uploadedImage = GetUploadedImagePath(newImage);
            using (var cmd = Database.CreateCommand("UPDATE `products` SET `name`=@p1, `category`=@p2, `price`=@p3, `image`=@p4, `is_available`=@p5, `is_deleted`=@p6 WHERE `id`=@p7"))
            {
                Database.BindParameters(cmd, Name, Category, Price, uploadedImage, IsAvailable, IsDeleted, Id);
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
            Image = uploadedImage;
            newImage = "";
        }

        private string GetUploadedImagePath(string source)
        {
            string fileName = Image;
            if (source == null || source.Length == 0 || source.Equals(Image)) return Image;
            if (source.Equals(DEFAULT_IMAGE_PATH)) return DEFAULT_IMAGE_PATH;
            if (Image.Equals(DEFAULT_IMAGE_PATH)) fileName = "product-" + DateTime.Now.Ticks + ".jpg";
            return Util.CopyImage(source, fileName);
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
            using (var cmd = Database.CreateCommand("SELECT * FROM `products` WHERE `id`=@p1"))
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
            using (var cmd = Database.CreateCommand("SELECT * FROM `products` WHERE `is_deleted`=false"))
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

        public static Product ConvertReaderToProduct(DbDataReader reader)
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
