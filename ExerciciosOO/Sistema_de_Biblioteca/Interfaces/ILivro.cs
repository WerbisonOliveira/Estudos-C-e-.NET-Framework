using System;


namespace Sistema_de_Biblioteca.Interfaces
{
    internal interface ILivro
    {
        int Id { get; }
        string Titulo { get; }
        string Autor { get; }
        int Ano { get; }

        string LivroInfo();
    }
}
