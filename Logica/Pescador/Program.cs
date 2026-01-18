using System;

namespace Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho. 
                * Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. 
                * Assim, faça um programa que leia o peso de peixes e verifique se há excesso. 
                * Se houver, o programa também deve calcular o valor da multa que o pescador deverá pagar. 
                * No final, o programa deve imprimir o excesso e a multa paga pelo pescador.

             */

            const double PESOMAXIMOEMKG = 50.00;
            const double VALORDAMULTAPORKGEXCEDIDO = 4.00;


            Console.WriteLine("==== Pesagem_de_peixes ====");
            Console.WriteLine("");

            Console.Write("Informe o peso dos peixes: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double pesoExcedido = 0;
            double valorDaMulta = 0;

            if (peso <= PESOMAXIMOEMKG)
            {
                Console.WriteLine($"Peso excedido: {pesoExcedido:0.00} Kg \nValor da multa: R$ {valorDaMulta:0.00}");
            }
            else
            {
                pesoExcedido = peso - PESOMAXIMOEMKG;
                valorDaMulta = pesoExcedido * VALORDAMULTAPORKGEXCEDIDO;
                Console.WriteLine($"Peso excedido: {pesoExcedido:0.00} Kg \nValor da multa: R$ {valorDaMulta:0.00}");
            }

            Console.WriteLine("");

            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadLine();

        }
    }
}
