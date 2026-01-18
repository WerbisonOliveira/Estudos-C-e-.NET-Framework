using System;


namespace Impressora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Impressora impressora = new Models.Impressora();

            Console.WriteLine($"Texto informado: {impressora.ImprimirTexto("Orientação a Objetos")}");

            Console.WriteLine($"Número: {impressora.ImprimirNumero(10)}");

            Console.WriteLine($"Vezes imprimidos: {impressora.ImprimirQtdTexto("casa", 3)}");


        }
    }
}
