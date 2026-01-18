using System;

namespace Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Motor motor = new Models.Motor(500, "Gasolina");

            Models.Carro ferrari = new Models.Carro();
            ferrari.Motor = motor;
            ferrari.Modelo = "Roma";
            ferrari.Ano = 2024;

            Console.WriteLine(ferrari.ExibirDetalhes());
            
        }
    }
}
