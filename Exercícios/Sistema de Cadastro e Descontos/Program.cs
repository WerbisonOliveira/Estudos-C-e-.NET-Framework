using System;

namespace Sistema_de_Cadastro_e_Descontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cupom = 0;
            int numeroDoCupom = 0;          
            string cupomValido = "";

            Console.WriteLine("==== Sistema de Cadastro e Descontos ====");

            Console.WriteLine("\nCadastre-se e ganhe um cupom de 15%!");

            Console.Write("\nDeseja se cadastrar ? [S/N] ");
            string resposta = Console.ReadLine();

            if(resposta.ToLower() == "s")
            {
                Console.WriteLine("\nInforme seu nome e idade para cadastro:");

                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("\nIdade: ");
                int idade = int.Parse(Console.ReadLine());
           
                Console.WriteLine($"\nObrigado {nome} por se cadastrar! Você ganhou um cupom de 15% para utilizar em qualquer compra.");

                cupom = 100;

                Console.WriteLine($"Cupom: {cupom}. Informe no momento do pagamento.");
                             
            }

            Console.WriteLine("\n-------------------------------------------");

            Console.WriteLine("\nLoja - Produtos");

            Console.WriteLine("\n1 - Camisa R$ 59,90 \n2 - Calça R$ 99,90 \n3 - Tênis R$ 179,00 \n4 - sair");

            Console.Write("\nInforme a opção escolhida: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 1 || opcao == 2 || opcao == 3) 
            {
                Console.Write("\nVocê possui um cupom de desconto? [S/N] ");
                resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                {
                    Console.Write("\nInforme o número do cupom: ");
                    numeroDoCupom = int.Parse(Console.ReadLine());


                    if (numeroDoCupom == cupom)
                    {
                        Console.WriteLine("\nCupom válido!");
                        cupomValido = "válido";
                    }
                    else
                    {
                        Console.WriteLine("\nCupom inválido");
                    }

                }

                switch (opcao)
                {
                    case 1:
                        if (cupomValido == "válido")
                        {
                            Console.WriteLine($"\nValor a pagar: R$ {59.90 - (59.90 * 0.15):0.00}");
                        }
                        else
                        {
                            Console.WriteLine($"\nValor a pagar: R$ {59.90:0.00}");
                        }
                        break;
                    case 2:
                        if (cupomValido == "válido")
                        {
                            Console.WriteLine($"\nValor a pagar: R$ {99.90 - (99.90 * 0.15):0.00}");
                        }
                        else
                        {
                            Console.WriteLine($"\nValor a pagar: R$ {99.90:0.00}");
                        }
                        break;
                    case 3:
                        if (cupomValido == "válido")
                        {
                            Console.WriteLine($"\nValor a pagar: R$ {179 - (179 * 0.15):0.00}");
                        }
                        else
                        {
                            Console.WriteLine($"\nValor a pagar: R$ {179.00:0.00}");
                        }
                        break;
                }
                
            }
            else if (opcao == 4)
            {
                Console.WriteLine("\nSaindo...");
            }
            else
            {
                Console.WriteLine("\nOpção inválida!");
            }

            Console.WriteLine("\nPresione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
