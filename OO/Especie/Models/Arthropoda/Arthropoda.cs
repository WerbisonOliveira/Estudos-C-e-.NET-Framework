using System;



namespace Especie.Models.Arthropoda
{
    internal abstract class Arthropoda: Animalia
    {
        public Arthropoda() 
        {
            this.Nome = "Arthropoda";
        }

        public override string GetDescrição()
        {
            
            return base.GetDescrição() + " - Arthropoda";
        }

        
    }
}
