using System;

namespace Conversor_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Conversor_de_temperatura ====");
            Console.WriteLine();
          
            Console.WriteLine("Informe a temperatura em Grau Celsius:");
            Console.WriteLine();

            Console.Write("Temperatura(ºC): ");
            int temperatura = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("======== Resultado ========");
            Console.WriteLine();

            Console.WriteLine($"Temperatura na escala Kelvin: {temperatura + 273.15}K");
            Console.WriteLine();

            Console.WriteLine($"Temperatura na escala Fahrenheit: {((double)temperatura * 9/5) + 32}ºF");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();
        }
    }   
}
