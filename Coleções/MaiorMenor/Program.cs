using System;
using System.Collections.Generic;
using System.Linq;

/*
Crie um programa em C# que:

Crie uma lista de números inteiros.

Permita ao usuário digitar 5 números inteiros e adicione-os à lista.

Exiba todos os números armazenados.

Mostre o maior e o menor número da lista.
*/

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QUANTIDADE = 5;
            List<int> list = new List<int>(QUANTIDADE);
            int maior = int.MinValue;// Adiciona o menor número possível de um tipo int
            int menor = int.MaxValue;// Adiciona o maior número possível de um tipo int
 
            int numeroDousuario = 0;

            for (int i = 0; i < QUANTIDADE; i++ )
            {
                Console.Write("\nDigite um número: ");
                numeroDousuario = int.Parse(Console.ReadLine());
                list.Add(numeroDousuario);
            }

            Console.Write("\nLista: ");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");

                if (list[i] > maior)
                    maior = list[i];

                if (list[i] < menor)
                    menor = list[i];
            }

            Console.WriteLine($"\n\nMaior valor da lista: {maior}");
            Console.WriteLine($"\nMenor valor da lista: {menor}");

            /*
            list.Sort();
            Console.WriteLine($"\nMaior valor da lista: {list[list.Count - 1]}");
            Console.WriteLine($"\nMenor valor da lista: {list[0]}");
            */

            /*
            Console.WriteLine($"\nMaior valor da lista: {list.Max()}");
            Console.WriteLine($"\nMenor valor da lista: {list.Min()}");
            */
        }
    }
}
