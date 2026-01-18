using System;



namespace Porta.Models
{
    internal class Porta
    {
        public bool Aberta { get; private set; }

        public Porta()
        {
            Aberta = false;
        }

        public void Abrir()
        {
            Aberta = true;
        }

        public void Fechar()
        {
            Aberta = false;
        }
    }
}
