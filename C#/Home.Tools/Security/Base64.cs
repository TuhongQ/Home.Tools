using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Tools.Security
{
    public static class Base64
    {
        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <returns>加密后的数据</returns>
        public static string Base64Encrypt(this string str)
        {
            byte[] encbuff = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="str">需要解密的字符串</param>
        /// <returns>解密后的数据</returns>
        public static string Base64Decrypt(this string str)
        {
            try
            {
                byte[] decbuff = Convert.FromBase64String(str);
                return Encoding.UTF8.GetString(decbuff);
            }
            catch
            {
                return str;
            }
        }

    }
}
