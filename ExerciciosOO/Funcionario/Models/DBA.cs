using System;


namespace Profissao.Models
{
    internal sealed class DBA : Profissao
    {
        public DBA()
        {
            this.Nome = "Pedro";
            this.Idade = 29;
            this.Salario = 3500;
            this.Cargo = "DBA";
        }

        public override string Funcao()
        {
            return "Gerenciar, otimizar e proteger sistemas de bancos de dados.";
        }

        public override string GetHeranca()
        {
            return base.GetHeranca() + " - DBA";
        }
    }
}
