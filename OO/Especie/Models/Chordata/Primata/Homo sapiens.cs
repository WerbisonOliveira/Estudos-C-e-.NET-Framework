using System;


namespace Especie.Models.Chordata.Primata
{
    internal sealed class Homo_sapiens : Homo
    {
        public Homo_sapiens()
        {
            this.Nome = "Homo_sapiens";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Homo_sapiens";
        }

        public override string Comunicar()
        {
            return "Olá, tudo bem?";
        }

    }
}
