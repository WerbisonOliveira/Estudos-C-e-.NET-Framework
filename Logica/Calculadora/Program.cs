using System;


namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Calculadora---");

            Console.Write("Digite um número: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Soma: {v1 + v2}");
            Console.WriteLine($"Subtração: {v1 - v2}");
            Console.WriteLine($"Multiplicação: {v1 * v2}");

            if(v2 != 0)
            {
                Console.WriteLine($"Divisão: {(double)v1 / v2:0.00}");
                Console.WriteLine($"Resto: {v1 % v2}"); // operador módulo
            } else
            {
                Console.WriteLine("Não é possível fazer divisão ou obter o resto por 0");
            }

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
