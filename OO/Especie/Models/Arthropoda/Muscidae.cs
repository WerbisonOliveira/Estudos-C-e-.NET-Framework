using System;

namespace Especie.Models.Arthropoda
{
    internal abstract class Muscidae: Díptera
    {
        public Muscidae() 
        {
            this.Nome = "Muscidae";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Muscidae";
        }
    }
}
