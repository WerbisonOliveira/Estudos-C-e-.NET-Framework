using System;


namespace Cadastro_de_aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Cadastro_de_aluno ====");
            Console.WriteLine();

            Console.WriteLine("Informe os dados:");
            Console.WriteLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = Math.Round((nota1 + nota2 + nota3) / 3, 1);

            Console.WriteLine();

            Console.WriteLine("==== Resultado ====");
            Console.WriteLine();

            Console.WriteLine($"Cadastro realizado com sucesso! \nAluno: {nome} \nIdade: {idade} \nMédia: {media}");
            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
