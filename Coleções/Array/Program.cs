using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numeroBlocos = 1000;

            int[] n = new int[numeroBlocos];

            for (int i = 0; i < numeroBlocos; i++)
            {
                Console.WriteLine($"índice {i} => {n[i]}");
            }
        }
    }
}
