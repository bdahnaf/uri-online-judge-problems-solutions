using System;

namespace URI
{
    class _1164
    {
        public static void run()
        {
            int counter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for(int j = 1; j < number; j++)
                {
                    if(number % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == number)
                {
                    Console.WriteLine(number + " eh perfeito");
                }
                else
                {
                    Console.WriteLine(number + " nao eh perfeito");
                }
            }
        }
    }
}
