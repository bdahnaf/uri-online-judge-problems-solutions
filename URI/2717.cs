using System;

namespace URI
{
    class _2717
    {
        public static void run()
        {
            int time = Convert.ToInt32(Console.ReadLine());
            String[] input = Console.ReadLine().Split();
            int A = Convert.ToInt32(input[0]);
            int B = Convert.ToInt32(input[1]);
            if(A+B > time)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else Console.WriteLine("Farei hoje!");
        }
    }
}
