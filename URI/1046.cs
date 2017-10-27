using System;

namespace URI
{
    class _1046
    {
        public static void run()
        {
            String[] input = Console.ReadLine().Split();
            int t1 = Convert.ToInt32(input[0]);
            int t2 = Convert.ToInt32(input[1]);
            int answer = 0;
            if(t1 < t2)
            {
                answer = t2 - t1;
            }
            else
            {
                answer = 24 - t1 + t2;
            }
            Console.WriteLine("O JOGO DUROU " + answer + " HORA(S)");
        }
    }
}
