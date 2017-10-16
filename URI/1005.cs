using System;

namespace URI
{
    class _1005
    {
        public static void run()
        {
            double firstInput;
            double secondInput;
            double result;
            firstInput = Convert.ToDouble(Console.ReadLine());
            secondInput = Convert.ToDouble(Console.ReadLine());
            result = ((firstInput * 3.5) + (secondInput * 7.5)) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = {0}", Math.Round(result, 5));
        }
    }
}
