using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Transaction
    {
        public static DateTime today;
        public int Id{
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public float Total
        {
            get;
            set;
        }

        public static List<Transaction> fakeData()
        {
            today = new DateTime();
            Console.WriteLine(today.ToString());
            List<Transaction> result = new List<Transaction>();
            result.Add(new Transaction { Id = 1, Date = today, Total = 100 });
            result.Add(new Transaction { Id = 2, Date = today, Total = 200 });
            result.Add(new Transaction { Id = 3, Date = today, Total = 300 });
            result.Add(new Transaction { Id = 4, Date = today, Total = 400 });
            result.Add(new Transaction { Id = 5, Date = today, Total = 600 });
            return result;
        }
    }
}
