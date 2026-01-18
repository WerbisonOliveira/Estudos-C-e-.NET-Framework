using Sistema_de_Biblioteca.Models;
using System;
using System.Collections.Generic;


namespace Sistema_de_Biblioteca.Interfaces
{
    internal interface IEmprestimo
    {
        Usuario Usuario { get; }
        List<Livro> Livros { get; }

        void AdicionarUsuario(Usuario usuario);
        void RemoverUsuario(Usuario usuario);
        void EmprestarLivro(Livro livro);
        void DevolverLivro(Livro livro);
        string ListarEmprestimos();
    }
}
