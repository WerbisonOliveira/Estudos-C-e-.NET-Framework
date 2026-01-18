using System;


namespace Produto.Models
{
    internal class Produto
    {
        public string Nome { get; private set; }

        public double Preco { get; private set; }

        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            Console.WriteLine($"{quantidade} {this.Nome}s foram adicionadas ao estoque");
        }

        public void RemoverProdutos(int quantidade)
        {
            if (quantidade > Quantidade)
                Console.WriteLine("Quantidade passada é maior do que tem em estoque.");
            //throw new ArgumentException("Quantidade passada é maior do que tem em estoque.");
            else
            {
                Quantidade -= quantidade;
                Console.WriteLine($"{quantidade} {this.Nome}s foram removidas do estoque");
            }
               
        }


    }
}
