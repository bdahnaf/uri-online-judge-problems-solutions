using System;


namespace URI
{
    class _1080
    {
        public static void run()
        {
            int compare = 0;
            int position = 1;
            for (int i = 1; i <= 100; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if(number > compare)
                {
                    compare = number;
                    position = i;
                }
            }
            Console.WriteLine(compare);
            Console.WriteLine(position);
        }
    }
}
