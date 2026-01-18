using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal abstract class Pessoa
    {
        protected string primeiroNome;
        protected string ultimoNome;

        public Pessoa(string pNome, string uNome)
        {
            primeiroNome = pNome;
            ultimoNome = uNome;
        }

        public virtual double valorCopiasXerox(int quantidade)
        {
            return quantidade * 2;
        }
    }
}
