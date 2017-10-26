using System;

namespace URI
{
    class _1043
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            int n1 = Convert.ToInt32(input[0]);
            int n2 = Convert.ToInt32(input[1]);
            int n3 = Convert.ToInt32(input[2]);
            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine(n1);
                if (n2 > n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine(n2);
                if (n1 > n3)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
            }
            else
            {
                Console.WriteLine(n3);
                if (n1 > n2)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.ReadKey();
        }
    }
}
