using System;



namespace Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Models.Produto produto = new Models.Produto("alimentício", "Arroz", 6.20);
            Models.Produto produto2 = new Models.Produto("alimentício", "Feijão", 6.79);
            Models.Produto produto3 = new Models.Produto("alimentício", "Macarrão", 5.59);
            Models.Produto produto4 = new Models.Produto("alimentício", "Carne", 21.50);
            Models.Produto produto5 = new Models.Produto("alimentício", "Açúcar", 4.20);

            Models.Carrinho carrinho = new Models.Carrinho();
            carrinho.Cliente.Nome = "João";
            carrinho.Cliente.Idade = 29;

            carrinho.AdicionarProduto(produto);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);
            carrinho.AdicionarProduto(produto4);
            carrinho.AdicionarProduto(produto5);

            Console.WriteLine(carrinho.ExibirCompras());

            Models.Carrinho carrinho2 = new Models.Carrinho();
            carrinho2.Cliente.Nome = "Pedro";
            carrinho2.Cliente.Idade = 35;

            carrinho2.AdicionarProduto(produto);
            carrinho2.AdicionarProduto(produto3);
            carrinho2.AdicionarProduto(produto5);

            Console.WriteLine(carrinho2.ExibirCompras());


        }
    }
}
