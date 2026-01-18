using System;
using System.Collections.Generic;


/*
 * Crie uma lista de números inteiros.
 * Adicione 5 números escolhidos pelo usuário.
 * Exiba todos os números na tela.
 * Ordene os elementos em ordem crescente.
 * Depois em ordem decrescente.
 * Remova da lista todos os números pares. E mostre a lista atualizada.
*/

namespace ExibindoValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(5);
            int numeroDoUsuario, soma = 0;

            Console.WriteLine("Escolha 5 números para adicionar na lista");

            for (int i = 0; i < numeros.Capacity; i++)
            {
                Console.Write($"\nDigite o {i + 1}º número: ");
                numeroDoUsuario = int.Parse(Console.ReadLine()); 

                numeros.Add(numeroDoUsuario);

                soma += numeroDoUsuario;

            }

            Console.Write($"\nNúmeros escolhidos: ");
          
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
                
            }

            Console.WriteLine($"\n\nA soma de todos os números digitados é: {soma}");
            Console.WriteLine($"\nA média da soma de todos os valores é: {soma / numeros.Count}");

            Console.WriteLine("");
        }
    }
}
