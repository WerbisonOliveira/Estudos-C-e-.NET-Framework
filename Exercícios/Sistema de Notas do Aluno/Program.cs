using System;

namespace Sistema_de_Notas_do_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("==== Sistema de Notas do Aluno ====");

            Console.Write("\nInforme o nome do aluno: ");
            string nomeDoAluno = Console.ReadLine();

            Console.Write("\nInforme a nota do aluno: ");
            double notaDoAluno = double.Parse(Console.ReadLine());

            if(notaDoAluno >= 0 && notaDoAluno <= 10)
            {
                string classificacaoDoAluno = "";

                if (notaDoAluno == 10)
                {
                    classificacaoDoAluno = "Excelente";
                }
                else if (notaDoAluno >= 9 && notaDoAluno < 10)
                {
                    classificacaoDoAluno = "Ótimo";
                }
                else if (notaDoAluno >= 7 && notaDoAluno < 9)
                {
                    classificacaoDoAluno = "Bom";
                }
                else if (notaDoAluno >= 5 && notaDoAluno < 7)
                {
                    classificacaoDoAluno = "Regular";
                }
                else
                {
                    classificacaoDoAluno = "Insuficiente";
                }

                string situaçãoDoAluno = notaDoAluno >= 6 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"\nAluno: {nomeDoAluno} \nNota: {notaDoAluno} \nClassificação: {classificacaoDoAluno} \nSituação: {situaçãoDoAluno} ");
            }
            else
            {
                Console.WriteLine("Nota inválida!");
            }

            Console.WriteLine("\nPressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
