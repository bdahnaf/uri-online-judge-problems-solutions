using System;


namespace URI
{
    class _1865
    {
        public static void run()
        {
            int counter = Convert.ToInt32(Console.ReadLine());
            string output = "";
            string superhero = Console.ReadLine();
            if (superhero.Substring(0, 4) == "Thor")
            {
                output = output + "Y";
            }
            else
            {
                output = output + "N";
            }
            for (int i = 1; i < counter; i++)
            {
                superhero = Console.ReadLine();
                if (superhero.Substring(0, 4) == "Thor")
                {
                    output = output + "\nY";
                }
                else
                {
                    output = output + "\nN";
                }
            }
            Console.WriteLine(output);
        }
    }
}
