using System;
using System.Collections.Generic;


namespace NomesInvertidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "";
            Stack<char> nomes = new Stack<char>();        

            Console.Write("\nDigite uma palavra: ");
            palavra = Console.ReadLine();

            for(int i = 0; i < palavra.Length; i++)
            {
                nomes.Push(palavra[i]);
            }

            Console.Write("\nPalavra invertida: ");

            for (int i = nomes.Count; i > 0; i--)
            {
                Console.Write(nomes.Pop());
            }

            //foreach (char letra in nomes)
            //{
            //    Console.Write(letra);
            //}

            Console.WriteLine("");
        }
    }
}
