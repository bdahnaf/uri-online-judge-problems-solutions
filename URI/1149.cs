using System;

namespace URI
{
    class _1149
    {
        public static void run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int A = Convert.ToInt32(input[0]);
                int N = Convert.ToInt32(input[1]);
                int counter = 0;
                int answer = 0;
                int i = A;
                while (true)
                {
                    answer = answer + i;
                    i++;
                    counter++;
                    if(counter == N)
                    {
                        break;
                    }
                }
                Console.WriteLine(answer);
            }
            Console.ReadKey();
        }
    }
}
