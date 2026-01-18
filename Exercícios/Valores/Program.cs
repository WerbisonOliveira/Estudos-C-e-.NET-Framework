using System;
using System.Collections.Generic;

/*
 * Peça ao usuário um número.
 * Verifique se ele existe na lista.
 * Informe a posição do número (índice) se existir.
*/


namespace Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {45, 67, 33, 17, 12, 10, 6, 8, 2, 31};

            List<int> valores = new List<int>(numeros);

            int numeroDoUsuario = 0;

            Console.Write("Digite um valor para saber se ele existe na lista: ");
            numeroDoUsuario = int.Parse(Console.ReadLine());

            if (valores.Contains(numeroDoUsuario))
            {
                Console.WriteLine($"\nValor existe na lista! Esta no índice: {valores.IndexOf(numeroDoUsuario)}");
            } 
            else
                Console.WriteLine("\nValor não existe na lista!");


            valores.Sort();

            Console.Write("\nLista em ordem crescente: ");

            foreach (int valor in valores)
                Console.Write(valor + " ");

            valores.Reverse();

            Console.Write("\n\nLista em ordem decrescente: ");

            foreach (int valor in valores)
                Console.Write(valor + " ");

            Console.Write("\n\nNúmeros pares removidos! Lista atualizada: ");

            for (int i = 0; i < valores.Count; i++)
            {
                if (valores[i] % 2 == 0)
                    valores.Remove(valores[i]);
                else
                    Console.Write(valores[i] + " ");
            }
            
            Console.WriteLine("");
        }
    }
}
