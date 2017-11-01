using System;

namespace URI
{
    class _1065
    {
        public static void run()
        {
            int loopCount = 1;
            int count = 0;
            while (loopCount < 6)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number % 2 == 0)
                {
                    count++;
                }
                loopCount++;
            }
            Console.WriteLine(count + " valores pares");
        }
    }
}
