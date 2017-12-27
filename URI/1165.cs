using System;

namespace URI
{
    class _1165
    {
        public static void run()
        {
            int counter = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < counter; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == 0 || number == 1 || number == 4)
                {
                    Console.WriteLine(number + " nao eh primo");
                }
                else if(number == 2 || number == 3)
                {
                    Console.WriteLine(number + " eh primo");
                }
                else
                {
                    for (int j = 3; j < number; j++)
                    {
                        if (number % j == 0)
                        {
                            Console.WriteLine(number + " nao eh primo");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(number + " eh primo");
                            break;
                        }
                    }
                }
            }
        }
    }
}
