using Livros.Interfaces;
using System;

namespace Livros.Models
{
    internal class Livros : ILivros
    {
        public string Autor { get; set; }

        public string Titulo { get; set; }

        //Foi utilizado o conceito de sobrecarga nos construtores.
        public Livros() 
        { 

        }

        public Livros(string autor, string titulo) 
        { 
            Autor = autor;
            Titulo = titulo;
        }

        public string ExibirDados()
        {
            return $"Livro {Titulo} escrito por {Autor}";
        }

    }
       
}
