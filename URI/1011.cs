using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1011
    {
        public static void run()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double answer = 4 / 3.0 * 3.14159 * radius * radius * radius;
            Console.WriteLine("VOLUME = " + String.Format("{0:0.000}", answer));
        }
    }
}
