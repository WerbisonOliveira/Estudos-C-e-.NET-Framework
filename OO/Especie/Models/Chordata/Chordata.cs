using System;

namespace Especie.Models.Chordata
{
    internal abstract class Chordata : Animalia
    {
        public Chordata() 
        {
            this.Nome = "Chordata";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Chordata";
        }

    }
}
