using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1013
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            int num1 = Convert.ToInt32(input[0]);
            int num2 = Convert.ToInt32(input[1]);
            int num3 = Convert.ToInt32(input[2]);
            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine(num1 + " eh o maior");
                }
                else
                {
                    Console.WriteLine(num3 + " eh o maior");
                }
            }
            else if (num2 >= num1)
            {
                if (num2 >= num3)
                {
                    Console.WriteLine(num2 + " eh o maior");
                }
                else
                {
                    Console.WriteLine(num3 + " eh o maior");
                }
            }
            else
            {
                Console.WriteLine(num3 + " eh o maior");
            }
        }
    }
}
