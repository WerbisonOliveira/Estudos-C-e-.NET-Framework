using System;
using System.Web;

/*
 * Estou começando um jogo de par ou ímpar para você.
 * Nele, o jogador escolhe par ou ímpar e informa um número. Depois, o computador escolhe um número aleatório.
Agora, você deve:
    • Continuar o código do jogo para decidir quem ganha: jogador ou computador.
    • Deixar o jogador jogar quantas vezes desejar, até ele indicar que deseja parar.
    • Depois da parada, apresentar o placar final do jogo informando quem ganhou. Exemplo: Jogador: 10 x
    Computador:5 (Jogador ganhou).
            o Mas, não se esqueça, pode dar empate.
*/

namespace Jogo_Par_Ou_Ímpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PAR = "p", IMPAR = "i";
            string parOuImpar = "", respostaDoUsuario = "", opcaoJogador = "";
            int pontoDoJogador = 0, pontoDoComputador = 0, numeroJogador = 0, numeroComputador = 0;
            bool validacao;

            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("------Bem-vindo ao jogo do Par ou Ímpar------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("");

                do
                {
                    Console.Write("\nVocê quer par (p) ou ímpar (i)? ");
                    opcaoJogador = Console.ReadLine();

                    if (opcaoJogador != PAR && opcaoJogador != IMPAR)
                        Console.WriteLine("\nOpção inválida!");

                } while (opcaoJogador != PAR && opcaoJogador != IMPAR);

                do
                {
                    Console.Write("\nInforme um número inteiro: ");
                    validacao = int.TryParse(Console.ReadLine(), out numeroJogador);

                    if (validacao == false)
                        Console.WriteLine("\nNúmero inválido!");

                } while (validacao == false);

                Random roleta = new Random();
                numeroComputador = roleta.Next(100);

                parOuImpar = (numeroJogador + numeroComputador) % 2 == 0 ? PAR : IMPAR;

                if (opcaoJogador == parOuImpar)
                    pontoDoJogador++;
                else
                    pontoDoComputador++;

                do
                {
                    Console.Write("\nDeseja jogar novamente ? [s - sim / n - não] ");
                    respostaDoUsuario = Console.ReadLine();

                    if (respostaDoUsuario.ToLower() != "s" && respostaDoUsuario.ToLower() != "n")
                        Console.WriteLine("\nResposta inválida!");

                } while (respostaDoUsuario.ToLower() != "s" && respostaDoUsuario.ToLower() != "n");

                Console.Clear();

            } while (respostaDoUsuario.ToLower() == "s");
            
            Console.WriteLine($"Jogador: {pontoDoJogador} x Computador: {pontoDoComputador}");

            if (pontoDoJogador > pontoDoComputador)
                Console.WriteLine("\nJogador ganhou!");
            else if (pontoDoJogador < pontoDoComputador)
                Console.WriteLine("\nComputador ganhou!");
            else
                Console.WriteLine("\nEmpatou!");
        }
    }
}
