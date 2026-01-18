using System;

/*
     * --Tabuada--
     * 
     * Informe o número da tabuada: 5
     * 5 x 0 = 0
     * 5 x 1 = 5
     * 5 x 2 = 10
     * .
     * .
     * .
     * 5 x 10 = 50
     * 
     * Pressione o ENTER para encerrar.
*/

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Tabuada ====");
            Console.WriteLine("");

            Console.WriteLine("Informe a operação matemática e o número para tabuada:");
            Console.WriteLine("");

            Console.WriteLine("1 - Adição \n2 - Subtração \n3 - Multiplicação \n4 - Divisão");
            Console.WriteLine("");

            Console.Write("Informe a operação: ");
            int operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if(operacao >= 1 && operacao <= 4)
            {
                Console.Write("Informe o número da tabuada: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                        
                switch (operacao)
                {
                    case 1:
                        Console.WriteLine($"{numero} + 0 = {numero + 0}");
                        Console.WriteLine($"{numero} + 1 = {numero + 1}");
                        Console.WriteLine($"{numero} + 2 = {numero + 2}");
                        Console.WriteLine($"{numero} + 3 = {numero + 3}");
                        Console.WriteLine($"{numero} + 4 = {numero + 4}");
                        Console.WriteLine($"{numero} + 5 = {numero + 5}");
                        Console.WriteLine($"{numero} + 6 = {numero + 6}");
                        Console.WriteLine($"{numero} + 7 = {numero + 7}");
                        Console.WriteLine($"{numero} + 8 = {numero + 8}");
                        Console.WriteLine($"{numero} + 9 = {numero + 9}");
                        Console.WriteLine($"{numero} + 10 = {numero + 10}");
                        break;
                    case 2:
                        Console.WriteLine($"{numero} - 0 = {numero - 0}");
                        Console.WriteLine($"{numero} - 1 = {numero - 1}");
                        Console.WriteLine($"{numero} - 2 = {numero - 2}");
                        Console.WriteLine($"{numero} - 3 = {numero - 3}");
                        Console.WriteLine($"{numero} - 4 = {numero - 4}");
                        Console.WriteLine($"{numero} - 5 = {numero - 5}");
                        Console.WriteLine($"{numero} - 6 = {numero - 6}");
                        Console.WriteLine($"{numero} - 7 = {numero - 7}");
                        Console.WriteLine($"{numero} - 8 = {numero - 8}");
                        Console.WriteLine($"{numero} - 9 = {numero - 9}");
                        Console.WriteLine($"{numero} - 10 = {numero - 10}");
                        break;
                    case 3:
                        Console.WriteLine($"{numero} * 0 = {numero * 0}");
                        Console.WriteLine($"{numero} * 1 = {numero * 1}");
                        Console.WriteLine($"{numero} * 2 = {numero * 2}");
                        Console.WriteLine($"{numero} * 3 = {numero * 3}");
                        Console.WriteLine($"{numero} * 4 = {numero * 4}");
                        Console.WriteLine($"{numero} * 5 = {numero * 5}");
                        Console.WriteLine($"{numero} * 6 = {numero * 6}");
                        Console.WriteLine($"{numero} * 7 = {numero * 7}");
                        Console.WriteLine($"{numero} * 8 = {numero * 8}");
                        Console.WriteLine($"{numero} * 9 = {numero * 9}");
                        Console.WriteLine($"{numero} * 10 = {numero * 10}");
                        break;
                    default:                       
                        Console.WriteLine($"{numero} / 1 = {(double) numero / 1}");
                        Console.WriteLine($"{numero} / 2 = {(double) numero / 2}");
                        Console.WriteLine($"{numero} / 3 = {(double) numero / 3}");
                        Console.WriteLine($"{numero} / 4 = {(double) numero / 4}");
                        Console.WriteLine($"{numero} / 5 = {(double) numero / 5}");
                        Console.WriteLine($"{numero} / 6 = {(double) numero / 6}");
                        Console.WriteLine($"{numero} / 7 = {(double) numero / 7}");
                        Console.WriteLine($"{numero} / 8 = {(double) numero / 8}");
                        Console.WriteLine($"{numero} / 9 = {(double) numero / 9}");
                        Console.WriteLine($"{numero} / 10 = {(double) numero / 10}");
                        break;
                }
           
            }
            else
            {
                Console.WriteLine("Operação inválida. Escolha uma das operações disponíveis.");             
            }


                #region "Solução sem estrutura de repetição"
                /*
                Console.WriteLine($"{numero} * 0 = {numero * 0}");
                Console.WriteLine($"{numero} * 1 = {numero * 1}");
                Console.WriteLine($"{numero} * 2 = {numero * 2}");
                Console.WriteLine($"{numero} * 3 = {numero * 3}");
                Console.WriteLine($"{numero} * 4 = {numero * 4}");
                Console.WriteLine($"{numero} * 5 = {numero * 5}");
                Console.WriteLine($"{numero} * 6 = {numero * 6}");
                Console.WriteLine($"{numero} * 7 = {numero * 7}");
                Console.WriteLine($"{numero} * 8 = {numero * 8}");
                Console.WriteLine($"{numero} * 9 = {numero * 9}");
                Console.WriteLine($"{numero} * 10 = {numero * 10}");
                */
                #endregion

                #region "Solução com Estrutura de repetição for"
                /*
                for (int contador = 0; contador <= 10; contador++)
                    Console.WriteLine($"{numero} * {contador} = {numero * contador}");

                */
                #endregion

                #region "Solução com Estrutura de repetição while"
                /*
                int contador = 0;
                while(contador <= 10)
                {
                    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                    contador++;
                }
                */
                #endregion

                #region "Solução com Estrutura de repetição do/while"
                /*
                int contador = 0;
                do
                {
                    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                    contador++;
                }
                while (contador <= 10);
                */
                #endregion

            Console.WriteLine("");

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();

        }
    }
}
