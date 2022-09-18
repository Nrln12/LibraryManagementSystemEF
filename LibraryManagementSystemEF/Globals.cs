using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LibraryManagementSystemEF
{
    class Globals
    {
        public static int userID;
        public static string userEmail;
        public static int statusBook;
        public static string GetHashCodePsw(byte[] value)
        {
            var psw= Convert.ToBase64String(MD5.Create().ComputeHash(value));
            return psw.ToString();
        }
    }
}
