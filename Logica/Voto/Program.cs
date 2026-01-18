using System;

namespace Voto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                 * Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.
                 * Os códigos utilizados são:
                    • 1,2,3,4 votos para os respectivos candidatos;
                    • 5 voto nulo; 
                    • 6 voto em branco.
                 * Assim, escreva um programa para receber um único voto e imprima: 
                    • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
                    • Se o usuário votou nulo: "Voto nulo contabilizado..."
                    • Se o usuário votou em branco: "Voto branco contabilizado..
                 * Se o voto for diferente de todas as opções acima: "Voto inválido..."
            */

            int voto = 0, votosComSucesso = 0, votosEmBranco = 0, votosNulos = 0, votosInvalidos = 0;
            string continuar = "n";
            bool validar;
            do
            {
                do
                {
                    Console.WriteLine("==== Votação ====");

                    Console.Write("\nInforme seu voto: ");
                    validar = int.TryParse(Console.ReadLine(), out voto);
                    if (!validar)
                        Console.Clear();

                } while (!validar);              

                switch (voto)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("\nVoto contabilizado com sucesso...");
                        votosComSucesso++;
                        break;
                    case 5:
                        Console.WriteLine("\nVoto nulo contabilizado com sucesso...");
                        votosNulos++;
                        break;
                    case 6:
                        Console.WriteLine("\nVoto branco contabilizado com sucesso...");
                        votosEmBranco++;
                        break;
                    default:
                        Console.WriteLine("\nVoto inválido...");
                        votosInvalidos++;
                        break;
                }

                do
                {
                    Console.Write("\nDeseja continuar votando? [s-sim / n-não] ");
                    continuar = Console.ReadLine();

                } while (continuar != "s" && continuar != "n");

                Console.Clear();

            } while (continuar == "s" || continuar == "S");

            Console.WriteLine($"Total de votos: {votosComSucesso + votosEmBranco + votosNulos + votosInvalidos}");
            Console.WriteLine($"Voto(s) contabilizado(s) para candidatos: {votosComSucesso}");
            Console.WriteLine($"Voto(s) branco(s) contabilizado(s): {votosEmBranco}");
            Console.WriteLine($"Voto(s) nulo(s) contabilizado(s): {votosNulos}");
            Console.WriteLine($"Voto(s) inválido(s) contabilizado(s): {votosInvalidos}");

            #region "Solução com estrutura de decisão"
            /*
            if(voto == 1)
            {
                Console.WriteLine("Voto contabilizado com sucesso...");
            }
            else if (voto == 2)
            {
                Console.WriteLine("Voto contabilizado com sucesso...");
            }
            else if (voto == 3)
            {
                Console.WriteLine("Voto contabilizado com sucesso...");
            }
            else if (voto == 4)
            {
                Console.WriteLine("Voto contabilizado com sucesso...");
            }
            else if (voto == 5)
            {
                Console.WriteLine("Voto nulo contabilizado com sucesso...");
            }
            else if (voto == 6)
            {
                Console.WriteLine("Voto branco contabilizado com sucesso...");
            }
            else
            {
                Console.WriteLine("Voto inválido...");
            }
            */
            #endregion

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
