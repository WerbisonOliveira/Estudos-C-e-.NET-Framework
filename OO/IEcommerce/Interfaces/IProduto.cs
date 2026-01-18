using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEcommerce.Interfaces
{
    internal interface IProduto
    {
        int Id { get; }

        string Nome { get; set; }

        string Categoria { get; set; }

        double Preco { get; }

        void AplicarDesconto(double percentualDesconto);

        void AumentarPreco(double percentualAumento);
    }
}
