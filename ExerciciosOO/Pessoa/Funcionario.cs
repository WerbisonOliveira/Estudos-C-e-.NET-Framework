using System;


namespace Pessoa
{
    internal class Funcionario : Pessoa
    {
        public double Salario { get; set; }

        public Funcionario(string pNome, string uNome, double salario):base(pNome, uNome)
        {
            Salario = salario;
        }
    }
}
