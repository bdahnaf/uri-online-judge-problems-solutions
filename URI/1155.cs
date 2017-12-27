using System;

namespace URI
{
    class _1155
    {
        public static void run()
        {
            double sequence = 0;
            for(double i = 1; i <= 100; i++)
            {
                sequence = sequence + (1 / i);
            }
            Console.WriteLine(String.Format("{0:0.00}", sequence));
        }
    }
}
