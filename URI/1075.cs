using System;

namespace URI
{
    class _1075
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int output = 2 % number;
            for(int i = 1; i < 10000; i++)
            {
                if (i % number == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
