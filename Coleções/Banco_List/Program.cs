using System;
using System.Collections.Generic;

/*
 *
 * Controlar uma fila de um banco
 * 4 opções
 * 1 - Pegar senha (sequencial - valor inicial da senha é 1)
 * 2 - Chamar senha (chamar na sequencia)
 * 3 - Imprimir a fila 
 * 4 - Encerrar o programa (se a fila estiver vazia)
 * 
*/

/*
 *Tarefas
 * 1 - Continuar o teste de mesa do array - ParImpar
 * 2 - Fazer o teste de mesa da Lista - ParImpar
 * 3 - Fazer o teste de mesa do banco
 * 4 - Estudar Queue<T> e Stack<T>
 * 5 - Alterar Banco_List para Banco_Queue utilizando o Queue<T> - Criar um novo projeto Banco_Queue 
*/

namespace Banco_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> senhas = new List<int>();
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
                        senhas.Add(++senha);
                        Console.WriteLine($"\nSenha: {senha}");
                        break;
                    case 2:
                        if (senhas.Count > 0)
                        {
                            Console.WriteLine($"\nChamando senha {senhas[0]}");
                            senhas.RemoveAt(0); // Remove a primeira senha (FIFO)
                        }
                        else
                            Console.WriteLine("\nFila vazia! Nenhuma senha para chamar.");
                        break;
                    case 3:
                        if (senhas.Count > 0)
                        {
                            Console.Write("\nSenhas: ");
                            for (int i = 0; i < senhas.Count; i++)
                            {

                                Console.Write($"{senhas[i]} ");
                            }
                        }
                        else
                            Console.WriteLine("\nA fila está vazia!");
                        break;
                    case 4:
                        if(senhas.Count == 0)
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
