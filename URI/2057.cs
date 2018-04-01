using System;

namespace URI
{
    class _2057
    {
        public static void run()
        {
            string[] time = Console.ReadLine().Split();
            int S = Convert.ToInt32(time[0]);
            int T = Convert.ToInt32(time[1]);
            int F = Convert.ToInt32(time[2]);
            S = S + T;
            if (S >= 24)
            {
                S = S - 24;
            }
            S = S + F;
            if (S < 0)
            {
                S = 24 + S;
            }
            Console.WriteLine(S);
        }
    }
}
