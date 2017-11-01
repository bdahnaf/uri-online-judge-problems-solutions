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
                //int number = Convert.ToInt32(Console.ReadLine());
                input[i] = Convert.ToInt32(Console.ReadLine());
                if (input[i] == 0)
                {
                    //Console.WriteLine("NULL");
                    output[i] = "NULL";
                }
                else if (input[i] % 2 == 0)
                {
                    if (input[i] > 0)
                    {
                        //Console.WriteLine("EVEN POSITIVE");
                        output[i] = "EVEN POSITIVE";
                    }
                    else
                    {
                        //Console.WriteLine("EVEN NEGATIVE");
                        output[i] = "EVEN NEGATIVE";
                    }
                }
                else
                {
                    if (input[i] > 0)
                    {
                        output[i] = "ODD POSITIVE";
                        //Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        output[i] = "ODD NEGATIVE";
                        //Console.WriteLine("ODD NEGATIVE");
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
