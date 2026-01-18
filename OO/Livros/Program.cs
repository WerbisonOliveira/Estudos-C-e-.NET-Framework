using Livros.Models;
using System;



namespace Livros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Livros livro1 = new Models.Livros();
            livro1.Autor = "Dante Alighieri";
            livro1.Titulo = "A Divina Comédia";

            Console.WriteLine(livro1.ExibirDados());

            Models.Livros livro2 = new Models.Livros("William Shakespeare", "A Comédia dos Erros");

            Console.WriteLine(livro2.ExibirDados());

            

        }
    }
}
