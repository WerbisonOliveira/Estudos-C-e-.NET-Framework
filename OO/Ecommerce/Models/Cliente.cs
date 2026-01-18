using System;



namespace Ecommerce.Models
{
    internal class Cliente
    {
        private static int id = 0;

        public int Id { get; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, int idade)
        {
            Id = ++id;
            Nome = nome;
            Idade = idade;
        }

    }
}
