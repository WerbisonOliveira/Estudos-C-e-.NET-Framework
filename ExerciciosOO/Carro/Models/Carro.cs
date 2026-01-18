using System;

namespace Carro.Models
{
    internal class Carro 
    {
        private int ano;// Atributo para propriedade padrão
        public  string Modelo { get; set; }// Propriedade automática(auto-property). Não tem lógica.

        public int Ano // Propriedade padrão, podemos adicionar lógica. Encapsulamento.
        {   
            get
            {
                return this.ano;
            } 

            set 
            { 
                this.ano = value; 
            }
        }

        public Motor Motor { get; set; }// Atributo do tipo Motor(classe).

        public Carro()
        {

        }

        public string ExibirDetalhes()
        {
            return $"Modelo: {this.Modelo} \nAno: {this.Ano} \nMotor: potência - {this.Motor.Potencia}cv e combustível - {this.Motor.Combustivel}";
        }

    }
}
