using System;

namespace URI
{
    class _1142
    {
        public static void run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(counter++ + " " + counter++ + " " + counter++ + " PUM");
                counter++;
            }
        }
    }
}
