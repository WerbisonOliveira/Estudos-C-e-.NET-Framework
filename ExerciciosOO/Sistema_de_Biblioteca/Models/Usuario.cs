using System;
using Sistema_de_Biblioteca.Interfaces;

namespace Sistema_de_Biblioteca.Models
{
    internal class Usuario : IUsuario
    {
        private static int id = 0;
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Usuario(string nome, string email) 
        {
            Id = ++id;
            Nome = nome;
            Email = email;
        }

        public string UsuarioInfo()
        {
            return $"Usuário: {Nome} \nEmail: {Email}";
        }
    }
}
