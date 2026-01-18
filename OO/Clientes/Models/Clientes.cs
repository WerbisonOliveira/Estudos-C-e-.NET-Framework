using System;



namespace Clientes.Models
{
    internal class Clientes
    {
        private static int id = 0;

        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Clientes() 
        {
            Id = ++id;
            Nome = string.Empty; // => é a mesma coisa de ""
            Idade = 0;
        }

        public string ExibirDados()
        {
            return $"Id: {Id} \nNome:{Nome} \nIdade: {Idade}";
        }
    }
}
