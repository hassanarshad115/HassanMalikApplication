using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HassanMalikApplication
{
   public class EncryptClass
    {
        public static string encrypt(string password)
        {
            //byte[] passwordbyte = Encoding.Unicode.GetBytes(password);

            //string encrypt = Convert.ToBase64String(passwordbyte);
            //return encrypt;

            //ya ye hona chaia don ak he kam krty ha mgr nichy wala strong encrypt ha

            SHA1 sha = new SHA1CryptoServiceProvider();

            byte[] passwordbyte = Encoding.UTF8.GetBytes(password);

        string encryptpassword = Encoding.UTF8.GetString(sha.ComputeHash(passwordbyte));
            return encryptpassword;

        }
    }
}
