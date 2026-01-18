using System;


namespace FundamentosOO
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string name, int age)
        {
            this.nome = name;
            this.idade = age;
        }

        public void showNome()
        {
             Console.WriteLine($"\nNome: {nome}");
        }

        public void showIdade()
        {
             Console.WriteLine($"\nIdade: {idade}\n");
        }

        public string setNome(string name)
        {
            return nome = name;
        }

        public int setIdade(int age)
        {
            return idade = age;
        }
    }
}
