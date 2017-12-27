using System;

namespace URI
{
    class _1156
    {
        public static void run()
        {
            double upper = 1;
            double lower = 1;
            double sum = 0;
            while(upper != 39)
            {
                sum = sum + upper / lower;
                upper = upper + 2;
                lower = lower + lower;
            }
            Console.WriteLine(String.Format("{0:0.00}", sum));
        }
    }
}
