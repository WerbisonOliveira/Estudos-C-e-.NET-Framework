using Sistema_de_Biblioteca.Interfaces;
using System;
using System.Collections.Generic;


namespace Sistema_de_Biblioteca.Models
{
    internal class Emprestimo : IEmprestimo
    {
        public Usuario Usuario { get; private set; }
        public List<Livro> Livros { get; }

        public Emprestimo(Usuario usuario)
        {
            Livros = new List<Livro>();
            Usuario = usuario;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        public void RemoverUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        public void EmprestarLivro(Livro livro)
        {
            if (Livros.Count < 3)
                Livros.Add(livro);
            else
                throw new ArgumentException("Você chegou ao limite de emprestimos de livros por vez!");

        }
        public void EmprestarLivro(Livro livro, Livro livro2)
        {
            if (Livros.Count < 3)
            {
                Livros.Add(livro);
                Livros.Add(livro2);
            }             
            else
                throw new ArgumentException("Você chegou ao limite de emprestimos de livros por vez!");

        }
        public void EmprestarLivro(Livro livro, Livro livro2, Livro livro3)
        {
            if (Livros.Count < 3)
            {
                Livros.Add(livro);
                Livros.Add(livro2);
                Livros.Add(livro3);
            }              
            else
                throw new ArgumentException("Você chegou ao limite de emprestimos de livros por vez!");
        }

        public void DevolverLivro(Livro livro)
        {
            Livros.Remove(livro);
        }
        public void DevolverLivro(Livro livro, Livro livro2)
        {
            Livros.Remove(livro);
            Livros.Remove(livro2);
        }
        public void DevolverLivro(Livro livro, Livro livro2, Livro livro3)
        {
            Livros.Remove(livro);
            Livros.Remove(livro2);
            Livros.Remove(livro3);
        }

        public string ListarEmprestimos()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var livro in Livros) 
            { 
                sb.Append(livro.Titulo + " ");
            }
            return sb.ToString();
        }

    }
}
