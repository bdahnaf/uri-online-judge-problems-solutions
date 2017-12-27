using System;

namespace URI
{
    class _1159
    {
        public static void run()
        {
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == 0)
                {
                    return;
                }
                if (number % 2 != 0)
                {
                    number++;
                }
                int sum = 0;
                for(int i = 0; i < 5; i++)
                {
                    sum = sum + number;
                    number = number + 2;
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
