using País.Models;
using System;

namespace País
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais pais = new Pais();
            pais.Nome = "Brasil";
            pais.Capital = "Brasília";
            pais.AreaKm2 = 8510000;

            Pais pais2 = new Pais();
            pais2.Nome = "Canadá";
            pais2.Capital = "Ottawa";
            pais2.AreaKm2 = 9985000; // Quando utilizamos o operador de atribuição a propriedade chama o método set. E quando chamamos somente a propriedade ela chama o método get.

            pais.PaisIguais(pais2); // Passagem de parâmetro por referência // tipo de dado Pais

            Console.WriteLine($"O nome do país é {pais.Nome}");
            Console.WriteLine($"O nome da capital é {pais.Capital}");
            Console.WriteLine($"Os paises são iguais ? {(pais.PaisIguais(pais2) ? "sim" : "não")}");
            
        }
    }
}
