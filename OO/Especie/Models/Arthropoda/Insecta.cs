using System;

namespace Especie.Models.Arthropoda
{
    internal abstract class Insecta: Arthropoda
    {

        public Insecta() 
        {
            this.Nome = "Insecta";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Insecta";
        }
    }
}
