using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1020
    {
        public static void run()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            int year = age / 365;
            Console.WriteLine(year + " ano(s)");
            int remainder = age % 365;
            int month = remainder / 30;
            Console.WriteLine(month + " mes(es)");
            int days = remainder - month * 30;
            Console.WriteLine(days + " dia(s)");

        }
    }
}
