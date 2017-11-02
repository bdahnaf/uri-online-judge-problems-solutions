using System;

namespace URI
{
    class _1094
    {
        public static void run()
        {
            int range = Convert.ToInt32(Console.ReadLine());
            string[] output = new string[range];
            int cAmount = 0;
            int rAmount = 0;
            int sAmount = 0;
            int totalAmount = 0;
            double cPer = 0;
            double rPer = 0;
            double sPer = 0;
            for (int i = 1; i <= range; i++)
            {
                String[] input = Console.ReadLine().Split();
                int amount = Convert.ToInt32(input[0]);
                string type = input[1];
                if (type == "C")
                {
                    cAmount = amount + cAmount;
                }
                else if (type == "S")
                {
                    sAmount = amount + sAmount;
                }
                else
                {
                    rAmount = amount + rAmount;
                }
                totalAmount = totalAmount + amount;
            }
            cPer = totalAmount / cAmount;
            rPer = totalAmount / rAmount;
            sPer = totalAmount / sAmount;
            Console.WriteLine("Total: " + totalAmount + " cobaias");
            Console.WriteLine("Total de coelhos: " + cAmount);
            Console.WriteLine("Total de ratos: " + rAmount);
            Console.WriteLine("Total de sapos: " + sAmount);
            Console.WriteLine("Percentual de coelhos: " + String.Format("{0:0.00}", cPer) + " %");
            Console.WriteLine("Percentual de ratos: " + String.Format("{0:0.00}", rPer) + " %");
            Console.WriteLine("Percentual de sapos: " + String.Format("{0:0.00}", sPer) + " %");
            Console.ReadKey();
        }
    }
}
