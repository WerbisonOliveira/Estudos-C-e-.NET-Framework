using System;
using System.Collections.Generic;



namespace FundamentosOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Werbison";
            int idade = 23;
            Pessoa pessoa = new Pessoa(nome, idade);

            //Pessoa pessoa = new Pessoa(Console.ReadLine(), idade);

            pessoa.showNome();
            pessoa.showIdade();

            pessoa.setNome("Luiza");
            //pessoa.setNome(Console.ReadLine());

            pessoa.setIdade(25);
            //pessoa.setIdade(int.Parse(Console.ReadLine()));


            pessoa.showNome();
            pessoa.showIdade();

            
            Console.WriteLine("----------------------------------------");

            // sem métodos e construtores

            //const int QUANTIDADEDEPESSOAS = 3;
            //List<Pessoa> pessoas = new List<Pessoa>(QUANTIDADEDEPESSOAS);


            //for (int i = 0; i < QUANTIDADEDEPESSOAS; i++)
            //{
            //    Pessoa individuo = new Pessoa();
            //    pessoas.Add(individuo);

            //    Console.Write("\nNome: ");
            //    individuo.nome = Console.ReadLine();

            //    Console.Write("\nIdade: ");
            //    individuo.idade = int.Parse(Console.ReadLine());   
                
            //}

            //Console.WriteLine("\nLista de pessoas: ");
            //foreach (var p in pessoas)
            //{
            //    Console.Write($"\nNome: {p.nome}. Idade: {p.idade}\n");
                
            //}

            
        }
    }
}
