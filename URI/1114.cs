using System;

namespace URI
{
    class _1114
    {
        public static void run()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            while(input != 2002)
            {
                Console.WriteLine("Senha Invalida");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
