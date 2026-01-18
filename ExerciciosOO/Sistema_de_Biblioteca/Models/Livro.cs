using System;
using Sistema_de_Biblioteca.Interfaces;

namespace Sistema_de_Biblioteca.Models
{
    internal class Livro : ILivro
    {
        private static int id = 0;
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Ano { get; private set; }

        public Livro(string titulo, string autor, int ano) 
        {
            Id = ++id;
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public string LivroInfo()
        {
            return $"Título: {Titulo} \nAutor: {Autor} \nAno: {Ano}";
        }
    }
}
