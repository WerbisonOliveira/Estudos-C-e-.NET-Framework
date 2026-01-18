using System;

/*
 * Crie um array de 5 números inteiros e exiba todos os valores na tela.
*/

namespace MostrarValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 9, 5, 7, 8, 23 };

            string[] nome = { "João", "Werbison" };


            #region "Sem estrutura de repetição"
            /*
            Console.Write(numeros[0]);
            Console.Write(numeros[1]);
            Console.Write(numeros[2]);
            Console.Write(numeros[3]);
            Console.Write(numeros[4]);
            Console.WriteLine(nome[0]);
            Console.WriteLine(nome[1]);
            */
            #endregion

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"índice {i} = {numeros[i]}");

            }

            for (int i = nome.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"índice {i} = {nome[i]}");

            }

        }
    }
}
