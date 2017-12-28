using System;

namespace URI
{
    class _1172
    {
        public static void run()
        {
            int[] input = new int[10];
            for (int i = 0; i < 10; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if (input[i] <= 0)
                {
                    input[i] = 1;
                }
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("X[" + i + "] = " + input[i]);
            }
        }
    }
}
