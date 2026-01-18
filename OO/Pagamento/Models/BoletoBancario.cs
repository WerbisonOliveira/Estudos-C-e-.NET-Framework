using System;



namespace Pagamento.Models
{
    internal class BoletoBancario : Pagamento
    {
        public BoletoBancario()
        {


        }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
