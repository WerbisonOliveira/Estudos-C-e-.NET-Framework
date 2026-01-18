using System;



namespace Ecommerce.Models
{
    internal class Produto
    {
        private static int id = 0; // não tem referência com o objeto (alocado uma única vez - classe)

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public double Preco { get; set; }

        public Produto(string categoria, string nome, double preco) 
        {
            Id = ++id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }

        public void AplicarDesconto(double percentualDesconto)
        {
            if(percentualDesconto < 0 || percentualDesconto > 100)
            {
                throw new ArgumentException("Erro no percentual de desconto! Não está entre 0 e 100."); // lança exceção e para o funcionamento do programa.
            }

            Preco *= 1 - (percentualDesconto / 100);
        }

        public void AplicarAumento(double percentualAumento)
        {
            if (percentualAumento <= 0)
            {
                throw new ArgumentException("Erro no percentual de desconto! Não está entre 0 e 100."); // lança exceção e para o funcionamento do programa.
            }

            Preco *= 1 + (percentualAumento / 100);
        }

    }
}
