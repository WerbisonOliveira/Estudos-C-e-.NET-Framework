using System;
using System.Collections.Generic;


namespace Banco_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> senhas = new Queue<int>();
            int escolhaDoUsuario = 0, senha = 0;
            bool encerrar = false, validacao;

            do
            {

                do
                {
                    Console.WriteLine("Controle de fila do banco:");
                    Console.WriteLine("\n1 - Pegar senha \n2 - Chamar senha \n3 - Imprimir a fila \n4 - Encerrar o programa");

                    Console.Write("\nEscolha uma opção: ");
                    validacao = int.TryParse(Console.ReadLine(), out escolhaDoUsuario);

                    if (!validacao)
                        Console.Clear();

                } while (!validacao);



                switch (escolhaDoUsuario)
                {
                    case 1:
                        senhas.Enqueue(++senha);
                        Console.WriteLine($"\nSenha: {senha}");
                        break;
                    case 2:
                        if (senhas.Count > 0)
                        {
                            int valorRemovido = senhas.Dequeue(); // Remove a primeira senha (FIFO)
                            Console.WriteLine($"\nChamando senha {valorRemovido}");
                           
                        }
                        else
                            Console.WriteLine("\nFila vazia! Nenhuma senha para chamar.");
                        break;
                    case 3:
                        if (senhas.Count > 0)
                        {
                            Console.Write("\nSenhas: ");
                            foreach (int numero in senhas)
                            {

                                Console.Write($"{numero} ");
                            }
                        }
                        else
                            Console.WriteLine("\nA fila está vazia!");
                        break;
                    case 4:
                        if (senhas.Count == 0)
                        {
                            Console.WriteLine("\nEncerrando o programa...");
                            encerrar = true;
                        }
                        else
                        {
                            Console.WriteLine("\nA fila não está vazia!");
                        }
                        break;
                    default:
                        Console.WriteLine("\nValor inválido!");
                        break;
                }

                Console.WriteLine("\n------- Pressione ENTER para continuar -------");
                Console.ReadLine();

                Console.Clear();

            } while (!encerrar);


        }
    }
}
