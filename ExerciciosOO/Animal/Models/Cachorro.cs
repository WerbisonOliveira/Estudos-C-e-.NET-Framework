using System;


namespace Animal.Models
{
    internal abstract class Cachorro : ICachorro
    {

        public string Nome { get; protected set; }

        public string Tamanho { get; protected set; }

        public string Raca { get; protected set; }

        public Cachorro() 
        {
            
        }

        public Cachorro(string nome, string raca, string tamanho) 
        {
            Nome = nome;
            Raca = raca;
            Tamanho = tamanho;
        }

        public virtual string Latir()
        {
            return $"Au au au au!!";
        }

        public virtual string GetHeranca()
        {
            return "Animal";
        }
    }
}
