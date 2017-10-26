using System;

namespace URI
{
    class _1044
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            int n1 = Convert.ToInt32(input[0]);
            int n2 = Convert.ToInt32(input[1]);
            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
