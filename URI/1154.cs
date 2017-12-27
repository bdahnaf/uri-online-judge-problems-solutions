using System;

namespace URI
{
    class _1154
    {
        public static void run()
        {
            double sum = 0;
            int counter = 0;
            while (true)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if(number < 0)
                {
                    Console.WriteLine(String.Format("{0:0.00}", sum / counter));
                    return;
                }
                else
                {
                    sum = sum + number;
                    counter++;
                }
            }
        }
    }
}
