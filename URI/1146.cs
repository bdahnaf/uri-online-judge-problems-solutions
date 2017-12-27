using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class _1146
    {
        public static void run()
        {
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    return;
                }
                for(int i = 1; i <= number; i++)
                {
                    if (i == number)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
