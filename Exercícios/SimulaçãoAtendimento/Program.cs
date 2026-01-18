using System;
using System.Collections.Generic;


namespace SimulaçãoAtendimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            Queue<int> senhas = new Queue<int>();
            int senha = 0, opcaoDoUsuario = 0, senhaRemovida = 0;
            string nomeDoCliente = "", clienteRemovido = "";
            bool encerrar = false, validacaoOpcao = false;


            do
            {
                Console.WriteLine("\n1 - Pegar senha \n2 - Chamar senha \n3 - Mostrar clientes na fila \n4 - Encerrar programa");

                do
                {
                    Console.Write("\nEscolha uma opção: ");
                    validacaoOpcao = int.TryParse(Console.ReadLine(), out opcaoDoUsuario);

                    if (!validacaoOpcao)
                        Console.WriteLine("\nErro! Digite somente números!");

                } while (!validacaoOpcao);

                switch (opcaoDoUsuario)
                {
                    case 1:
                        Console.Write("\nDigite seu nome: ");
                        nomeDoCliente = Console.ReadLine();

                        clientes.Enqueue(nomeDoCliente);

                        senhas.Enqueue(++senha);

                        Console.WriteLine($"\nCliente: {nomeDoCliente} \n\nSenha: {senha}");

                        break;
                    case 2:
                        if (clientes.Count > 0 && senhas.Count > 0)
                        {
                            clienteRemovido = clientes.Dequeue();
                            senhaRemovida = senhas.Dequeue();
                            Console.WriteLine($"\nChamando {clienteRemovido}, senha {senhaRemovida}");
                        }
                        else
                        {
                            Console.WriteLine("\nFila vazia!");
                        }
                        break;
                    case 3:
                        if (clientes.Count > 0)
                        {
                            Console.Write("\nClientes: ");

                            Console.Write(string.Join("-", clientes));

                        }
                        else
                        {
                            Console.WriteLine("\nFila vazia!");
                        }
                        break;
                    case 4:
                        if (clientes.Count > 0 && senhas.Count > 0)
                        {
                           
                            Console.WriteLine("\nA fila não está vazia!");
                        }
                        else
                        {
                            Console.WriteLine("\nEncerrando programa...");
                            encerrar = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();

                Console.Clear();


            } while (!encerrar);




        }
    }
}
