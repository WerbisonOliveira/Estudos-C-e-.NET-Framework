using System;


namespace Especie.Models.Chordata.Carnívora
{
    internal abstract class Canis : Canidae
    {
        public Canis()
        {
            this.Nome = "Canis";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Canis";
        }
    }
}
