using System;


namespace Sistema_de_Biblioteca.Interfaces
{
    internal interface IUsuario
    {
        int Id { get; }
        string Nome { get; }
        string Email { get; }

        string UsuarioInfo();
    }
}
