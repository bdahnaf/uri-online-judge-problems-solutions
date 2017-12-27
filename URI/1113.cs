using System;

namespace URI
{
    class _1113
    {
        public static void run()
        {
            while (true)
            {
                String[] input = Console.ReadLine().Split();
                int number1 = Convert.ToInt32(input[0]);
                int number2 = Convert.ToInt32(input[1]);
                if (number1 == number2)
                {
                    return;
                }
                else if (number1 > number2)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}
