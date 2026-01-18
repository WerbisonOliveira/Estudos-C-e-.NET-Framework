using System;


namespace Conta.Models
{
    internal class Conta
    {
        public DateTime Data { get; }
        public double Valor { get; set; }
        public Conta(DateTime data, double valor)
        {
            this.Data = data;
            this.Valor = valor;
        }
    }
}
