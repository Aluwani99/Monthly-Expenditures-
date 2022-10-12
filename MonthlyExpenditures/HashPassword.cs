using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
/**
 * Author : Aluwani Mahlatse Rambau
 * Student Number : 19010010
 * Programming 2B Assessment
 * Contact no : 0676225015
 * Email : 19010010@rcconnect.co.za
 * 
**/

namespace MonthlyExpenditures
{
    public class HashPassword
    {
        public static string Hash(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encryted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encryted_bytes);

        }
    }
}