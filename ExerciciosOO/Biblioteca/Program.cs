using System;


namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Models.Biblioteca biblioteca = new Models.Biblioteca();

            biblioteca.AdicionarLivro(new Models.Livro("Code Complete", "Steve McConnell", 2004));

            biblioteca.AdicionarLivro(new Models.Livro("The C Programming Language", "Brian W. Kernighan e Dennis M. Ritchie", 1978));

            biblioteca.AdicionarLivro(new Models.Livro("Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2008));

            biblioteca.AdicionarLivro(new Models.Livro("Refactoring: Improving the Design of Existing Code", "Martin Fowler", 1999));

            biblioteca.AdicionarLivro(new Models.Livro("Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans", 2003));

            Console.WriteLine("Lista de livros: \n");
            biblioteca.ListarLivros();
        }
    }
}
