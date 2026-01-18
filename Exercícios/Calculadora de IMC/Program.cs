using System;


namespace Calculadora_de_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Calculadora_de_IMC====");
            Console.WriteLine();
            
            Console.WriteLine("Informe seus dados:");
            Console.WriteLine();

            Console.Write("Peso(kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Altura(m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = System.Math.Round(peso / (altura * altura), 2);
            Console.WriteLine();

            Console.WriteLine("----Resultado----");
            Console.WriteLine();

            Console.WriteLine($"Seu IMC: {imc}");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER  para sair");
            Console.ReadLine();
        }
    }
}
