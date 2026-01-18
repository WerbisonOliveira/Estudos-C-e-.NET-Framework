using System;
using System.Collections.Generic;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdeNumeros = 10;
            int i = 0;

            Queue<int> fila = new Queue<int>(qtdeNumeros);

            Random roleta = new Random();

            int contadorDeVezes = 0;

            do
            {
                int valorSorteado = roleta.Next(50);
                if (!fila.Contains(valorSorteado))
                {
                    fila.Enqueue(valorSorteado);
                    i++;
                }
                                      
                contadorDeVezes++;
                    
            } while (i < qtdeNumeros);

            Console.Write($"\nO número de vezes que o loop rodou: {contadorDeVezes} ");
            Console.Write("\nOs números sorteados foram: ");
            foreach (var item in fila)
            {
                Console.Write(item);
                Console.Write("  ");

            }

            #region "com HashSet"
            /*
            int qtdeNumeros = 10;
            int i = 0;

            HashSet<int> fila = new HashSet<int>(qtdeNumeros);

            Random roleta = new Random();

            int contadorDeVezes = 0;

            do
            {
                int valorSorteado = roleta.Next(50);
                if(fila.Add(valorSorteado))
                        i++;


                contadorDeVezes++;

            } while (i < qtdeNumeros);

            Console.Write($"\nO número de vezes que o loop rodou: {contadorDeVezes} ");
            Console.Write("\nOs números sorteados foram: ");
            foreach (var item in fila)
            {
                Console.Write(item);
                Console.Write("  ");
            }
            */
            #endregion
        }
    }
}
