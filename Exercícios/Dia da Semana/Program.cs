using System;

/*
 * O código a seguir tem como objetivo principal ler um número informado pelo usuário (de 1 a 7) e exibir na tela do usuário o nome do dia da semana correspondente. Se o número informado pelo usuário não estiver entre 1 e 7, será exibido "Dia inválido".
*/

/*
            Console.Write("Digite um número de 1 a 7: ");
            int dia = int.Parse(Console.ReadLine());

            if (dia == 1)
                Console.WriteLine("Domingo");
            else if (dia == 2)
                Console.WriteLine("Segunda-feira");
            else if (dia == 3)
                Console.WriteLine("Terça-feira");
            else if (dia == 4)
                Console.WriteLine("Quarta-feira");
            else if (dia == 5)
                Console.WriteLine("Quinta-feira");
            else if (dia == 6)
                Console.WriteLine("Sexta-feira");
            else if (dia == 7)
                Console.WriteLine("Sábado");
            else
                Console.WriteLine("Dia inválido");
            */

namespace Dia_da_Semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 7: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }
        }
    }
}
