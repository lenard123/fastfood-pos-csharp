using FastFoodPOS.DatabaseUtil;
using FastFoodPOS.ErrorHandler;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class User
    {
        public int Id{get;set;}
        public string Email{get;set;}
        public string Fullname{get;set;}
        public string Role{get;set;}
        public string Password{get;set;}
        public string Image { get; set; }
        public bool IsDeleted{get;set;}
        public string newImage { get; set; }

        public static User CurrentUser;
        public static readonly string DEFAULT_IMAGE_PATH = "Resources\\user_default.png";

        public void Save()
        {
            if (Find(Email) != null) throw new Level1Exception("Email already exists");
            using (var cmd = Database.CreateCommand("INSERT INTO `users`(`fullname`, `email`, `role`, `password`, `image`) VALUES (@p1, @p2, @p3, @p4, @p5)"))
            {
                Database.BindParameters(cmd, Fullname, Email, Role, Password, GetUploadedImagePath());
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        public User Clone()
        {
            return new User
            {
                Id = this.Id,
                Email = this.Email,
                Fullname = this.Fullname,
                Role = this.Role,
                Password = this.Password,
                Image = this.Image,
                IsDeleted = this.IsDeleted
            };
        }

        public void Recover()
        {
            IsDeleted = false;
            Update();
        }

        public void Remove()
        {
            IsDeleted = true;
            Update();
        }

        public void Update()
        {
            string uploaded_image_path = GetUploadedImagePath(newImage);
            using (var cmd = Database.CreateCommand("UPDATE `users` SET `fullname`=@p1, `email`=@p2, `role`=@p3, `password`=@p4, `image`=@p5, `is_deleted`=@p6 WHERE `id`=@p7"))
            {
                Database.BindParameters(cmd, Fullname, Email, Role, Password, uploaded_image_path, IsDeleted, Id);
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
            Image = uploaded_image_path;
        }

        private string GetUploadedImagePath(string source)
        {
            string fileName = Image;

            if (source == null || source.Length == 0 || source.Equals(Image)) 
                return Image;//Previous Page
            if (source.Equals(DEFAULT_IMAGE_PATH)) 
                return DEFAULT_IMAGE_PATH;//Default Image
            if (Image.Equals(DEFAULT_IMAGE_PATH)) 
                fileName = "user-" + DateTime.Now.Ticks + ".jpg";//New Image

            return Util.CopyImage(source, fileName);
        }

        private string GetUploadedImagePath()
        {
            string filename = "user-" + DateTime.Now.Ticks + ".jpg";
            if (Image == null || DEFAULT_IMAGE_PATH.Equals(Image))
                return DEFAULT_IMAGE_PATH;
            return Util.CopyImage(Image, filename);
        }

        public static List<User> GetAllDeleted()
        {
            var result = new List<User>();
            using (var cmd = Database.CreateCommand("SELECT * FROM `users` WHERE `is_deleted`=true"))
            {
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(ConvertReaderToUser(reader));
                    }
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        private static User Find(string email)
        {
            User result = null;
            using (var cmd = Database.CreateCommand("SELECT * FROM `users` WHERE `email` = @p1"))
            {
                Database.BindParameters(cmd, email);
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) result = ConvertReaderToUser(reader);
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        public static bool HasAdminUser()
        {
            bool result = false;
            using (var cmd = Database.CreateCommand("SELECT COUNT(*) FROM `users` WHERE `role`='Administrator'"))
            {
                Database.GetConnection().Open();
                var x = Convert.ToInt32(cmd.ExecuteScalar());
                result = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                Database.GetConnection().Close();
            }
            return result;
        }

        public static User Find(int id)
        {
            User result = null;
            using (var cmd = Database.CreateCommand("SELECT * FROM `users` WHERE id = @p1"))
            {
                Database.BindParameters(cmd, id);
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) result = ConvertReaderToUser(reader);
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        public static bool IsAdmin()
        {
            return CurrentUser != null && CurrentUser.Role == "Administrator";
        }

        public static User Login(string email, string password)
        {
            User user = Find(email);

            //Check if the user exists
            if (user == null || user.IsDeleted)
                throw new Level1Exception("Can not find email in the database");
            
            //Verify password
            if (!Util.VerifyHash(password, user.Password))
                throw new Level1Exception("Wrong Password");

            CurrentUser = user;

            return user;
        }

        public static List<User> GetAll(bool include_deleted)
        {
            List<User> result = new List<User>();
            string query = "SELECT * FROM `users`";
            if (!include_deleted) query += " WHERE `is_deleted` = false";
            using (var cmd = Database.CreateCommand(query))
            {
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) result.Add(ConvertReaderToUser(reader));
                }
                Database.GetConnection().Close();
            }
            return result;
        }

        public static List<User> GetAll()
        {
            return GetAll(false);
        }

        private static User ConvertReaderToUser(DbDataReader reader)
        {
            User result = new User{
                Id = reader.GetInt32(0),
                Fullname = reader.GetString(1),
                Email = reader.GetString(2),
                Role = reader.GetString(3),
                Password = reader.GetString(4),
                Image = reader.GetString(5),
                IsDeleted = reader.GetBoolean(6)
            };
            return result;
        }
    }
}
