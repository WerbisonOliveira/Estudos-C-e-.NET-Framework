using System;


namespace Loja.Models
{
    internal class Porta
    {
        public bool Aberta { get; private set; }
        public string Cor { get; private set; }
        public Porta()
        {
            Aberta = false;
            Cor = "branca";
        }

        public Porta(string cor)
        {
            Aberta = false;
            Cor = cor;
        }

        public Porta(string cor, bool aberta)
        {
            Aberta = aberta;
            Cor = cor;
        }

        public void Abrir()
        {
            Aberta = true;
        }

        public void Fechar()
        {
            Aberta = false;
        }

        public void Pintar(string cor)
        {
            Cor = cor;
        }
    }
}
