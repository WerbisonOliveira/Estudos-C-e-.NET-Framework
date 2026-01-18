using System;
using System.Collections.Generic;




namespace Ecommerce.Models
{
    internal class Carrinho
    {
        private static int id = 0;

        public int Id { get; }

        public List<ItemCarrinho> Produtos { get; }

        public Cliente Cliente { get; set; }

        public DateTime DataEHora { get; set; }

        public double ValorTotal { get; set; }

        public double Desconto { get; set; }

        public Carrinho()
        {
            Produtos = new List<ItemCarrinho>();
            Cliente = new Cliente();
            DataEHora = DateTime.Now;
        }

        public void AdicionarProduto(Produto produto)
        {
            Models.ItemCarrinho produtoCarrinho = new Models.ItemCarrinho();
            CopiarDadosDoProduto(produto, produtoCarrinho);
            Produtos.Add(produtoCarrinho);
            ValorTotal += produtoCarrinho.Preco;
        }

        public void RemoverProduto(Produto produto)
        {
            Models.ItemCarrinho produtoCarrinho = new Models.ItemCarrinho();
            CopiarDadosDoProduto(produto, produtoCarrinho);

            if(Produtos.Remove(produtoCarrinho)) // remove o item, caso exista e retorna true, se não retorna false.
            {
                ValorTotal -= produtoCarrinho.Preco;
            }
        }

        public string ExibirCompras()
        {
            System.Text.StringBuilder p = new System.Text.StringBuilder();
            p.Append("==================================================\n");
            p.Append("------------------ E-commerce --------------------\n");
            p.Append($"Data e hora da compra: {DataEHora}\n");
            p.Append("--------------------------------------------------\n");
            p.Append("Dados do cliente:\n");
            p.Append($"Nome: {Cliente.Nome}\n");
            p.Append($"idade: {Cliente.Idade}\n");
            p.Append("==================================================\n");
            p.Append($"Produtos:\n");
            foreach (var produto in Produtos)
            {
                p.Append($"{produto.ExibirProduto()}\n");
                ValorTotal += produto.Preco;
            }
            p.Append("==================================================\n");
            p.Append($"Valor total à pagar: {ValorTotal:C}\n");
            p.Append("==================================================\n");

            return p.ToString();
        }

        private void CopiarDadosDoProduto(Produto produto, ItemCarrinho itemcarrinho)
        {
            itemcarrinho.Nome = produto.Nome;
            itemcarrinho.Id = produto.Id;
            itemcarrinho.Categoria = produto.Categoria;
            itemcarrinho.Preco = produto.Preco;
        }

        public void AplicarDesconto(string Cupom)
        {
            Desconto = ValorCupom(Cupom); //pensando que o valor do desconto é somente o valor do CUPOM.
            ValorTotal -= Desconto;
        }

        private double ValorCupom(string Cupom)
        {
            //Validação do CUPOM - se existe, dentro do prazo.....
            //e retorna o valor do cupom
            return 0; //valor do cumpom... 0 foi só para o método funcionar.
        }

    }
}
