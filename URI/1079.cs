using System;

namespace URI
{
    class _1079
    {
        public static void run()
        {
            int range = Convert.ToInt32(Console.ReadLine());
            string[] output = new string[range];
            for (int i = 1; i <= range; i++)
            {
                String[] input = Console.ReadLine().Split();
                double number1 = Convert.ToDouble(input[0]);
                double number2 = Convert.ToDouble(input[1]);
                double number3 = Convert.ToDouble(input[2]);
                output[i-1] = String.Format("{0:0.0}", ((number1 * 2 + number2 * 3 + number3 * 5) / 10));
            }

            for(int i = 0; i < range; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
