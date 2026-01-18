using System;


namespace Pagamento.Models
{
    internal class CartaoDeCredito : Pagamento
    {
        public CartaoDeCredito() 
        { 

        }    

        public override bool Validar() 
        { 
            return true; 
        }
    }
}
