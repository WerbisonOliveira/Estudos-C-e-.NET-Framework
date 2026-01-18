using System;


namespace Ecommerce.Models
{
    internal class ItemCarrinho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public string ExibirProduto()
        {
            return $"{Nome} - {Preco:C}";
        }
    }
}
