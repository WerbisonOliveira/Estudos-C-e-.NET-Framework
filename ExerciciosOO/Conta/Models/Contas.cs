using System;
using System.Collections.Generic;



namespace Conta.Models
{
    internal class Contas
    {
        public double ValorTotalContas { get; private set; }
        public List<Conta> ContasAtivas { get; }

        public Contas() 
        {
            ContasAtivas = new List<Conta>();
        }

        public void Adicionar(Conta conta)
        {
            ContasAtivas.Add(conta);
            ValorTotalContas += conta.Valor;
        }

        public double GetValorTotal()
        {
            return ValorTotalContas;
        }
    }
}
