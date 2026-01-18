using System;

//Preencha um array com 15 números inteiros aleatórios e mostre quantos são pares e quantos são ímpares.

namespace ParOuImparArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0;
            bool valorExiste = false;

            int[] valores = { 20, 16, 34, 78, 90, 12, 13, 10, 24, 56, 30, 67, 3, 7, 5 };

            for(int i = 0; i < valores.Length; i++)
            {
                if (valores[i] % 2 == 0)
                    par++;
                else
                    impar++;
            } 
            
            Console.WriteLine($"No array tem {par} valor(es) par(es) e {impar} valor(es) ímpar(es)");

            Console.Write("\nDigite um valor para verificar se existe no array: ");
            int valor = int.Parse(Console.ReadLine());

            //Verificar se um número existe

            foreach (int item in valores)
            {
                if (item == valor)
                {
                    valorExiste = true;
                    break;
                }                             
            }

            if(valorExiste == true)
                Console.WriteLine($"\nO número {valor} existe no array!");
            else
                Console.WriteLine($"\nO número {valor} não existe no array!");

            Console.WriteLine("");

            //Mostra os valores na sequência normal

            foreach (int item in valores)
            {
                Console.Write($"{item}\t");
                
            }

            Console.WriteLine("");

            //Mostra os valores na sequência inversa

            for (int i = valores.Length - 1; i > -1; i--)
            {
                Console.Write($"{valores[i]}\t");
            }

            Console.WriteLine("");

        }
    }
}
