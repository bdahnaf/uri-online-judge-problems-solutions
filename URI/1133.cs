using System;

namespace URI
{
    class _1133
    {
        public static void run()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if(number1 > number2)
            {
                number1 = number1 + number2;
                number2 = number1 - number2;
                number1 = number1 - number2;
            }
            number1++;
            for(int i = number1; i < number2; i++)
            {
                int number = i;
                if(number%5==2 || number % 5 == 3)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
