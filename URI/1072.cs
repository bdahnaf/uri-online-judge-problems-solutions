using System;

namespace URI
{
    class _1072
    {
        public static void run()
        {
            int loopCount = Convert.ToInt32(Console.ReadLine());
            int loop = 0;
            int inCount = 0;
            int outCount = 0;
            while(loop < loopCount)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    inCount++;
                }
                else outCount++;
                loop++;
            }
            Console.WriteLine(inCount + " in");
            Console.WriteLine(outCount + " out");
        }
    }
}
