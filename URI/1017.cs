﻿using System;

namespace URI
{
    class _1017
    {
        public static void run()
        {
            double hour = Convert.ToDouble(Console.ReadLine());
            int kmPerHour = Convert.ToInt32(Console.ReadLine());
            double fuel = (hour * kmPerHour) / 12;
            Console.WriteLine(String.Format("{0:0.000}", fuel));
        }
    }
}
