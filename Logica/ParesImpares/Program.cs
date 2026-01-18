using System;

/*
    * Imprimir todos numeros pares entre 0 e 300.
 */

namespace ParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Pares_Impares ====");

            for(int par = 0; par <= 300; par+=2)
            {          
                Console.WriteLine($"\nNúmero par: {par}");
            }

            Console.WriteLine("");

            for(int par = 1; par <= 300; par+=2)
            {          
                Console.WriteLine($"\nNúmero ímpar: {par}");
            }
        }
    }
}
