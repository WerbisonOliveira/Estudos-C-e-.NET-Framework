using System;



namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Produto pera = new Models.Produto("Pera", 5.00, 10);

            Console.WriteLine($"Nome do produto: {pera.Nome}");
            Console.WriteLine($"Preço do produto: {pera.Preco:c}");
            Console.WriteLine($"Quantidade do produto: {pera.Quantidade}");

            Console.WriteLine($"Valor total do produto em estoque: {pera.ValorTotalEmEstoque():c}");

            pera.RemoverProdutos(2);
            pera.AdicionarProdutos(50);

            Console.WriteLine($"Valor total do produto em estoque: {pera.ValorTotalEmEstoque():c}\n");

            Models.Produto batata = new Models.Produto("Batata", 3.50, 30);

            Console.WriteLine($"Nome do produto: {batata.Nome}");
            Console.WriteLine($"Preço do produto: {batata.Preco:c}");
            Console.WriteLine($"Quantidade do produto: {batata.Quantidade}");

            Console.WriteLine($"Valor total do produto em estoque: {batata.ValorTotalEmEstoque():c}");

            batata.AdicionarProdutos(100);
            Console.WriteLine($"Valor total do produto em estoque: {batata.ValorTotalEmEstoque():c}");

            batata.RemoverProdutos(30);
            Console.WriteLine($"Valor total do produto em estoque: {batata.ValorTotalEmEstoque():c}");

            batata.RemoverProdutos(200);

        }
    }
}
