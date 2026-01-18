using System;


namespace Profissao.Models
{
    internal sealed class Programador : Profissao
    {
        public Programador() 
        {
            this.Nome = "Werbison";
            this.Idade = 24;
            this.Salario = 2750.50;
            this.Cargo = "Desenvolvedor";
        }

        public override string Funcao()
        {
            return "Desenvolver sites e aplicações web.";
        }

        public override string GetHeranca()
        {
            return base.GetHeranca() + " - Programador";
        }
    }
}
