using System;
using System.Collections.Generic;


namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();
            int valor = 0;
            bool validacao = false;
            string respostaDoUusuario = "";


            do
            {
                do
                {
                    Console.Write("\nDigite um valor para adicionar na fila: ");
                    validacao = int.TryParse(Console.ReadLine(), out valor);

                    if (validacao)
                        pilha.Push(valor);
                    else
                        Console.WriteLine("\nValor inválido!");

                } while (!validacao);

                Console.Write("\nDeseja adicionar outro valor na fila? [s - sim / n - não] ");
                respostaDoUusuario = Console.ReadLine();

                Console.WriteLine("\n------- Pressione ENTER para continuar -------");
                Console.ReadLine();

                Console.Clear();

            } while (respostaDoUusuario == "s" || respostaDoUusuario == "S");

            Console.Write("Valores da lista: ");

            foreach (int item in pilha)
            {
                Console.Write(item + " ");
            }
           
            Console.WriteLine("");
        }
    }
}
