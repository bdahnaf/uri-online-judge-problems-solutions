using System;

namespace URI
{
    class _1158
    {
        public static void run()
        {
            int counter = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < counter)
            {
                String[] input = Console.ReadLine().Split();
                int X = Convert.ToInt32(input[0]);
                int Y = Convert.ToInt32(input[1]);
                int j = 0;
                int sum = 0;
                while (true)
                {
                    if (X % 2 != 0)
                    {
                        sum = sum + X;
                        j++;
                        if(j == Y)
                        {
                            break;
                        }
                    }
                    X++;
                }
                Console.WriteLine(sum);
                i++;
            }
        }
    }
}
