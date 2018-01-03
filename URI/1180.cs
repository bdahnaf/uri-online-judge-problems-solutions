using System;

namespace URI
{
    class _1180
    {
        public static void run()
        {
            int range = Convert.ToInt32(Console.ReadLine());
            String[] input = Console.ReadLine().Split();
            int[] numbers = new int[20];
            numbers[0] = Convert.ToInt32(input[0]);
            int lowest = numbers[0];
            int position = 0;
            for(int i = 1; i < range; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
                if(numbers[i] < numbers[i - 1])
                {
                    lowest = numbers[i];
                    position = i;
                }
            }
            Console.WriteLine("Menor valor: " + lowest);
            Console.WriteLine("Posicao: " + position);
            Console.ReadKey();
        }
    }
}
