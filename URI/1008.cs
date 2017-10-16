using System;

namespace URI
{
    class _1008
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            double workHours = Convert.ToDouble(Console.ReadLine());
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ {0}", String.Format("{0:0.00}", workHours * amount));
        }
    }
}
