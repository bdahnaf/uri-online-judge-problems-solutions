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
                for (int j = 2; j < number/2; j++)
                {
                    if(j % 2 == 0 || j % 3 == 0)
                    {
                        Console.WriteLine(number + " nao eh perfeito");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(number + " eh perfeito");
                        break;
                    }
                }
            }
        }
    }
}
