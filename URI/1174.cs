using System;

namespace URI
{
    class _1174
    {
        public static void run()
        {
            double[] input = new double[10];
            for (int i = 0; i < 10; i++)
            {
                input[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if(input[i] <= 10)
                {
                    Console.WriteLine("A[" + i + "] = " + input[i]);
                }
            }
        }
    }
}
