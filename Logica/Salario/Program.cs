using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 * Faça um Programa que pergunte quanto você ganha por hora 
                   e o número de horas trabalhadas no mês. 

                 * Calcule e mostre o total do seu salário no referido mês, 
                   sabendo-se que são descontados 11% para o Imposto de Renda, 
                   8% para o INSS e 5% para o sindicato, Assim, o programa de exibir:
                        salário bruto = ganho por hora * horas trabalhadas no mês
                        quanto pagou ao IR
                        quanto pagou ao INSS
                        quanto pagou ao Sindicato
                        Salário líquido = Salário Bruto - Descontos

                 * Dessa forma:
                    + Salário Bruto : R$  
                    - IR (11%) : R$
                    - INSS (8%) : R$
                    - Sindicato (5%) : R$
                    = Salário Líquido : R$

            */


            Console.WriteLine("==== Calcular_salario ====");
            Console.WriteLine("");

            Console.Write("Informe o salário recebido por hora trabalhada: ");
            double salarioPorHoraTrabalhada = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Informe a quantidade de horas trabalhadas no mês: ");
            int horasTrabalhadasNoMes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            double salarioBruto = salarioPorHoraTrabalhada * horasTrabalhadasNoMes;

            double impostoDeRenda = 11 * salarioBruto / 100;

            double inss = 8 * salarioBruto / 100;

            double sindicato = 5 * salarioBruto / 100;      

            double salarioLiquido = salarioBruto - (impostoDeRenda + inss + sindicato);

            Console.WriteLine($"+ Salário bruto : R$ {salarioBruto:0.00}");
            Console.WriteLine($"- IR (11%) : R$ {impostoDeRenda:0.00}");
            Console.WriteLine($"- INSS (8%) : R$ {inss:0.00}");
            Console.WriteLine($"- Sindicato (5%) : R$ {sindicato:0.00}");
            Console.WriteLine($"= Salário líquido : R$ {salarioLiquido:0.00}");

            Console.WriteLine("");

            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadLine();

        }
    }
}
