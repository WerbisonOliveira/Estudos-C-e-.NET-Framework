using System;
using IEcommerce.Models;


namespace IEcommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoDiet produtoDiet = new ProdutoDiet();

            ProdutoGiftCard produtoGiftCard = new ProdutoGiftCard();

            ProdutoLaticinio produtoLaticinio = new ProdutoLaticinio();

            Geladeira geladeira = new Geladeira();

            geladeira.AdicionarProduto(produtoDiet);

            //geladeira.AdicionarProduto(produtoGiftCard);// estranho

            geladeira.AdicionarProduto(produtoLaticinio);


          



        }
    }
}
