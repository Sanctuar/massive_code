using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace massive_code
{
    public class cl_Cryptography
    {
        public String ps_MD5(String ls_Data)
        {
            MD5 lmd5 = new MD5CryptoServiceProvider();
            byte[] checkSum = lmd5.ComputeHash(Encoding.UTF8.GetBytes(ls_Data));
            return BitConverter.ToString(checkSum).Replace("-", String.Empty);
        }
        public String ps_UID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}