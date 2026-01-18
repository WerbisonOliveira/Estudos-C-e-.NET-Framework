using System;

namespace Adivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respostaDoUsuario = "s";

            do
            {
                Console.WriteLine("========== Jogo da Adivinhação ==========");

                Console.WriteLine("\nSorteando número de 0 a 10...");

                int numeroSorteado = new Random().Next(11);

                Console.WriteLine("\nNúmero sorteado!");

                Console.WriteLine("\nTente acertar o número!");

                uint numero = 0;
                bool validacao = false;

                do
                {
                    Console.Write("\nInforme um número: ");
                    validacao = uint.TryParse(Console.ReadLine(), out numero);

                    if (validacao == true)
                    {
                        if (numero < numeroSorteado)
                        {
                            Console.WriteLine("\nO número sorteado é maior");
                        }
                        else if (numero > numeroSorteado)
                        {
                            Console.WriteLine("\nO número sorteado é menor");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido!");
                    }

                } while (numero != numeroSorteado);

                Console.WriteLine("\nParabéns, você acertou!");

                do
                {
                    Console.Write("\nJogar novamente? [s - sim / n - não] ");
                    respostaDoUsuario = Console.ReadLine();

                    if (respostaDoUsuario.ToLower() != "s" && respostaDoUsuario.ToLower() != "n")
                        Console.WriteLine("\nResposta inválida!");
                  
                } while (respostaDoUsuario.ToLower() != "s" && respostaDoUsuario.ToLower() != "n");

                if (respostaDoUsuario.ToLower() == "s")
                    Console.Clear();

            } while (respostaDoUsuario.ToLower() == "s");

            Console.WriteLine("\nPressione ENTER para encerrar o jogo.");
            Console.ReadLine();

        }
    }
}
