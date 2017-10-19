using System;

namespace URI
{
    class _1036
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            double A = Convert.ToDouble(input[0]);
            double B = Convert.ToDouble(input[1]);
            double C = Convert.ToDouble(input[2]);
            double result = Math.Pow(B, 2) - (4 * A * C);
            if(result >= 0 && A != 0)
            {
                double x1 = (-B + Math.Sqrt(result)) / (2 * A);
                double x2 = (-B - Math.Sqrt(result)) / (2 * A);
                Console.WriteLine("R1 = " + String.Format("{0:0.00000}", x1));
                Console.WriteLine("R2 = " + String.Format("{0:0.00000}", x2));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
