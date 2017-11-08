using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeFormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy/MM/dd";
            DateTime dt = Convert.ToDateTime("2017-05-12", dtFormat);
            Console.WriteLine(dt.ToString());


            dt = DateTime.Parse("2017-05-12");
            Console.WriteLine(dt.ToString());

            Console.WriteLine(DateTime.Now.Day.ToString());
            Console.Read();

        }
    }
}
