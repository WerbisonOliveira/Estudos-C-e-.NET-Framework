using System;

namespace Conversor_de_moeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Conversor_de_Moeda====");
            Console.WriteLine();

            Console.WriteLine("Informe o valor em reais:");
            Console.WriteLine();

            Console.Write("Valor(R$): ");
            double valor = Convert.ToDouble(Console.ReadLine());

            double dolar = System.Math.Round(valor / 5.43, 2);
            Console.WriteLine();

            Console.WriteLine("==== Resultado ====");
            Console.WriteLine();

            Console.WriteLine($"Você possui {dolar} dólares");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER  para sair");
            Console.ReadLine();
        }
    }
}
