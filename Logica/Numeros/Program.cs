using System;

namespace Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("A multiplicação entre " + n1 + " e 2 é: " + n1 * 2);

            Console.WriteLine("dobro {0} {1}", n1 * 3, n1 * 4);

            Console.WriteLine($"dobro: {n1 * 3} \\ {n1 * 4}");

            Console.WriteLine($"dobro: {n1 % 3} \\ {n1 * 4}");

            Console.WriteLine("Pressione ENTER para encerrar!");
            Console.ReadLine();
        }
    }
}
