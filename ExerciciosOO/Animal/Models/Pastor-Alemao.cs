using System;


namespace Animal.Models
{
    internal sealed class Pastor_Alemao : Cachorro
    {
        public Pastor_Alemao()
        {
            this.Nome = "Max";
            this.Raca = "Pastor Alemão";
            this.Tamanho = "Grande";
        }

        public override string Latir()
        {
            return $"Au! Au!!";
        }

        public override string GetHeranca()
        {
            return base.GetHeranca() + " - Pastor Alemão";
        }
    }
}
