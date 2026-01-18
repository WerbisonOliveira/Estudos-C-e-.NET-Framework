using System;



namespace Carro.Models
{
    internal class Motor
    {
        public int Potencia { get; private set; }
        public string Combustivel { get; private set; }

        public Motor(int potencia, string combustivel)
        {
            this.Potencia = potencia;
            this.Combustivel = combustivel;
        }

    }
}
