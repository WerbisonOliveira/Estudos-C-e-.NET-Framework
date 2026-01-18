using System;

/*
 * O usuario vai entrar com o nome do aluno e 5 notas para este aluno (estrutura de repetição).
 * Calcular a média e apresentar nome do aluno e sua média
 * "Aluno1 média 7."
 * Reprovado : < 5
 * Exame : >= 5 e < 7
 * Aprovado : >= 7
 * Colocar o programa em loop para o usuário entrar com quantos alunos ele desejar.
 * No final, o programa deve exibir a quantidade total de alunos e quantos foram reprovados, ficaram em exame e aprovados.
 * Total Alunos: 10
 * Reprovados: 2
 * Exame: 5
* Aprovados: 3
*/

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            const int TOTALDENOTAS = 5;
            string resposta = "", situacaoAluno = "", nome = "";
            int quantidadeDeAlunos = 0, aprovados = 0, exame = 0, reprovados = 0;

            do
            {
                double media = 0, somaDasNotas = 0, nota = 0;
                bool validacao;

                Console.WriteLine("==== Escola ====");

                Console.WriteLine("\nInforme o nome e notas do aluno(a):");

                do
                {
                    validacao = false;

                    Console.Write("\nNome do aluno(a): ");
                    nome = Console.ReadLine();

                    bool conversaoResultado = int.TryParse(nome, out int resultado);
                    bool verificaNome = string.IsNullOrWhiteSpace(nome);

                    if ( verificaNome == true || conversaoResultado == true )
                    {
                        Console.WriteLine("\nNome inválido!");
                        validacao = true;
                    }
                                    

                } while (validacao == true);
                

                for (int contador = 1; contador <= TOTALDENOTAS; contador++)
                {

                    do
                    {
                        Console.Write($"\nInforme a {contador}° nota: ");
                        nota = double.Parse(Console.ReadLine());
                        if (nota < 0 || nota > 10)
                        {
                            Console.WriteLine("\nNota inválida!");
                        }
                            

                    } while (nota < 0 || nota > 10);

                    somaDasNotas += nota;

                    media = somaDasNotas / TOTALDENOTAS;
                }

                if(media >= 7)
                {
                    situacaoAluno = "Aprovado(a)";
                    aprovados += 1;
                }
                else if (media >= 5 && media < 7)
                {
                    situacaoAluno = "Exame";
                    exame += 1;
                }
                else
                {
                    situacaoAluno = "Reprovado(a)";
                    reprovados += 1;
                }

                Console.Write($"\nAluno(a): {nome}. \n\nSituação: {situacaoAluno}. \n\nMédia: {media}");

                Console.Write("\n\nDeseja adicionar outro aluno(a)? [S/N] ");
                resposta = Console.ReadLine();

                Console.Clear();

                quantidadeDeAlunos++;
            } while (resposta.ToLower() == "s" || resposta.ToLower() == "sim");

            Console.WriteLine($"Total de alunos: {quantidadeDeAlunos}");
            Console.WriteLine($"Aprovados: {aprovados}");
            Console.WriteLine($"Exame: {exame}");
            Console.WriteLine($"Reprovados: {reprovados}");
        }
    }
}
