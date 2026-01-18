using System;
using System.Collections.Generic;


namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() {1, 2, 4, 4, 5, 6, 7, 9, 10, 10, 3, 3, 1 };

            HashSet<int> valores = new HashSet<int>(lista);

            Console.Write("Valores com duplicação: ");
            foreach (var valor in lista)
            {
                Console.Write($"{valor} ");
            }

            Console.Write("\nValores sem duplicação: ");
            foreach(var valor in valores)
            {
                Console.Write($"{valor} ");
            }

            //------------------------------------------

            HashSet<string> nomes = new HashSet<string>() {"casa", "carro", "jardim", "garagem"};
            HashSet<string> palavras = new HashSet<string>() { "casa", "moto", "jardim", "teto" };


            Console.Write("\n\nConjunto nomes: ");
            foreach (var nome in nomes)
            {
                Console.Write(nome + " ");
            }

            Console.Write("\n\nConjunto palavras: ");
            foreach (var palavra in palavras)
            {
                Console.Write(palavra + " ");
            }

            nomes.IntersectWith( palavras );

            Console.Write("\n\nPalavras que existem nos dois conjuntos: ");
            foreach (var palavra in nomes)
            {
                Console.Write(palavra + " ");
            }

            //-------------------------------------------------------

            HashSet<int> numeros = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            HashSet<int> pares = new HashSet<int>() { 1, 2, 4, 6, 8, 10 };

            numeros.ExceptWith(pares);

            Console.Write("\n\nValores que estão somente no primeiro conjunto: ");
            foreach (var valor in numeros)
            {
                Console.Write($"{valor} ");
            }

            numeros.Remove(3);
            Console.WriteLine("\n\nValor 3 removido do conjunto!");

            Console.Write("\nValores que estão somente no primeiro conjunto atualizado: ");
            foreach (var valor in numeros)
            {
                Console.Write($"{valor} ");
            }

            //---------------------------------------------

            HashSet<char> caractere = new HashSet<char>();

            Console.Write("\n\nDigite uma palavra: ");
            string palavraDoUsuario = Console.ReadLine();

            int contador = 0;

            for (int i = 0; i < palavraDoUsuario.Length; i++)
            {
                if (!caractere.Add(palavraDoUsuario[i]))
                    contador++;
                    
            }

            if (contador > 0)
                Console.Write("\nPalavra com caractere repetido!");
            else
                Console.Write("\nPalavra não possui caractere repetido!");

                Console.Write("\n\nCaracteres adicionados: ");
            foreach (char c in caractere)
            {
                Console.Write(c + " ");
            }

            //-------------------------------------------------

            HashSet<string> palavrasNãoRepetidas = new HashSet<string>() { "casa", "moto", "jardim", "teto", "casa", "teto", "hoje", "prova", "teste", "coleções", "array", "array" };

            Console.Write($"\n\nNo conjunto existem: {palavrasNãoRepetidas.Count} palavras");
            

        }

    }
}
