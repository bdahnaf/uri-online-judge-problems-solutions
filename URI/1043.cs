using System;

namespace URI
{
    class _1043
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            double n1 = Convert.ToDouble(input[0]);
            double n2 = Convert.ToDouble(input[1]);
            double n3 = Convert.ToDouble(input[2]);
            if(n1+n2 > n3 && n2+n3 > n1 && n3+n1 > n2)
            {
                Console.WriteLine("Perimetro = " + String.Format("{0:0.0}", n1 + n2 + n3));
            }
            else
            {
                Console.WriteLine("Area = " + String.Format("{0:0.0}", ((n1 + n2) / 2) * n3));
            }
        }
    }
}
