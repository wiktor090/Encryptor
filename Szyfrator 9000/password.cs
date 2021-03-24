using System;
using System.Security.Cryptography;
using System.Text;

namespace Szyfrator_9000
{
    public class password
    {
        private static string pwd = "";

        private static SHA256 sha256Hash = SHA256.Create();

        public static bool checkPassword(string pass,string hash)
        {
            return VerifyHash(sha256Hash, pass, hash);
        }

        public static bool checkPassword(string pass) 
        {
            return VerifyHash(sha256Hash, pass, pwd);
        }

        public static void sethash(string pass)
        {
            pwd = GetHash(sha256Hash, pass);
        }

        public static string getPassword()
        {
            return pwd;
        }

        public static bool setPassword(string pass)
        {
            pwd = pass;
            return true;
        }
        public int id 
        {
            get;
            set;
        }
        
        public string Name
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }


        public string Email
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            
            var sBuilder = new StringBuilder();

            
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            
            return sBuilder.ToString();
        }

       
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            
            var hashOfInput = GetHash(hashAlgorithm, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
