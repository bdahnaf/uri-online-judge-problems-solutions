using System;

namespace URI
{
    class _1134
    {
        public static void run()
        {
            int number = 0;
            int alcohol, gasolin, diesel;
            alcohol = gasolin = diesel = 0;
            while(number != 4)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if(number == 1)
                {
                    alcohol++;
                }
                else if(number == 2)
                {
                    gasolin++;
                }
                else if(number == 3)
                {
                    diesel++;
                }
                else if(number == 4)
                {
                    break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcohol);
            Console.WriteLine("Gasolina: " + gasolin);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
