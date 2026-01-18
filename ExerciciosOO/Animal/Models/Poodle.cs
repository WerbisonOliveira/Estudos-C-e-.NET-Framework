using System;


namespace Animal.Models
{
    internal sealed class Poodle : Cachorro
    {
        public Poodle() 
        {
            this.Nome = "Lulu";
            this.Raca = "Poodle";
            this.Tamanho = "Médio";
        }

        public override string Latir()
        {
            return "au au au";
        }

        public override string GetHeranca()
        {
            return base.GetHeranca() + " - Poodle"; 
        }
    }
}
