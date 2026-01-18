using System;
using System.Collections.Generic;

/*
    Crie um programa em C# que simule o gerenciamento básico de uma assistência técnica. 

    Programa: Assitencia

    Cadastrar produtos com os seguintes campos:
    Id (inteiro)
    Nome (string)
    Categoria (string)
    Defeito relatado (string)

    Criar uma Ordem de Serviço (OS), onde produtos cadastrados podem ser adicionados junto com 
    número da OS : int
    nome do cliente: string
    data de abertura: date
    adicionar produtos (produto): void
    remover produtos (produto): void

    Imprimir os dados da Ordem de Serviço no console, mostrando:
    Dados da OS (número, cliente, data);

    Lista dos produtos incluídos com seus detalhes;
    Total de produtos cadastrados na OS.
    ===========================================
    Início OS
    ===========================================
    Ordem: 1023
    Cliente: Maria Oliveira
    Data de Abertura: 07/10/2025
    -------------------------------------------
    Produtos da OS - defeito:
    -------------------------------------------
    Notebook Dell XPS - Tela não liga
    HP 2050 Periférico - Puxa duas folhas
    -------------------------------------------
    Total de produtos: 2
    ===========================================
    Fim OS
    ===========================================
*/

namespace Assistencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idOS = 0;
            int idProduto = 0;

            Models.Produto p1 = new Models.Produto(++idProduto, "IPad", "eletrônico", "Bateria viciada");
            Models.Produto p2 = new Models.Produto(++idProduto, "IPad", "eletrônico", "Bateria viciada");
            Models.Produto p3 = new Models.Produto(++idProduto, "TV 50", "eletrônico", "Led apagado");
            Models.Produto p4 = new Models.Produto(++idProduto, "Notebook Samsung", "eletrônico", "Travando muito");

            Models.OrdemDeServico servico = new Models.OrdemDeServico("Maria", ++idOS);
            servico.AdicionarProduto(p1);
            servico.AdicionarProduto(p2);

            Models.OrdemDeServico os2 = new Models.OrdemDeServico("João", ++idOS);
            os2.AdicionarProduto(p3);

            Models.OrdemDeServico os3 = new Models.OrdemDeServico("Pedro", ++idOS);
            os3.AdicionarProduto(p4);

            Console.WriteLine(servico.ExibirServico());
            Console.WriteLine(os2.ExibirServico());
            Console.WriteLine(os3.ExibirServico());
            
        }
    }
}
