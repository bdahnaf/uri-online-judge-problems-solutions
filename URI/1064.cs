using System;

namespace URI
{
    class _1064
    {
        public static void run()
        {
            int loopCount = 1;
            int count = 0;
            double sum = 0.00;
            while (loopCount < 7)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number >= 0)
                {
                    count++;
                    sum = sum + number;
                }
                loopCount++;
            }
            Console.WriteLine(count + " valores positivos");
            Console.WriteLine(String.Format("{0:0.0}", sum / count));
        }
    }
}
