using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Study1.Common
{
    public class MD5Provider
    {
        public static string GetMD5(string str)
        {
            MD5 md5 =  MD5.Create();
            byte[] pws = md5.ComputeHash(Encoding.UTF8.GetBytes(str));//把字符串改成字节数组。
            string pwd = "";
            foreach(var item in pws)
            {
                pwd = item.ToString();
            }
            return pwd;
        }
    }
}
