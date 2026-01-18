using System;


namespace Funcionario.Models
{
    internal class Funcionario
    {
        public string Nome { get; private set; }

        public double Salario { get; private set; }

        public Funcionario(string nome, double salarioInicial)
        {
            Nome = nome;
            Salario = salarioInicial;
        }

        public void ReajustarSalario(double percentual)
        {
            if (percentual > 0)
                Salario += Salario * (percentual / 100);
        }


    }
}
