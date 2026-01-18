using System;


namespace Livros.Interfaces
{
    internal interface ILivros
    {
        string Autor { get; set; }
        string Titulo { get; set; }

        string ExibirDados();
    }
}
