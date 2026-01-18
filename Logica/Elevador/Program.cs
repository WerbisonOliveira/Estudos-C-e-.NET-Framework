using System;

/*
    * Faça um programa que mostre se um elevador pode entrar em funcionamento ou não.
    * Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador e
      3 pessoas irão utilizá-lo. Depois, solicitar o peso de cada pessoa e, no
      final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma dos pesos
      das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar
      em funcionamento.
*/

namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Elevador ====");
            Console.WriteLine("");

            Console.Write("Informe o peso máximo que o elevador suporta (Kg): ");
            double pesoMaximoDoElevador = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe o peso das três pessoas (Kg):");
            Console.WriteLine("");

            Console.Write("1º pessoa: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.Write("2º pessoa: ");
            double peso2 = double.Parse(Console.ReadLine());

            Console.Write("3º pessoa: ");
            double peso3 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            bool funcionamentoDoElevador = peso1 + peso2 + peso3 <= pesoMaximoDoElevador;

            #region "Solução com estrutura de decisão"
            /*
            if (peso1 + peso2 + peso3 <= pesoMaximoDoElevador)
            {
                Console.WriteLine("O elevador poderá entrar em funcionamento.");          
            }
            else
            {
                Console.WriteLine("Peso excedido, o elevador não poderá entrar em funcionamento.");
            }
            */
            #endregion

            #region "Solução com estrutura de seleção"
            /*
            switch (funcionamentoDoElevador)
            {
                case true:
                    Console.WriteLine("O elevador poderá entrar em funcionamento.");
                    break;
                default:
                    Console.WriteLine("Peso excedido, o elevador não poderá entrar em funcionamento.");
                    break;
            }
            */
            #endregion

            #region "Solução com operador condicional(ternário)"
            /*
            Console.WriteLine(funcionamentoDoElevador ? "O elevador poderá entrar em funcionamento." : "Peso excedido, o elevador não poderá entrar em funcionamento.");
            */
            #endregion

            Console.WriteLine("");

            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadLine();

        }
    }
}
