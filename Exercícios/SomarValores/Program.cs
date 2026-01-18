using System;
using System.Linq;

/*
 * Leia 5 números inteiros (digitados pelo usuário), armazene em um array e calcule a soma deles.
*/

namespace SomarValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int qtdNumeros = 5;
            double[] valores = new double[qtdNumeros];
            double soma = 0;
            double maiorValor = 0;
            double menorValor = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"\nDigite o {i + 1}º valor: ");
                valores[i] = int.Parse(Console.ReadLine());

                soma += valores[i];

                if (i == 0)
                    maiorValor = valores[i];
                else if (valores[i] > maiorValor)
                    maiorValor = valores[i];
     
                if(i == 0)
                    menorValor = valores[i];
                else if (valores[i] < menorValor)
                    menorValor = valores[i];
                
            }

            Console.WriteLine($"\nA soma de todos os valores digitados é: {soma}");
            Console.WriteLine($"\nA soma de todos os valores digitados é: {soma / valores.Length}");
            Console.WriteLine($"\nO maior valor digitado foi: {maiorValor}");
            Console.WriteLine($"\nO menor valor digitado foi: {menorValor}");

        }
    }
}
