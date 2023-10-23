using System;

namespace uppgift_4._9
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång vill du att triangelns sida ska vara? svara med en siffra.");
            int längd = int.Parse(Console.ReadLine());
            for (int i = 0; i < längd; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}