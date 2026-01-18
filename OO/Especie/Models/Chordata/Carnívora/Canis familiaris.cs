using System;


namespace Especie.Models.Chordata.Carnívora
{
    internal sealed class Canis_familiaris : Canis
    {
        public Canis_familiaris()
        {
            this.Nome = "Canis_familiaris";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Canis_familiaris"; 
        }

        public override string Comunicar()
        {
            return "AU AU AU AU";
        }
    }
}
