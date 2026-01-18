using System;


namespace Especie.Models.Chordata.Primata
{
    internal abstract class Homo : Hominidae
    {
        public Homo() 
        {
            this.Nome = "Homo";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Homo";
        }
    }
}
