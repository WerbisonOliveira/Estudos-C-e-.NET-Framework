using System;


namespace Especie.Models.Arthropoda
{
    internal sealed class Musca_domestica: Musca
    {

        public Musca_domestica() 
        {
            this.Nome = "Musca_domestica";
        }

        public override string GetDescrição()
        {
            return base.GetDescrição() + " - Musca_domestica";
        }

        public override string Comunicar() // Obriga implementar o método abstrato da classe pai.
        {
            return "zummmmmzummmmm";
        }

    }
}
