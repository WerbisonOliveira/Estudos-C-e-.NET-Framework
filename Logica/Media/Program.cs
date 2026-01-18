using System;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)

        /*
            * Solicita o número de faltas.
            * Verificar se o número de faltas é maior que 20.
            * Se maior que 20 faltas retorna uma mensagem de reprovado por faltas.
            * Se menor ou igual a 20 faltas é realizado a solicitação das três notas, verificado a média e retornado uma mensagem de aprovado, recuperação ou reprovado.
            * Solicite três notas para o usuário e calcule a média final.
        */
        {
            const int NUMEROMAXIMODEFALTAS = 20;

            Console.WriteLine("---Média----");

            Console.WriteLine("");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Total de faltas: ");
            int faltas = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (faltas <= NUMEROMAXIMODEFALTAS)
            {
                if (media >= 7)
                {
                    Console.WriteLine($"Média: {media:0.00} - Aprovado, Parabéns!");
                }
                else if (media >= 5)
                {
                    Console.WriteLine($"Média: {media:0.00} - Recuperação");
                }
                else
                {
                    Console.WriteLine($"Média: {media:0.00} - Infelizmente você não atingiu a média para ser aprovado(a).");
                }
            }
            else
            {
                Console.WriteLine("Aluno reprovado por ultrapassar limite de faltas!");
            }


            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
