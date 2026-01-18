using System;

namespace Biblioteca.Models
{
    internal class Livro
    {
        private string titulo; // Poderia ser feito com propriedade
        private string autor;
        private int ano;

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
        }

        public string ExibirInfo()
        {
            return $"Título: {titulo} \nAutor: {autor} \nAno: {ano} \n";
        }
    }
}
