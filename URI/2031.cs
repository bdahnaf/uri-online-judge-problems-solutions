using System;

namespace URI
{
    class _2031
    {
        public static void run()
        {
            int range = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < range; i++)
            {
                string p1 = Console.ReadLine();
                string p2 = Console.ReadLine();
                if (p1 == "pedra" && p2 == "pedra")
                {
                    Console.WriteLine("Sem ganhador");
                }
                else if(p1 == "papel" && p2 == "papel")
                {
                    Console.WriteLine("Ambos venceram");
                }
                else if (p1 == "ataque" && p2 == "ataque")
                {
                    Console.WriteLine("Aniquilacao mutua");
                }
                else if (p1 == "ataque" && p2 == "ataque")
                {
                    Console.WriteLine("Aniquilacao mutua");
                }
                else if (p1 == "ataque" && p2 == "pedra")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (p1 == "pedra" && p2 == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else if (p1 == "pedra" && p2 == "papel")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (p1 == "papel" && p2 == "pedra")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else if (p1 == "papel" && p2 == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else if (p1 == "ataque" && p2 == "papel")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
            }
        }
    }
}
