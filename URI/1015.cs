using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1015
    {
        public static void run()
        {
            String[] input1 = Console.ReadLine().Split();
            double x1 = Convert.ToDouble(input1[0]);
            double y1 = Convert.ToDouble(input1[1]);
            String[] input2 = Console.ReadLine().Split();
            double x2 = Convert.ToDouble(input2[0]);
            double y2 = Convert.ToDouble(input2[1]);
            double x = x2 - x1;
            double y = y2 - y1;
            double distance = (x * x) + (y * y);
            distance = Math.Sqrt(distance);
            Console.WriteLine(String.Format("{0:0.0000}", distance));
        }
    }
}
