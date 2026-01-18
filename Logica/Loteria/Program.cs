using System;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Loteria-----");
            Console.WriteLine("Informe os valores:");

            Console.WriteLine();

            Console.Write("Valor do prêmio R$: ");
            double premio = double.Parse(Console.ReadLine());

            Console.Write("Aposta 1 R$: ");
            double aposta1 = double.Parse(Console.ReadLine());

            Console.Write("Aposta 2 R$: ");
            double aposta2 = double.Parse(Console.ReadLine());

            Console.Write("Aposta 3 R$: ");
            double aposta3 = double.Parse(Console.ReadLine());

            double somaDeTodos = aposta1 + aposta2 + aposta3;

            Console.WriteLine();

            Console.WriteLine("Valores a receber de cada amigo:");
            
            Console.WriteLine();

            Console.WriteLine($"Amigo 1: R$ {aposta1 / somaDeTodos * premio:0.00}");
            Console.WriteLine($"Amigo 2: R$ {aposta2 / somaDeTodos * premio:0.00}");
            Console.WriteLine($"Amigo 3: R$ {aposta3 / somaDeTodos * premio:0.00}");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();


        }
    }
}
