using System;
using System.Collections.Generic;



namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> fila = new Queue<int>();
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
                        fila.Enqueue(valor);
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

            foreach (int item in fila)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("");


        }
    }
}
