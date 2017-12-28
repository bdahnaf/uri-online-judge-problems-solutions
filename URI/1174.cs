using System;

namespace URI
{
    class _1174
    {
        public static void run()
        {
            double[] input = new double[100];
            for (int i = 0; i < 100; i++)
            {
                input[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 100; i++)
            {
                if(input[i] <= 10)
                {
                    Console.WriteLine("A[" + i + "] = " + String.Format("{0:0.0}", input[i]));
                }
            }
        }
    }
}
