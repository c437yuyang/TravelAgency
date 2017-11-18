using System;
using System.Text;

namespace TravelAgency.Common
{
    public class RngWord
    {
        /// <summary>
        /// 生成电子机票报表里面的随机航空记录编号
        /// </summary>
        /// <returns></returns>
        public static string GetRandomWord()
        {
            Random rng  = new Random();
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {

                sb.Append((char) rng.Next('A', 'Z' + 1));
            }
            sb.Append(rng.Next(10).ToString());
            sb.Append((char)rng.Next('A', 'Z' + 1));
            return sb.ToString();
        } 
    }
}