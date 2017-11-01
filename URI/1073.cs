using System;

namespace URI
{
    class _1073
    {
        public static void run()
        {
            int range = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= range; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "^2" + " = " + i*i);
                }
            }
        }
    }
}
