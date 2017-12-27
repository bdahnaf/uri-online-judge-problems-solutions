using System;

namespace URI
{
    class _1143
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i + " " + i*i + " " + i*i*i);
            }
        }
    }
}
