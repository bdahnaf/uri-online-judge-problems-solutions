using System;

namespace URI
{
    class _1038
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            double code = Convert.ToDouble(input[0]);
            double quantity = Convert.ToDouble(input[1]);
            double price = 0.0;
            if(code == 1)
            {
                price = 4.00;
            }
            else if (code ==2)
            {
                price = 4.50;
            }
            else if (code == 3)
            {
                price = 5.00;
            }
            else if (code == 4)
            {
                price = 2.00;
            }
            else if (code == 5)
            {
                price = 1.50;
            }
            Console.WriteLine("Total: R$ " + String.Format("{0:0.00}", price*quantity));
            Console.ReadKey();
        }
    }
}
