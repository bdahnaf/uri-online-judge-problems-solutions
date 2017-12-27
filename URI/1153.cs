using System;

namespace URI
{
    class _1153
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = i * factorial;
            }
            Console.WriteLine(factorial);
        }
    }
}
