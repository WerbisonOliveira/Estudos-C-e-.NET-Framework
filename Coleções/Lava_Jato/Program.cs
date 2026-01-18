using System;
using System.Collections.Generic;

/*
 * Lavar Veículos
 * 
 * Cada vez que chega um veículo, este veículo recebe um número sequencial
 * e fica numa fila dentro do pátio para ser lavado. (FIFO) => QUEUE<int>
 * 
 * Conforme o veículo é lavado, ele é colocado em um galpão de entrega. LIST<int>
*
* Para entregá-lo, o cliente fornece o número do veículo. => Procurar o número do carro LIST<int>
* Se o número existir, o veículo é entregue, caso contrário ele ainda está no processo de lavagem.
* 
* Opções
* 1 - Receber carro para lavar
* 2 - Lavar
* 3 - Entregar carro => solicita número
* 4 - Encerrar programa => fila e lista (vazia) * 
*/

namespace Lava_Jato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> filaDeVeiculos = new Queue<int>();
            List<int> listaDeVeiculosLavados = new List<int>();
            int opcaoDoUsuario = 0, numero = 0;
            bool encerrar = false, validacao = false;

            do
            {
                Console.WriteLine("====== Lava Jato ======");

                Console.WriteLine("" +
                    "\n1 - Receber carro para lavar " +
                    "\n2 - Lavar " +
                    "\n3 - Entregar carro => solicita número " +
                    "\n4 - Encerrar programa => fila e lista (vazia)"
                );

                do
                {
                    Console.Write("\nEscolha uma opção: ");
                    validacao = int.TryParse(Console.ReadLine(), out opcaoDoUsuario);

                    if (!validacao)
                        Console.WriteLine("Inválido!");
                } while (!validacao);

                switch (opcaoDoUsuario)
                {
                    case 1:
                        filaDeVeiculos.Enqueue(++numero);
                        Console.WriteLine($"\nNúmero do carro: {numero}. Adicionado a fila para lavar!");
                        break;
                    case 2:
                        if (filaDeVeiculos.Count > 0)
                        {
                            int carro = filaDeVeiculos.Dequeue();

                            Console.WriteLine($"\nLavando carro com número {carro}");

                            listaDeVeiculosLavados.Add(carro);
                        }
                        else
                        {
                            Console.WriteLine("\nFila de carros vazia!");
                        }
                        break;
                    case 3:
                        Console.Write("\nDigite o número: ");
                        int numeroDoCarro = int.Parse(Console.ReadLine());

                        if (listaDeVeiculosLavados.Remove(numeroDoCarro))
                        {
                            Console.WriteLine("\nCarro entregue.");
                            listaDeVeiculosLavados.Remove(numeroDoCarro);
                        }
                        else  
                            Console.WriteLine("\nCarro ainda vai ser lavado!");
                        break;
                    case 4:
                        if (filaDeVeiculos.Count == 0 && listaDeVeiculosLavados.Count == 0)
                        {
                            Console.WriteLine("\nEncerrando programa...");
                            encerrar = true;
                        }
                        else
                        {
                            Console.WriteLine("\nAinda possue carros para lavar e ser entregue.");
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
