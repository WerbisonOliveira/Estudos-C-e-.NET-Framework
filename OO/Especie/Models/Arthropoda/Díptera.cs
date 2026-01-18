using System;

namespace Especie.Models.Arthropoda
{
    internal abstract class Díptera: Insecta
    {

        public Díptera() 
        {
            this.Nome = "Díptera";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Díptera";
        }
    }
}
