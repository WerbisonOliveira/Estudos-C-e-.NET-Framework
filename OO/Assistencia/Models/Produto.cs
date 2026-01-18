using System;
using System.Collections.Generic;


namespace Assistencia.Models
{
    internal class Produto
    {
 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string DefeitoRelatado { get; set; }

        public Produto() 
        { 

        }    

        public Produto(int id, string nome, string categoria, string defeito)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            DefeitoRelatado = defeito;
        }


    }
}
