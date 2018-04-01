using System;

namespace URI
{
    class _2006
    {
        public static void run()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            int correctGuess = 0;
            string[] guess = Console.ReadLine().Split();
            int guess1 = Convert.ToInt32(guess[0]);
            if (guess1 == choice)
            {
                correctGuess++;
            }
            int guess2 = Convert.ToInt32(guess[1]);
            if (guess2 == choice)
            {
                correctGuess++;
            }
            int guess3 = Convert.ToInt32(guess[2]);
            if (guess3 == choice)
            {
                correctGuess++;
            }
            int guess4 = Convert.ToInt32(guess[3]);
            if (guess4 == choice)
            {
                correctGuess++;
            }
            int guess5 = Convert.ToInt32(guess[4]);
            if (guess5 == choice)
            {
                correctGuess++;
            }
            Console.WriteLine(correctGuess);
        }
    }
}
