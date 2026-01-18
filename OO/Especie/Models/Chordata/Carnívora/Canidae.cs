using System;


namespace Especie.Models.Chordata.Carnívora
{
    internal abstract class Canidae : Carnívora
    {
        public Canidae()
        {
            this.Nome = "Canidae";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Canidae";
        }
    }
}
