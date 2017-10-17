using System;

namespace URI
{
    class _1019
    {
        public static void run()
        {
            int seconds = Convert.ToInt32(Console.ReadLine());
            int hours = seconds / 3600;
            int remainders = seconds % 3600;
            int minutes = remainders / 60;
            seconds = remainders - (minutes * 60);
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
    }
}
