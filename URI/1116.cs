using System;

namespace URI
{
    class _1116
    {
        public static void run()
        {
            int loop;
            loop = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                String[] input = Console.ReadLine().Split();
                double number1 = Convert.ToDouble(input[0]);
                double number2 = Convert.ToDouble(input[1]);
                double result = number1 / number2;
                if(number2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(String.Format("{0:0.0}", result));
                }

            }
            
        }
    }
}
