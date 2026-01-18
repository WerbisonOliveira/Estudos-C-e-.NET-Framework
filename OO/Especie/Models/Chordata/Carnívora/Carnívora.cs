using System;


namespace Especie.Models.Chordata.Carnívora
{
    internal abstract class Carnívora : Mammalia
    {
        public Carnívora()
        {
            this.Nome = "Carnívora";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Carnívora";
        }
    }
}
