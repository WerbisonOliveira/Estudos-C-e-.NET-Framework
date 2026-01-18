using System;
using System.Collections.Generic;



namespace Convidados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> convidados = new HashSet<string>();
            int opcaoDoUsuario = 0;
            string nome = "";
            bool encerrar = false, validacao = false;

            do
            {
                Console.WriteLine("------ Convidados ------\n");

                Console.WriteLine("1 - Adicionar convidado");
                Console.WriteLine("2 - Verificar nome");
                Console.WriteLine("3 - Encerrar programa");

                do
                {
                    Console.Write("\nOpção: ");
                    validacao = int.TryParse(Console.ReadLine(), out opcaoDoUsuario);

                    if (!validacao)
                        Console.WriteLine("\nOpção inválida!");

                } while (!validacao);

                switch (opcaoDoUsuario)
                {
                    case 1:
                        Console.Write("\nDigite o nome do convidado: ");
                        nome = Console.ReadLine();

                        if (!convidados.Contains(nome.ToLower()))
                        {
                            convidados.Add(nome.ToLower());
                            Console.WriteLine("\nConvidado adicionado.");
                        }
                        else
                            Console.WriteLine("\nConvidado já está na lista!");
                        break;
                    case 2:
                        Console.Write("\nDigite o nome do convidado: ");
                        nome = Console.ReadLine();

                        if (!convidados.Contains(nome.ToLower()))
                        {
                            Console.WriteLine("\nConvidado não está na lista!");
                        }
                        else
                            Console.WriteLine("\nConvidado está na lista!");
                        break;
                    case 3:
                        Console.WriteLine("\nEncerrando...");
                        encerrar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (!encerrar);

            Console.WriteLine($"\nConvidados: {string.Join("-", convidados)}");
         
        }
    }
}
