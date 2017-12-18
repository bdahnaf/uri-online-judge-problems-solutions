using System;

namespace URI
{
    class _1115
    {
        public static void run()
        {
            int number1, number2;
            while (true)
            {
                String[] input = Console.ReadLine().Split();
                number1 = Convert.ToInt32(input[0]);
                number2 = Convert.ToInt32(input[1]);
                if (number2 > 0 && number1 > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (number1 > 0 && number2 < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (number1 < 0 && number2 < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (number1 < 0 && number2 > 0)
                {
                    Console.WriteLine("segundo");
                }
                else return;
            }
        }
    }
}
