using System;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("\t");
                }
            }
            Console.WriteLine("...");
            Console.ReadLine();
        }
    }
}