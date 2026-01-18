using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Calculadora calculadora = new Models.Calculadora();

            //calculadora.valor1 = 10;
            //calculadora.valor2 = 5;

            //calculadora.valor1 = 55;
            //calculadora.valor2 = 5;

            //calculadora.valor1 = 0;
            //calculadora.valor2 = 172;

            //calculadora.valor1 = 78; 
            //calculadora.valor2 = 0; lança exceção, pois não é possível dividir por 0

            //calculadora.valor1 = 8;
            //calculadora.valor2 = 67;

            Console.WriteLine("------ Calculadora ------\n");

            Console.WriteLine($"Soma: {calculadora.Somar(10, 5)}");
            Console.WriteLine($"Subtração: {calculadora.Subtrair(55, 5)}");
            Console.WriteLine($"Multiplicação: {calculadora.Multiplicar(0, 172)}");
            Console.WriteLine($"Divisão: {calculadora.Dividir(76, 8)}");

        }
    }
}
