using System;


namespace País.Models
{
    internal class Pais
    {
        private string _nome; // convenção de escrita da variável(atributo).
        //private string Capital;
        //private double AreaKm2;

        public Pais()
        {

        }  
        
        public string Nome // propriedade => utiliza os atributos 
        {
            get
            {
                return this._nome;
            }

            set
            {
                this._nome = value;
            }
        } 

        public string Capital { get; set; }
        public double AreaKm2 { get; set; } // propriedade => encapsula os métodos get e set.

        //public void SetNomePais(string nome)
        //{
        //    _nome = nome;
        //}

        //public void SetCapitalPais(string nome)
        //{
        //    this.Capital = nome;
        //}

        //public void SetAreaKm2Pais(double area)
        //{
        //    this.AreaKm2 = area;
        //}
        //public string GetNomePais()
        //{
        //    return this._nome;
        //}

        //public string GetCapitalPais()
        //{
        //    return this.Capital;
        //}

        //public double GetAreaKm2Pais()
        //{
        //    return this.AreaKm2;
        //}

        public bool PaisIguais(Pais pais) // Passagem de parâmetro por referência // tipo de dado Pais
        {
            return this._nome == pais._nome && this.Capital == pais.Capital && this.AreaKm2 == pais.AreaKm2;

        }
    }
}
