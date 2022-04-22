using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = Convert.ToDateTime("2016-1-1");
            DateTime dt2 = Convert.ToDateTime("2022-2-20");
            TimeSpan Span = dt2.Subtract(dt1);
            int totalDay = Span.Days + 1;
            int res = totalDay % 5;
            if (res < 3)
                Console.WriteLine("他在打鱼！");
            else
                Console.WriteLine("他在晒网！");
            Console.ReadKey();
        }
    }
}
