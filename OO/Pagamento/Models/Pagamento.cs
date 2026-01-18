using System;



namespace Pagamento.Models
{
    public abstract class Pagamento
    {
        public double Valor { get; protected set; }

        public DateTime Data { get; protected set; }

        public abstract bool Validar();
    }
}
