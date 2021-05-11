using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS
{
    class Util
    {
        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetHashSHA256(string text)
        {
            SHA256Managed hashstring = new SHA256Managed();
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            byte[] hash = hashstring.ComputeHash(bytes);
            string result = string.Empty;
            foreach (byte x in hash)
            {
                result += String.Format("{0:x2}", x);
            }
            return result;
        }

        public static bool VerifyHash(string text, string hashedtext)
        {
            return GetHashSHA256(text).Equals(hashedtext);
        }
    }
}
