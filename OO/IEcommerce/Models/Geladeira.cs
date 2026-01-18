using System;
using System.Collections.Generic;
using IEcommerce.Interfaces;


namespace IEcommerce.Models
{
    internal class Geladeira : Produto, IGeladeira
    {
        public double Temperatura { get; private set; }

        public double Capacidade { get; set; }

        public List<IProdutoGeladeira> Produtos { get; private set; }

        public Geladeira()
        {
            Produtos = new List<IProdutoGeladeira>();
        }

        public void AumentarTemperatura()
        {
            Temperatura++;
        }

        public void DiminuirTemperatura()
        {
            Temperatura--;
        }

        public void AdicionarProduto(IProdutoGeladeira produto)
        {
            /*if (produto is ProdutoGiftCard)
                throw new ArgumentException("Produto não pode entrar na geladeira!");*/

            Produtos.Add(produto);
        }

        public void RemoverProduto(IProdutoGeladeira produto)
        {
            Produtos.Remove(produto);
        }
    }
}
