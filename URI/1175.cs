using System;

namespace URI
{
    class _1175
    {
        public static void run()
        {
            int[] input = new int[20];
            for (int i = 0; i < 20; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            int index = 0;
            for (int i = 19; i >= 0; i--)
            {
                Console.WriteLine("N[" + index + "] = " + input[i]);
                index++;
            }
        }
    }
}
