using System;


namespace Profissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Programador dev = new Models.Programador();

            Console.WriteLine($"Cargo: {dev.Cargo} \nNome: {dev.Nome} \nIdade: {dev.Idade} \nSalário: {dev.Salario:C}");
            Console.WriteLine($"Tarefa: {dev.Funcao()}");
            Console.WriteLine($"Herança: {dev.GetHeranca()}\n");

            Models.DBA dba = new Models.DBA();

            Console.WriteLine($"Cargo: {dba.Cargo} \nNome: {dba.Nome} \nIdade: {dba.Idade} \nSalário: {dba.Salario:C}");
            Console.WriteLine($"Tarefa: {dba.Funcao()}");
            Console.WriteLine($"Herança: {dba.GetHeranca()}\n");

            Models.QA qa = new Models.QA();

            Console.WriteLine($"Cargo: {qa.Cargo} \nNome: {qa.Nome} \nIdade: {qa.Idade} \nSalário: {qa.Salario:C}");
            Console.WriteLine($"Tarefa: {qa.Funcao()}");
            Console.WriteLine($"Herança: {qa.GetHeranca()}");
        }
    }
}
