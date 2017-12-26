using System;

namespace URI
{
    class _1151
    {
        public static void run()
        {
            int limit = Convert.ToInt32(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int temp = 0;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            for (int i = 3; i < limit; i++)
            {
                Console.WriteLine("Value of i ->" + i);
                number2 = number1 + number2;
                Console.WriteLine(number2);
                Console.WriteLine();
                Console.WriteLine(number1);
                number1 = number2;

            }
            Console.ReadKey();
        }
    }
}
