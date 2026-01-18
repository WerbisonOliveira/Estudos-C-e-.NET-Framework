using System;



namespace Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario Joao = new Funcionario("João", "Silva", 1500);

            Console.WriteLine("Valor Xerox para funcionário: {0}", Joao.valorCopiasXerox(10));

            Aluno zeca = new Aluno("Zeca", "Beats", "RA3210");

            Console.WriteLine("Valor Xerox para aluno: {0}", zeca.valorCopiasXerox(10));
        }
    }
}
