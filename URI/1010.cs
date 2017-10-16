using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1010
    {
        public static void run()
        {
            string[] input1 = Console.ReadLine().Split();
            int productCode1 = int.Parse(input1[0]);
            int quantity1 = int.Parse(input1[1]);
            double price1 = double.Parse(input1[2]);
            string[] input2 = Console.ReadLine().Split();
            int productCode2 = int.Parse(input2[0]);
            int quantity2 = int.Parse(input2[1]);
            double price2 = double.Parse(input2[2]);
            double amount = quantity1 * price1 + quantity2 * price2;
            Console.WriteLine("VALOR A PAGAR: R$ " + String.Format("{0:0.00}", amount));
        }
    }
}
