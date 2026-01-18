using System;
using System.Collections.Generic;


namespace Assistencia.Models
{
    internal class OrdemDeServico
    {
        public List<Produto> Produtos { get;}

        public int Numero { get; set; }

        public string NomeDoCliente { get; set; }

        public DateTime Data { get; set; }


        public OrdemDeServico(int numero) 
        {
            Produtos = new List<Produto>();
            Data = DateTime.Now;
            Numero = numero;
        }

        public OrdemDeServico(string nomeDoCliente, int numero) 
        {
            Produtos = new List<Produto>();
            NomeDoCliente = nomeDoCliente;
            Data = DateTime.Now;
            Numero = numero;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public string ExibirServico()
        {
            System.Text.StringBuilder servico = new System.Text.StringBuilder();

            servico.Append("===========================================\n");
            servico.Append("Início OS\n");
            servico.Append("===========================================\n");
            servico.Append($"Ordem: {Numero} \nCliente: {NomeDoCliente} \nData de abertura: {Data:dd/MM/yyyy}\n");

            servico.Append("-------------------------------------------\n");
            servico.Append("Produtos da OS - defeito:\n");
            servico.Append("-------------------------------------------\n");

            foreach (var produto in Produtos)
            {
                
                servico.Append($"{produto.Nome} - {produto.DefeitoRelatado}\n");
            }
            servico.Append("-------------------------------------------\n");
            servico.Append($"Total de produtos: {Produtos.Count} \n");
            servico.Append("===========================================\n");
            servico.Append("Fim OS\n");
            servico.Append("===========================================\n");

            return servico.ToString();
        }

    }
}
