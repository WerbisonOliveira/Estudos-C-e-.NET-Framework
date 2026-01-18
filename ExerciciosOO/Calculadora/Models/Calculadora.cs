using System;


namespace Calculadora.Models
{
    internal class Calculadora
    {
        public int Valor1 { get; private set; }
        public int Valor2 { get; private set; }

        public Calculadora()
        {

        }

        public int Somar(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            return valor1 + valor2;
        }

        public int Subtrair(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            return Valor1 - Valor2;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            return Valor1 * Valor2;
        }

        public int Dividir(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            if (Valor2 == 0)
                throw new ArgumentException("Não é possível dividir por 0");
            else
                return Valor1 / Valor2;
        }
    }
}
