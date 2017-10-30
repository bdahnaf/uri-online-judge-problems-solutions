using System;

namespace URI
{
    class _1047
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            int t1 = Convert.ToInt32(input[0]);
            int m1 = Convert.ToInt32(input[1]);
            int t2 = Convert.ToInt32(input[2]);
            int m2 = Convert.ToInt32(input[3]);
            int hour1 = 0;
            int hour2 = 0;
            int minute = 0;
            /*
            if (t1 < t2)
            {
                hour = t2 - t1;
            }
            else
            {
                hour = 24 - t1 + t2;
            }
            if (m1 < m2)
            {
                minute = m2 - m1;
            }
            else
            {
                minute = 60 - m1 + m2;
            }
            */
            hour1 = t1 * 60 + m1;
            hour2 = t2 * 60 + m2;
            //minute = Math.Abs(hour1-hour2);
            minute = hour1 - hour2;
            int hour = minute / 60;
            minute = minute % 60;
            Console.WriteLine("O JOGO DUROU " + hour + " HORA(S) E " + minute + " MINUTO(S)");
            Console.ReadKey();
        }
    }
}
