using System;
using System.Collections.Generic;


namespace CadastrarNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> nomes = new HashSet<string>();
            string nome = "";
            bool encerrar = false;

            do
            {
                Console.Write("\nDigite um nome (ou 'sair' para encerrar): ");
                nome = Console.ReadLine();

                if (nome.ToLower() == "sair")
                {
                    Console.WriteLine("\nSaindo...");
                    encerrar = true;
                }
                else if (!nomes.Add(nome.ToLower()))
                    Console.WriteLine("\nEsse nome já foi adicionado!");
                else
                    Console.WriteLine("\nNome cadastrado com sucesso!");

                Console.WriteLine("\nPresione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (!encerrar);

            Console.Write("\nNomes cadastrados: ");
            Console.Write(string.Join("-", nomes));

            //Console.Write("\nNomes cadastrados: ");
            //foreach (string n in nomes)
            //{
            //    Console.Write(n + " ");
            //}

            Console.WriteLine("");

        }
    }
}
