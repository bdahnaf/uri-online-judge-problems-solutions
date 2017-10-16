using System;

namespace URI
{
    class _1014
    {
        public static void run()
        {
            int distance = Convert.ToInt32(Console.ReadLine());
            double fuel = Convert.ToDouble(Console.ReadLine());
            double answer = distance / fuel;
            Console.WriteLine(String.Format("{0:0.000}", answer) + " km/l");
        }
    }
}
