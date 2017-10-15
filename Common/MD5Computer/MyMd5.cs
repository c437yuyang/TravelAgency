using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TravletAgence.Common.MD5Computer
{
    class MyMd5
    {
        public static string GetMD5(string str)
        {
            System.Security.Cryptography.MD5 md5 = MD5.Create();

            byte[] orgBuffer = System.Text.Encoding.Default.GetBytes(str);

            byte[] buffer = md5.ComputeHash(orgBuffer, 0, orgBuffer.Length);

            StringBuilder sb = new StringBuilder();

            foreach (var b in buffer)
            {
                sb.Append(b.ToString("x2"));
            }

            md5.Clear();
            return sb.ToString();
        }

    }
}
