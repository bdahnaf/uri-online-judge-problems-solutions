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
            int fibonacci = 0;
            int counter = 3;
            Console.Write(number1 + " " + number2);
            while (counter <= limit)
            {
                fibonacci = number1 + number2;
                Console.Write(" " + fibonacci);
                number1 = number2;
                number2 = fibonacci;
                counter++;
            }
            Console.WriteLine();
        }
    }
}