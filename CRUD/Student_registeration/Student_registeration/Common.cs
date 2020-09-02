using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Student_registeration
{
    public class Common
    {
        public static string Encryptdata(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
    }
}