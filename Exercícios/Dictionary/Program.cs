using System;
using System.Collections.Generic;


namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> contatos = new Dictionary<string, string>();

            contatos["Werbison"] = "987223196";//Uma forma de adicionar valor 
            contatos["Pedro"] = "987723166";
            contatos["Joana"] = "997223496";
            contatos["Matheus"] = "997283196";
            contatos["Ana"] = "983222195";

            foreach (var item in contatos)
            {
                Console.Write(item.Key + " - ");
                Console.WriteLine(item.Value + " ");
            }

            contatos.Add("Luis", "966542134");// Outra forma de adicionar valor

            foreach (var item in contatos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(contatos["Ana"]);// pega o valor de acordo com a chave
            Console.WriteLine(contatos["Pedro"]);
            Console.WriteLine(contatos["Matheus"]);


            if (contatos.TryGetValue("Werbison", out string contato))
            {
                Console.WriteLine($"Contato pego com sucesso: {contato}");
            }

            contatos.Remove("Joana");// remove elemento pela chave

            Console.WriteLine("Lista de contatos atualizada: ");

            foreach (var item in contatos)
            {
                Console.Write(item.Key + " - ");// mostra todas as chaves
                Console.WriteLine(item.Value + " "); // mostra todos os valores
            }


        }
    }
}
