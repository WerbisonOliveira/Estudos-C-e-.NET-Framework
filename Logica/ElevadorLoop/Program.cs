using System;

namespace ElevadorLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa do Elevador--\n");

            Console.Write("Peso máximo suportado pelo elevador em Kg:");
            double pesoMaximoSuportadoPeloElevador = double.Parse(Console.ReadLine());

            int numeroDePessoas = 0;
            bool deuCerto;
            do
            {
                Console.Write("Número de pessoas que desejam utilizá-lo:");
                deuCerto = int.TryParse(Console.ReadLine(), out numeroDePessoas);
            } while (!deuCerto || numeroDePessoas < 0);

            double somaDosPesosDasPessoas = 0;

            for (int i = 0; i < numeroDePessoas; i++)
            {
                Console.Write($"Peso da {i + 1}ª pessoa em Kg:"); //não altera o valor de i.
                double pesoDaPessoa = double.Parse(Console.ReadLine());
                somaDosPesosDasPessoas += pesoDaPessoa;
            }

            if (somaDosPesosDasPessoas > pesoMaximoSuportadoPeloElevador)
                Console.WriteLine("Elevador não pode entrar em funcionamento.");
            else
                Console.WriteLine("Elevador funcionando...");

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
