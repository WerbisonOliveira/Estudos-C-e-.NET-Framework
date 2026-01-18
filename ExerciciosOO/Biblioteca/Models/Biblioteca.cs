using System;
using System.Collections.Generic;



namespace Biblioteca.Models
{
    internal class Biblioteca
    {

        List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            this.livros.Add(livro);
        }

        public void ListarLivros()
        {
            livros.ForEach((livro) => Console.WriteLine(livro.ExibirInfo()));
        }

    }
}
