using System;


namespace Especie.Models.Arthropoda
{
    internal abstract class Musca: Muscidae
    {
        public Musca()
        {
            this.Nome = "Musca";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Musca";
        }      

    }
}
