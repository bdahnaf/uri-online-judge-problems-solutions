using System;

namespace URI
{
    class _1037
    {
        public static void run()
        {
            double number = Convert.ToDouble(Console.ReadLine());

            if (number >= 0.0000 && number <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (number > 25.000000 && number <= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (number > 50.0000000 && number <= 75.0000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (number > 75.0000000 && number <= 100.0000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else Console.WriteLine("Fora de intervalo");
        }
    }
}
