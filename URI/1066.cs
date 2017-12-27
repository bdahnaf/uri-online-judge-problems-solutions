using System;

namespace URI
{
    class _1066
    {
        public static void run()
        {
            int loopCount = 1;
            int evenCount = 0;
            int oddCount = 0;
            int positiveCount = 0;
            int negativeCount = 0;
            while (loopCount < 6)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                if(number > 0)
                {
                    positiveCount++;
                }
                else if(number < 0)
                {
                    negativeCount++;
                }
                loopCount++;
            }
            Console.WriteLine(evenCount + " valor(es) par(es)");
            Console.WriteLine(oddCount + " valor(es) impar(es)");
            Console.WriteLine(positiveCount + " valor(es) positivo(s)");
            Console.WriteLine(negativeCount + " valor(es) negativo(s)");
        }
    }
}
