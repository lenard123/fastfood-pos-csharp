using FastFoodPOS.DatabaseUtil;
using FastFoodPOS.ErrorHandler;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

        public static User CurrentUser;
        public static readonly string DEFAULT_IMAGE_PATH = "Resources\\user_default.png";

        public void Save()
        {
            if (Find(Email) != null) throw new Level1Exception("Email already exists");
            using (var cmd = new OleDbCommand("INSERT INTO [users]([fullname], [email], [role], [password], [image]) VALUES (?, ?, ?, ?, ?)", Database.GetConnection()))
            {
                Database.BindParameters(cmd, Fullname, Email, Role, Password, GetUploadedImagePath());
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        private string GetUploadedImagePath()
        {
            string filename = "user-" + DateTime.Now.Ticks + ".jpg";
            if (DEFAULT_IMAGE_PATH.Equals(Image))
                return DEFAULT_IMAGE_PATH;
            return Util.CopyImage(Image, filename);
        }

        private static User Find(string email)
        {
            User result = null;
            using (var cmd = new OleDbCommand("SELECT * FROM [users] WHERE [email] = ?", Database.GetConnection()))
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

        public static User Find(int id)
        {
            User result = null;
            using (var cmd = new OleDbCommand("SELECT * FROM [users] WHERE [id] = ?", Database.GetConnection()))
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
            string query = "SELECT * FROM [users]";
            if (!include_deleted) query += " WHERE [is_deleted] = false";
            using (var cmd = new OleDbCommand(query, Database.GetConnection()))
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

        private static User ConvertReaderToUser(OleDbDataReader reader)
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
