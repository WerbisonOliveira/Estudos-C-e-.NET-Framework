using System;


namespace Especie.Models.Chordata.Primata
{
    internal abstract class Hominidae : Primata
    {
        public Hominidae() 
        {
            this.Nome = "Hominidae";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Hominidae";
        }
    }
}
