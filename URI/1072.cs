using System;

namespace URI
{
    class _1072
    {
        public static void run()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int avg = 0;
            if (number1 > number2)
            {
                number2++;
                for (int i = number2; i < number1; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                        sum = i + sum;
                    }
                }
            }
            else if (number2 > number1)
            {
                number1++;
                for (int i = number1; i < number2; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                        sum = i + sum;
                    }
                }
            }
            else Console.WriteLine("0");
            Console.WriteLine(sum);
        }
    }
}
