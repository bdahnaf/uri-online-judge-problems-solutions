using System;

namespace URI
{
    class _1173
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[10];
            input[0] = number;
            for (int i = 1; i < 10; i++)
            {
                input[i] = input[i-1] * 2;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("N[" + i + "] = " + input[i]);
            }
        }
    }
}
