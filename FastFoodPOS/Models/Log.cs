using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Log
    {
        User user;
        public int user_id { get; set; }
        public DateTime date_created{ get; set; }
        public string activity { get; set; }

        public Log(User user)
        {
            this.user = user;
        }

        public User GetUser()
        {
            if (user == null)
                user = User.Find(user_id);
            return user;
        }

        public static void AddLog(string activity)
        {
            if (User.CurrentUser.Role == "Administrator") return;
            using (var cmd = Database.CreateCommand("INSERT INTO `logs`(`user_id`, `activity`, `date_created`) VALUES (?,?,?)"))
            {
                Database.BindParameters(cmd, User.CurrentUser.Id, activity, Database.GetProvider().FormatDateTime(DateTime.Now));
                Database.GetConnection().Open();
                cmd.ExecuteNonQuery();
                Database.GetConnection().Close();
            }
        }

        public static List<Log> GetLogs(User user)
        {
            var result = new List<Log>();
            using (var cmd = Database.CreateCommand("SELECT `activity`, `date_created` FROM `logs` WHERE `user_id`=? ORDER BY `date_created` DESC"))
            {
                Database.BindParameters(cmd, user.Id);
                Database.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Log(user) { 
                            activity = reader.GetString(0), 
                            date_created = reader.GetDateTime(1) 
                        });
                    }
                }
                Database.GetConnection().Close();
            }
            return result;
        }
    }
}
