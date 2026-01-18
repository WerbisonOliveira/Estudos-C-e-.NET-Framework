using System;



namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Poodle poodle = new Models.Poodle();

            Console.WriteLine($"Nome: {poodle.Nome} \nRaça: {poodle.Raca} \nPorte: {poodle.Tamanho} \nSom: {poodle.Latir()}");

            Console.WriteLine($"Herança: {poodle.GetHeranca()} \n");

            Models.Pastor_Alemao pastorAlemao = new Models.Pastor_Alemao();

            Console.WriteLine($"Nome: {pastorAlemao.Nome} \nRaça: {pastorAlemao.Raca} \nPorte: {pastorAlemao.Tamanho} \nSom: {pastorAlemao.Latir()}");

            Console.WriteLine($"Herança: {pastorAlemao.GetHeranca()} ");

        }
    }
}
