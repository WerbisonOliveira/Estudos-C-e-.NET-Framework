using System;
using Conta.Models;

namespace Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Conta c1 = new Models.Conta(DateTime.Now, 100);
            Models.Conta c2 = new Models.Conta(DateTime.Now, 200);
            Models.Conta c3 = new Models.Conta(DateTime.Now, 400);

            Models.Contas contas = new Models.Contas();
            contas.Adicionar(c1);
            contas.Adicionar(c2);
            contas.Adicionar(c3);
            

            Console.WriteLine($"Valor Total: {contas.GetValorTotal():C}");
        }
    }
}
