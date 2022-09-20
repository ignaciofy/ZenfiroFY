using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Logic
{
    public class Encrypt
    {
        public static string _strPassword { get; set; }

        public string strEncrypt(string strPassword)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(strPassword));
                return Convert.ToBase64String(data);
            }
        }
    }
}
