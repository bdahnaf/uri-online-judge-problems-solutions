using System;

namespace URI
{
    class _1101
    {
        public static void run()
        {
            while (true)
            {
                String[] input = Console.ReadLine().Split();
                int M = Convert.ToInt32(input[0]);
                int N = Convert.ToInt32(input[1]);
                int sum = 0;
                if (M <= 0 || N <= 0)
                {
                    return;
                }
                else if (M > N)
                {
                    for (int i = N; i <= M; i++)
                    {
                        Console.Write(i + " ");
                        sum = sum + i;
                    }
                    Console.WriteLine("Sum=" + sum);
                }
                else
                {
                    for (int i = M; i <= N; i++)
                    {
                        Console.Write(i + " ");
                        sum = sum + i;
                    }
                    Console.WriteLine("Sum=" + sum);
                }
            }
        }
    }
}
