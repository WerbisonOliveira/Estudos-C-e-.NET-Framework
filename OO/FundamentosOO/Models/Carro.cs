using System;

namespace FundamentosOO.Models
{
    // public / internal / private => modificadores de acesso
    internal class Carro
    {
        public string Cor { get; set; } // PascalCase => convenção de nomenclatura
        public int Tamanho { get; set; }
        public int QuantidadeDePneus { get; set; }
        public bool ArCondicionado { get; set; }
        public double Velocidade { get; private set; }


        public Carro()
        {

        }


        public void Acelerar()
        {
            this.Velocidade++;
            //return;
        }

        public void Acelerar(int turbo)
        {
            this.Velocidade = turbo;
        }

        public void Frear()
        {
            if(Velocidade > 0)
                this.Velocidade--;
        }

        public bool EstarParado()
        {
            return this.Velocidade == 0;  
        }


    }
}
