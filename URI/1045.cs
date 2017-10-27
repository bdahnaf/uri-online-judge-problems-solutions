using System;

namespace URI
{
    class _1045
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            double n1 = Convert.ToDouble(input[0]);
            double n2 = Convert.ToDouble(input[1]);
            double n3 = Convert.ToDouble(input[2]);
            double A, B, C;
            if(n1 > n2 && n1 > n3)
            {
                A = n1;
                if(n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3 && n2 > n1)
            {
                A = n2;
                if(n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }
            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (A * A == B * B + C * C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A * A > B * B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (A * A < B * B + C * C)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if ((n1 == n2 && n1 != n3) || (n2 == n3 && n2 != n1) || (n1 == n3 && n1 != n2))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
