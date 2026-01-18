using System;


namespace Especie.Models.Chordata.Primata
{
    internal abstract class Primata : Mammalia
    {
        public Primata()
        {
            this.Nome = "Primata";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Primata";
        }
    }
}
