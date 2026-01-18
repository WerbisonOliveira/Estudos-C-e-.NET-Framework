using System;



namespace Clientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Clientes c1 = new Models.Clientes();
            c1.Id = 1;
            c1.Nome = "Werbison";
            c1.Idade = 24;
            Console.WriteLine(c1.ExibirDados());
        }
    }
}
