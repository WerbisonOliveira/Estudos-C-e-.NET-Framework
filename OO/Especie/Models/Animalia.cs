using System;


namespace Especie.Models
{
    internal abstract class Animalia
    {
        public string Nome { get; protected set; }// Só pode ser definido na herança (protected)
        // protected é utilizado mais na herança
        public Animalia() 
        {
            this.Nome = "Animalia";
        }

        public virtual string GetDescrição()
        {
            return "Animalia";
        }

        public abstract string Comunicar();
  
    }
}
