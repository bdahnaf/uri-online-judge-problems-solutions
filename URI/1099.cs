using System;

namespace URI
{
    class _1099
    {
        public static void run()
        {
                int counter = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < counter; i++)
                {
                    String[] input = Console.ReadLine().Split();
                    int number1 = Convert.ToInt32(input[0]);
                    int number2 = Convert.ToInt32(input[1]);
                    int big = 0;
                    int small = 0;
                    int sum = 0;
                    if(number1 > number2)
                    {
                        big = number1;
                        small = number2;
                    }
                    else
                    {
                        big = number2;
                        small = number1;
                    }
                    small++;
                    for(int j = small; j < big; j++)
                    {
                        if(j%2 != 0)
                        {
                            sum = sum + j;
                        }
                    }
                    Console.WriteLine(sum);
                }
        }
    }
}
