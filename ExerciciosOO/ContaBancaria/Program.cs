using System;


namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Models.ContaBancaria conta = new Models.ContaBancaria(919101699, "Werbison");

            conta.ExibirSaldo();
            conta.Depositar(1000);

            conta.ExibirSaldo();

            conta.Sacar(50);
            conta.Sacar(20);

            conta.Depositar(200);

            conta.Sacar(1000);

            conta.ExibirSaldo();

            conta.ExibirConta();
        }
    }
}
