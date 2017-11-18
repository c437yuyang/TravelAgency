using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelAgency.Common.PinyinParse;

namespace PinyinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入中文：");
                string str = Console.ReadLine();
                var pingyins = PinYinConverterHelp.GetTotalPingYin(str);
                Console.WriteLine("全拼音：" + String.Join(",", pingyins.TotalPingYin));
                Console.WriteLine("首音：" + String.Join(",", pingyins.FirstPingYin));
                Console.WriteLine();
            }
        }
    }
}
