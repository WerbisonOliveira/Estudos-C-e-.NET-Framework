using System;


namespace Profissao.Models
{
    internal abstract class Profissao
    {
        public string Nome { get; protected set; }

        public int Idade { get;  protected set; }

        public double Salario { get; protected set; }

        public string Cargo { get; protected set; }

        public Profissao() 
        {

        }

        public abstract string Funcao();

        public virtual string GetHeranca()
        {
            return "Profissão";
        }

    }
}
