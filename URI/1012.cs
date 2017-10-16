using System;

namespace URI
{
    class _1012
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            double a = Convert.ToDouble(input[0]);
            double b = Convert.ToDouble(input[1]);
            double c = Convert.ToDouble(input[2]);
            double pi = 3.14159;
            double triangle = (a * c) / 2;
            double circle = pi * c * c;
            double trapezium = ((a + b) / 2) * c;
            double square = b * b;
            double rectangle = a * b;
            Console.WriteLine("TRIANGULO: " + String.Format("{0:0.000}", triangle));
            Console.WriteLine("CIRCULO: " + String.Format("{0:0.000}", circle));
            Console.WriteLine("TRAPEZIO: " + String.Format("{0:0.000}", trapezium));
            Console.WriteLine("QUADRADO: " + String.Format("{0:0.000}", square));
            Console.WriteLine("RETANGULO: " + String.Format("{0:0.000}", rectangle));
        }
    }
}
