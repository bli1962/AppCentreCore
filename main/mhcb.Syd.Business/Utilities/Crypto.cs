using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//using System;
//using System.Data.SqlTypes;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;
//using Microsoft.SqlServer.Server;

namespace mhcb.Syd.Business.Utilities
{
    public class Crypto
    {
        private static readonly byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");

        //[SqlProcedure]
        //public static void EncryptStringAES(SqlString plainText, SqlString sharedKey, out SqlString cipherText)
        //{
        //    cipherText = EncryptStringAES(plainText.ToString(), sharedKey.ToString());
        //}

        public static string EncryptStringAES(string plainText, string sharedKey)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                throw new ArgumentNullException("plainText");
            }

            if (string.IsNullOrEmpty(sharedKey))
            {
                throw new ArgumentNullException("sharedKey");
            }

            string result = null;
            RijndaelManaged rijndaelManaged = null;
            try
            {
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedKey, _salt);
                rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
                rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
                ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                using MemoryStream memoryStream = new MemoryStream();
                using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                {
                    using StreamWriter streamWriter = new StreamWriter(stream);
                    streamWriter.Write(plainText);
                }

                result = Convert.ToBase64String(memoryStream.ToArray());
            }
            finally
            {
                rijndaelManaged?.Clear();
            }

            return result;
        }

        public static string DecryptStringAES(string cipherText, string sharedKey)
        {
            if (string.IsNullOrEmpty(cipherText))
            {
                throw new ArgumentNullException("cipherText");
            }

            if (string.IsNullOrEmpty(sharedKey))
            {
                throw new ArgumentNullException("sharedKey");
            }

            RijndaelManaged rijndaelManaged = null;
            string result = null;
            try
            {
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedKey, _salt);
                rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
                rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
                ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                byte[] buffer = Convert.FromBase64String(cipherText);
                using MemoryStream stream = new MemoryStream(buffer);
                using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
                using StreamReader streamReader = new StreamReader(stream2);
                result = streamReader.ReadToEnd();
            }
            finally
            {
                rijndaelManaged?.Clear();
            }

            return result;
        }
    }
}
