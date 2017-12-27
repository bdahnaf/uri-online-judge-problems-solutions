using System;

namespace URI
{
    class _1150
    {
        public static void run()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Z = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while(X >= Z)
            {
                Z = Convert.ToInt32(Console.ReadLine());
            }
            int i = X;
            while (sum < Z)
            {
                sum = sum + i;
                count++;
                i++;
            }
            Console.WriteLine(count);
        }
    }
}
