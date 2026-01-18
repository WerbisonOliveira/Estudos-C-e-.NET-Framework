using System;


namespace Especie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Arthropoda.Musca_domestica mosquito = new Models.Arthropoda.Musca_domestica();

            Console.WriteLine($"Hierarquia_mosquito: {mosquito.GetDescrição()}");
            Console.WriteLine($"Som: {mosquito.Comunicar()}\n");

            Models.Chordata.Carnívora.Canis_familiaris doguinho = new Models.Chordata.Carnívora.Canis_familiaris();

            Console.WriteLine($"Hierarquia do doguinho: {doguinho.GetDescrição()}");
            Console.WriteLine($"Som: {doguinho.Comunicar()}\n");

            Models.Chordata.Primata.Homo_sapiens pessoa = new Models.Chordata.Primata.Homo_sapiens();

            Console.WriteLine($"Hierarquia da pessoa: {pessoa.GetDescrição()}");
            Console.WriteLine($"Som: {pessoa.Comunicar()}");
        }
    }
}
