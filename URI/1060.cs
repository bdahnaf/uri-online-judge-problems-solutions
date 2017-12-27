using System;

namespace URI
{
    class _1060
    {
        public static void run()
        {
            int loopCount = 1;
            int count = 0;
            while(loopCount < 7)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number >= 0)
                {
                    count++;
                }
                loopCount++;
            }
            Console.WriteLine(count + " valores positivos");
        }
    }
}
