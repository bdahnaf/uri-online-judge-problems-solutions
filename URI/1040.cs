using System;

namespace URI
{
    class _1040
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            double n1 = Convert.ToDouble(input[0]);
            double n2 = Convert.ToDouble(input[1]);
            double n3 = Convert.ToDouble(input[2]);
            double n4 = Convert.ToDouble(input[3]);
            double average = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;
            Console.WriteLine("Media: " + String.Format("{0:0.0}", average));
            if(average > 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            Console.ReadKey();
        }
    }
}
