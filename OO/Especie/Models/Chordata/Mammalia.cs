using System;


namespace Especie.Models.Chordata
{
    internal abstract class Mammalia : Chordata
    {
        public Mammalia() 
        {
            this.Nome = "Mammalia";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Mammalia";
        }

    }
}
