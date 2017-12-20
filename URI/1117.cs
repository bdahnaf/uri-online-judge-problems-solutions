using System;

namespace URI
{
    class _1117
    {
        public static void run()
        {
            int count = 0;
            double workingNumber = 0;
            double result;
            while (true)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if(number >= 0.0 && number <= 10)
                {
                    count++;
                    workingNumber = workingNumber + number;
                    if (count == 2)
                    {
                        result = workingNumber / 2;
                        Console.WriteLine("media = " + String.Format("{0:0.00}", result));
                        return;
                    }
                }
                if(number < 0 || number > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                
            }
        }
    }
}
