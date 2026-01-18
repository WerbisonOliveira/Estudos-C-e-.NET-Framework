using System;



namespace ContaBancaria.Models
{
    internal class ContaBancaria
    {
        private int numero;
        private string titular;
        private double saldo;

        public ContaBancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = 0;
        }

        public void Depositar(double valor)
        {
            this.saldo = saldo + valor;
            Console.WriteLine($"{valor:C} depositado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor > saldo)
                Console.WriteLine("Saldo atual inferior ao valor do saque!");
            else
            {
                this.saldo = saldo - valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso!");
            }
                    
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {this.saldo:C}\n");
        }

        public void ExibirConta()
        {
            Console.WriteLine($"Número: {this.numero}");
            Console.WriteLine($"Titular: {this.titular}");
            Console.WriteLine($"Saldo: {this.saldo:C}");
        }
    }
}
