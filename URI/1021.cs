using System;

namespace URI
{
    class _1021
    {
        public static void run()
        {
            double input = Convert.ToDouble(Console.ReadLine());
            int number = (int)input;
            //int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            int hundred = number / 100;
            Console.WriteLine(hundred + " nota(s) de R$ 100,00");
            int remainder = number % 100;
            int fifty = remainder / 50;
            Console.WriteLine(fifty + " nota(s) de R$ 50,00");
            remainder = remainder % 50;
            int twenty = remainder / 20;
            Console.WriteLine(twenty + " nota(s) de R$ 20,00");
            remainder = remainder % 20;
            int ten = remainder / 10;
            Console.WriteLine(ten + " nota(s) de R$ 10,00");
            remainder = remainder % 10;
            int five = remainder / 5;
            Console.WriteLine(five + " nota(s) de R$ 5,00");
            remainder = remainder % 5;
            int two = remainder / 2;
            Console.WriteLine(two + " nota(s) de R$ 2,00");
            Console.WriteLine("MOEDAS:");
            remainder = remainder % 2; 
            int one = remainder / 1;
            Console.WriteLine(one + " moeda(s) de R$ 1,00");
            double fraction = Math.Round(input - (double)number, 2)*100;
            number = (int)fraction;
            fifty = number / 50;
            Console.WriteLine(one + " moeda(s) de R$ 0.50");
            remainder = number % 50;
            int tfive = remainder / 25;
            Console.WriteLine(one + " moeda(s) de R$ 0.25");
            remainder = tfive / 10;
          //  remainder = 
            Console.WriteLine(fifty);
            Console.ReadKey();
        }
    }
}
