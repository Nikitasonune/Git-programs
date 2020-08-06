using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace RegistrationFormCRUD
{
    public class PasswordEncryption
    {
        public static string encryptPassword(string pass)
        {
            string msg = "";
            byte[] encode = new byte[pass.Length];
            encode = Encoding.UTF8.GetBytes(pass);
            msg = Convert.ToBase64String(encode);
            return msg;
        }
    }
}