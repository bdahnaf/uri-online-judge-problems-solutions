using System;

namespace URI
{
    class _1026
    {
        public static void run()
        {
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                string[] input2 = input.Split();
                int a = Convert.ToInt32(input2[0]);
                int b = Convert.ToInt32(input2[1]);
                int result = a ^ b;
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
