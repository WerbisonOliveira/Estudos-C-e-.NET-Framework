using System;
using System.Collections.Generic;



namespace EstoqueDeProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estoque = new Dictionary<int, string>();
            int opcaoDoUsuario = 0, codigoDoProduto;
            bool encerrar = false;
            string nomeDoProduto = "";

            do
            {
                Console.WriteLine("------ Estoque_de_Produtos ------\n");

                Console.WriteLine("1 - Adicionar produto ao estoque");
                Console.WriteLine("2 - Verificar produto");
                Console.WriteLine("3 - Encerrar programa");

                Console.Write("\nOpção: ");
                opcaoDoUsuario = int.Parse(Console.ReadLine());

                switch (opcaoDoUsuario)
                {
                    case 1:
                        Console.Write("\nDigite o nome do produto: ");
                        nomeDoProduto = Console.ReadLine();
                        Console.Write("\nDigite o código do produto: ");
                        codigoDoProduto = int.Parse(Console.ReadLine());

                        if (!estoque.ContainsKey(codigoDoProduto))
                        {
                            Console.WriteLine("\nProduto adicionado");
                            estoque.Add(codigoDoProduto, nomeDoProduto);
                        }                
                        else
                            Console.WriteLine("\nCódigo informado já existe.");
                        break;
                    case 2:
                        Console.Write("\nInforme o código do produto: ");
                        codigoDoProduto = int.Parse(Console.ReadLine());
                        if (estoque.ContainsKey(codigoDoProduto))
                            Console.WriteLine($"\nProduto: {estoque[codigoDoProduto]}");
                        else
                            Console.WriteLine("\nCódigo de produto não existe!");
                        break;
                    case 3:
                        Console.WriteLine("\nEncerrando...");
                        encerrar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (!encerrar);

            Console.WriteLine("Produtos no estoque: \n");
            if (estoque.Count > 0)
                foreach (KeyValuePair<int, string> produto in estoque)
                {
                    Console.WriteLine($"{produto.Key} - {produto.Value}");
                }
            else
                Console.Write("Estoque vazio!\n");

        }
    }
}
