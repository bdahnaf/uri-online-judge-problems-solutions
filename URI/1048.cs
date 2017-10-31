using System;

namespace URI
{
    class _1048
    {
        public static void run()
        {
            double salary = Convert.ToDouble(Console.ReadLine());
            double increase = 0;
            if(salary >= 0 && salary <= 400.00)
            {
                increase = salary * .15;
                Console.WriteLine("Novo salario: " + String.Format("{0:0.00}", increase + salary));
                Console.WriteLine("Reajuste ganho: " + String.Format("{0:0.00}", increase));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salary >= 400.01 && salary <= 800.00)
            {
                increase = salary * .12;
                Console.WriteLine("Novo salario: " + String.Format("{0:0.00}", increase + salary));
                Console.WriteLine("Reajuste ganho: " + String.Format("{0:0.00}", increase));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salary >= 800.01 && salary <= 1200.00)
            {
                increase = salary * .10;
                Console.WriteLine("Novo salario: " + String.Format("{0:0.00}", increase + salary));
                Console.WriteLine("Reajuste ganho: " + String.Format("{0:0.00}", increase));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salary >= 1200.01 && salary <= 2000.00)
            {
                increase = salary * .07;
                Console.WriteLine("Novo salario: " + String.Format("{0:0.00}", increase + salary));
                Console.WriteLine("Reajuste ganho: " + String.Format("{0:0.00}", increase));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salary > 2000.00)
            {
                increase = salary * .04;
                Console.WriteLine("Novo salario: " + String.Format("{0:0.00}", increase + salary));
                Console.WriteLine("Reajuste ganho: " + String.Format("{0:0.00}", increase));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
