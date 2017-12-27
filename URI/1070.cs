using System;

namespace URI
{
    class _1070
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int range = number + 12;
            for (int i = number; i <= range; i++)
            {
                if (i == number)
                {
                    if(i%2 != 0)
                    {
                        range--;
                    }
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
