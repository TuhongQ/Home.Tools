using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home.Tools.Security;

namespace Home.Tools.Test
{
    public class Security_Test
    {
        public void Base64()
        {
            string encode = "Hello World!".Base64Encrypt();
            string decode = encode.Base64Decrypt();

            Console.WriteLine("encode:" + encode);
            Console.WriteLine("decode:"+decode);
        }
    }
}
