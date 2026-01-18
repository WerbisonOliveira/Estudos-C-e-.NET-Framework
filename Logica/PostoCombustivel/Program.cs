using System;
using System.Runtime.Remoting.Channels;

/*
    * Analise a seguinte informação:

    * Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:

    * Álcool
        * até 20 litros (inclusive 20 litros), desconto de 2% por litro
        * acima de 20 litros, desconto de 5% por litro
    * Gasolina
        * até 20 litros (inclusive 20 litros), desconto de 3% por litro
        * acima de 20 litros, desconto de 6% por litro
        
    * Após à análise, faça um programa que leia o número de litros vendidos 
      e o tipo de combustível (codificado da seguinte forma: 1-álcool, 2-gasolina).
    * calcule e imprima o valor a ser pago pelo jogador, sabendo-se que 
      o preço do litro da gasolina é R$ 6.10 e o preço do litro do álcool é R$ 4.20
*/

namespace PostoCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PRECODOLITRODAGASOLINA = 6.10;
            const double PRECODOLITRODOALCOOL = 4.20;
            const double DESCONTOALCOOLATÉ20LITROS = 0.98;
            const double DESCONTOALCOOLAPOS20LITROS = 0.95;
            const double DESCONTOGASOLINAATE20LITROS = 0.97;
            const double DESCONTOGASOLINAAPOS20LITROS = 0.94;
            const double LIMITEDELITROSPARAESCOLHADODESCONTO = 20;
            const string ALCOOL = "1";
            const string GASOLINA = "2";
            double litrosVendidos = 0;
            string combustivel;
            string resposta = "N";

            
            do
            {
                Console.WriteLine("==== Posto_Combustível ====");

                Console.WriteLine("\n1-Álcool \n2-Gasolina");
                
                do
                {
                    Console.Write("\nInforme o combustível escolhido: ");
                    combustivel = Console.ReadLine();

                    if (combustivel != ALCOOL && combustivel != GASOLINA)
                    {
                        Console.WriteLine("\nOpção escolhida não existe! Escolha uma das opções disponíveis.");
                        //continue;
                        //break;
                        //return;
                    }

                
                } while (combustivel != ALCOOL && combustivel != GASOLINA);
                
                do
                {
                    Console.Write("\nInforme quantos litros foram vendidos: ");
                    litrosVendidos = double.Parse(Console.ReadLine());

                    if (litrosVendidos < 0)
                    {
                        Console.WriteLine("\nQuantidade de litros inválida!");
                        //return;
                    }

                } while (litrosVendidos < 0);

                double valorASerPago = 0;

                switch (combustivel)
                {
                    case ALCOOL:
                        double valorTotalDoAlcool = litrosVendidos * PRECODOLITRODOALCOOL;
                        //valorASerPago = litrosVendidos <= LIMITEDELITROSPARAESCOLHADODESCONTO ? valorTotalDoAlcool * DESCONTOALCOOLATÉ20LITROS : valorTotalDoAlcool * DESCONTOALCOOLAPOS20LITROS;

                        if (litrosVendidos <= LIMITEDELITROSPARAESCOLHADODESCONTO)
                        {
                            valorASerPago = valorTotalDoAlcool * DESCONTOALCOOLATÉ20LITROS;
                        }
                        else
                        {
                            valorASerPago = valorTotalDoAlcool * DESCONTOALCOOLAPOS20LITROS;
                        }

                        break;
                    case GASOLINA:
                        double valorTotalDaGasolina = litrosVendidos * PRECODOLITRODAGASOLINA;
                        //valorASerPago = litrosVendidos <= LIMITEDELITROSPARAESCOLHADODESCONTO ? valorTotalDaGasolina * DESCONTOGASOLINAATE20LITROS : valorTotalDaGasolina * DESCONTOGASOLINAAPOS20LITROS;

                        if (litrosVendidos <= LIMITEDELITROSPARAESCOLHADODESCONTO)
                        {
                            valorASerPago = valorTotalDaGasolina * DESCONTOGASOLINAATE20LITROS;
                        }
                        else
                        {
                            valorASerPago = valorTotalDaGasolina * DESCONTOGASOLINAAPOS20LITROS;
                        }

                        break;
                }

                Console.WriteLine($"\nValor a ser pago: R$ {valorASerPago:0.00}");

                Console.Write("\nDeseja reabastecer? [S - sim / N - não]  ");
                resposta = Console.ReadLine();

                if(resposta.ToUpper() == "S")
                {
                    Console.Clear();
                }

            } while (resposta.ToUpper() == "S");

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();

        }
    }
}
