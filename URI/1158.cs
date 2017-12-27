using System;

namespace URI
{
    class _1158
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
