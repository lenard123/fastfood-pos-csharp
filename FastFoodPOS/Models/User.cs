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

        private static User GetUser(string email)
        {
            User result = null;
            using(var cmd = new OleDbCommand("SELECT * FROM [users] WHERE [email] = ?", Database.GetConnection()))
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

        public static User Login(string email, string password)
        {
            User user = GetUser(email);

            //Check if the user exists
            if (user == null || user.IsDeleted)
                throw new Level1Exception("Can not find email in the database");
            
            //Verify password
            if (!Util.VerifyHash(password, user.Password))
                throw new Level1Exception("Wrong Password");

            return user;
        }

        public static List<User> fakeData()
        {
            List<User> result = new List<User>();
            for (int i = 1; i < 10; i++)
            {
                result.Add(new User { Id = i, Fullname = "John Doe", Role = "Cashier", Email = "john@pos.com"});
            }
            return result;
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
