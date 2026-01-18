using System;

namespace Profissao.Models
{
    internal sealed class QA : Profissao
    {
        public QA() 
        {
            this.Nome = "Ana";
            this.Idade = 34;
            this.Salario = 2350;
            this.Cargo = "QA";
        }

        public override string Funcao()
        {
            return "Garantir que os produtos e serviços de tecnologia da informação sejam desenvolvidos de maneira adequada e sem erros.";
        }

        public override string GetHeranca()
        {
            return base.GetHeranca() + " - QA";
        }
    }
}
