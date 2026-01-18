using System;
using System.Collections.Generic;

/*Faça um programa que receba 15 números e no final imprimir as listas de numeros pares e impares*/

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Com array - teste de mesa"
            /*
            const int QUANTIDADE = 6;
            int[] impares = new int[QUANTIDADE];
            int[] pares = new int[QUANTIDADE];
            int numeroDoUsuario, qtdPares = 0, qtdImpares = 0;          

            for (int i = 0; i < QUANTIDADE; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeroDoUsuario = int.Parse(Console.ReadLine());

                if (numeroDoUsuario % 2 == 0)
                {
                    pares[qtdPares++] = numeroDoUsuario;
                    
                }
                else
                {
                    impares[qtdImpares++] = numeroDoUsuario;
                    
                }
            }

            Console.WriteLine("\n===== RESULTADOS =====");

            Console.WriteLine("Números pares:");
            for (int i = 0; i < qtdPares; i++)
            {
                Console.Write(pares[i] + " ");
            }

            Console.WriteLine("\n\nNúmeros ímpares:");

            for (int i = 0; i < qtdImpares; i++)
            {
                Console.Write(impares[i] + " ");
            }

            Console.WriteLine("\n======================");
            */
            #endregion

            #region "com List - teste de mesa"
            
            const int QUANTIDADE = 6;
            int numeroDoUsuario;

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < QUANTIDADE; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeroDoUsuario = int.Parse(Console.ReadLine());

                if (numeroDoUsuario % 2 == 0)
                {
                    pares.Add(numeroDoUsuario);

                }
                else
                {
                    impares.Add(numeroDoUsuario);

                }
            }

            Console.WriteLine("\n===== RESULTADOS =====");

            Console.Write("\nNúmeros pares: ");
            for (int i = 0; i < pares.Count; i++)
            {
                Console.Write(pares[i] + " ");
            }

            Console.Write("\n\nNúmeros ímpares: ");

            for (int i = 0; i < impares.Count; i++)
            {
                Console.Write(impares[i] + " ");
            }

            Console.WriteLine("\n======================");
            
            #endregion
        }
    }


}
  

