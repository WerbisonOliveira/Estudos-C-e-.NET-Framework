using System;
using System.Collections.Generic;
/*
 * Faça um programa para gerenciar senhas numéricas referentes à fila de atendimento de um banco, compreendendo senhas para atendimento comum e prioritário. As senhas são números sequenciais inteiros maiores que 0 (zero) e não podem ser repetidas durante a execução do programa.
   Todas as senhas devem ser ordenadas por ordem de chegada, mas as senhas de atendimento prioritário devem ser chamadas ANTES das senhas comuns, ou seja, as senhas comuns só podem ser chamadas quando não existirem senhas de atendimento prioritário.
    Assim, o programa deve ter cinco opções de entrada para o usuário:
    1. Gerar senha para atendimento comum;
    2. Gerar senha para atendimento prioritário;
    3. Chamada da senha para atendimento;
    4. Visualizar fila de chamada;
    5. Encerramento do atendimento;
    Ressalta-se que:
    • Opção 3 – Chamada da senha: deve exibir a senha do atendimento ou informar ao usuário que não existem
    mais senhas na fila.
    • Opção 4 – Visualização da fila: ao exibir a fila de chamadas, as senhas de atendimento prioritário têm
    preferência em relação às senhas de atendimento comum.
    • Opção 5 – Encerramento do atendimento: só poderá ser executada quando não existirem mais senhas para
    atendimento. Nesse caso, deve ser exibida a quantidade de senhas comuns e prioritárias chamadas
    acompanhada da mensagem “Atendimento encerrado.”. Caso ainda existam pessoas para serem atendidas,
    deve ser exibida a mensagem “Atendimento não pode ser encerrado.”
    Importante: Para fazer o menu desse programa, baseie-se no programa que fizemos durante as aulas para tratar a
    fila de um banco dentro da solução Colecoes.
 */

namespace GerenciadorDeSenhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<uint> comum = new Queue<uint>();
            Queue<uint> prioritaria = new Queue<uint>();
            uint senha = 0, opcaoDoUsuario = 0, qtdSenhasComuns = 0, qtdSenhasPrioritaria = 0;
            bool validacao = false, encerrar = false;

            do
            {
                Console.WriteLine("----- Gerenciador de senhas -----\n");

                Console.WriteLine("1 - Pegar senha comum");
                Console.WriteLine("2 - Pegar senha prioritária");
                Console.WriteLine("3 - Chamar senha");
                Console.WriteLine("4 - Imprimir a fila");
                Console.WriteLine("5 - Encerrar o programa");

                do
                {
                    Console.Write("\nEscolha uma Opção: ");
                    validacao = uint.TryParse(Console.ReadLine(), out opcaoDoUsuario);

                    if (!validacao)
                        Console.WriteLine("\nOpção inválida.");

                } while (!validacao);

                switch (opcaoDoUsuario) {

                    case 1:
                        comum.Enqueue(++senha);
                        Console.Write($"\nSenha comum: {senha}");
                        qtdSenhasComuns++;
                        break;
                    case 2:
                        prioritaria.Enqueue(++senha);
                        Console.Write($"\nSenha prioritária: {senha}");
                        qtdSenhasPrioritaria++;
                        break;
                    case 3:
                        if(prioritaria.Count > 0)
                            Console.WriteLine($"\nChamando senha {prioritaria.Dequeue()} da fila prioritária");
                        else if (comum.Count > 0)
                            Console.WriteLine($"\nChamando senha {comum.Dequeue()} da fila comum");
                        else
                            Console.WriteLine($"\nNão existem mais senhas para serem chamadas.");
                        break;
                    case 4:
                        if (prioritaria.Count > 0 || comum.Count > 0)
                        {
                            Console.Write("\nFila: ");
                            foreach (var senhas in prioritaria)
                            {
                                Console.Write($"{senhas} ");
                            }

                            foreach (var senhas in comum)
                            {
                                Console.Write($"{senhas} ");
                            }
                        }
                        else
                            Console.WriteLine("\nFila vazia.");
                        break;
                    case 5:
                        if(prioritaria.Count == 0 && comum.Count == 0)
                        {
                            Console.WriteLine($"\nSenhas comuns chamadas: {qtdSenhasComuns}");
                            Console.WriteLine($"\nSenhas prioritárias chamadas: {qtdSenhasPrioritaria}");
                            Console.WriteLine("\nAtendimento encerrado.");
                            encerrar = true;
                        }
                        else 
                            Console.WriteLine("\nAtendimento não pode ser encerrado.");
                        break;
                    default:
                        Console.WriteLine("\nOpção não existe.");
                        break;
                      
                }

                Console.WriteLine("\n\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (!encerrar);

        }
    }
}
