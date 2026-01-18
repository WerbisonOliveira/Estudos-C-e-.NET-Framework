using System;

/*
     * Jogo
     * 
     * Soco  - s => 2 pontos
     * Chute - c => 5 pontos 
     * Magia - m => 10 pontos
     * 
     * Deseja executar um golpe (s-soco c-chute m-magia x-sair)?
     * 
     * x => sair
     * 
     * Soco(s)  => 10 => 20 pontos
     * Chute(s) => 3 => 15 pontos
     * Magia(s) => 4 => 40 pontos
     * Total de pontos => 75 pontos
     * 
     * -- Pressione ENTER para encerrar --
*/

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PONTUACAOSOCO = 2, PONTUACAOCHUTE = 5, PONTUACAOMAGIA = 10;
            int qtSocos = 0, qtChutes = 0, qtMagias = 0, pontosMaximoDeSocos = 0, pontosMaximoDeChutes = 0, pontosMaximoDeMagia = 0;
            string respostaDoUsuario = "s", opcao = "";

            do
            {
                Console.WriteLine("======== Jogo ========");

                Console.WriteLine("\nSoco  - s => 2 pontos \nChute - c => 5 pontos \nMagia - m => 10 pontos \nSair - x");

                do
                {
                    Console.Write("\nExecutar um golpe(s - soco c - chute m - magia x - sair) ? ");
                    opcao = Console.ReadLine();
                    if(opcao.ToLower() != "s" && opcao.ToLower() != "c" && opcao.ToLower() != "m" && opcao.ToLower() != "x")
                    {
                        Console.WriteLine("\nOpção inválida!");
                    }
                        
                } while (opcao.ToLower() != "s" && opcao.ToLower() != "c" && opcao.ToLower() != "m" && opcao.ToLower() != "x");

                switch (opcao.ToLower())
                {
                    case "s":
                        Console.WriteLine("\nSoco desferido!");
                        qtSocos++;
                        pontosMaximoDeSocos += PONTUACAOSOCO;
                        break;
                    case "c":
                        Console.WriteLine("\nChute desferido!");
                        qtChutes++;
                        pontosMaximoDeChutes += PONTUACAOCHUTE;
                        break;
                    case "m":
                        Console.WriteLine("\nMagia desferida!!");
                        qtMagias++;
                        pontosMaximoDeMagia += PONTUACAOMAGIA;
                        break;
                    case "x":
                        Console.WriteLine("\nEncerrando jogo...");
                        break;
                }

                if(opcao.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    do
                    {
                        Console.Write("\nDeseja executar outro golpe? [s - sim/ n - não] ");
                        respostaDoUsuario = Console.ReadLine();

                        if (respostaDoUsuario != "s" && respostaDoUsuario != "n")
                        {
                            Console.WriteLine("\nResposta inválida!");
                        }

                    } while (respostaDoUsuario != "s" && respostaDoUsuario != "n");


                    if (respostaDoUsuario.ToLower() == "s")
                    {
                        Console.Clear();
                    }
                }
             

            } while (respostaDoUsuario.ToLower() == "s");

            Console.WriteLine("\n--------------- Resultado ---------------");

            Console.WriteLine($"\nSoco(s)  => {qtSocos} => {pontosMaximoDeSocos}");
            Console.WriteLine($"\nChute(s)  => {qtChutes} => {pontosMaximoDeChutes}");
            Console.WriteLine($"\nMagia(s)  => {qtMagias} => {pontosMaximoDeMagia}");
            Console.WriteLine($"\nTotal de pontos  => {pontosMaximoDeSocos + pontosMaximoDeChutes + pontosMaximoDeMagia}");

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
