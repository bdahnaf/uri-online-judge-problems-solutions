using System;

namespace URI
{
    class _1074
    {
        public static void run()
        {
            int range = Convert.ToInt32(Console.ReadLine());
            int []input = new int[range];
            string[] output = new string[range];
            for(int i = 0; i < range;  i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
                if (input[i] == 0)
                {
                    output[i] = "NULL";
                }
                else if (input[i] % 2 == 0)
                {
                    if (input[i] > 0)
                    {
                        output[i] = "EVEN POSITIVE";
                    }
                    else
                    {
                        output[i] = "EVEN NEGATIVE";
                    }
                }
                else
                {
                    if (input[i] > 0)
                    {
                        output[i] = "ODD POSITIVE";
                    }
                    else
                    {
                        output[i] = "ODD NEGATIVE";
                    }
                }
            }
            for(int i = 0; i < range; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
