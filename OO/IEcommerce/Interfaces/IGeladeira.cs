using System;
using System.Collections.Generic;


namespace IEcommerce.Interfaces
{
    internal interface IGeladeira
    {
        double Temperatura { get; }

        double Capacidade { get; set; }

        List<IProdutoGeladeira> Produtos { get; }

        void AumentarTemperatura();

        void DiminuirTemperatura();

        void AdicionarProduto(IProdutoGeladeira produto);

        void RemoverProduto(IProdutoGeladeira produto);
    }
}
