using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1009
    {
        public static void run()
        {
            string name = Console.ReadLine();
            double salary = Convert.ToDouble(Console.ReadLine());
            double sales = Convert.ToDouble(Console.ReadLine());
            double finalSalary = salary + sales * .15;
            Console.WriteLine("TOTAL = R$ " + String.Format("{0:0.00}", finalSalary));
        }
    }
}
