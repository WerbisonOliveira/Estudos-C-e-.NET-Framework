using System;



namespace Impressora.Models
{
    internal class Impressora
    {
        public string Texto { get; private set; }

        public int Numero { get; set; }

        public Impressora()
        {

        }

        public string ImprimirTexto(string texto)
        {
            Texto = texto;
            return $"{Texto}";
        }

        public string ImprimirQtdTexto(string texto, int numero)
        {
            System.Text.StringBuilder txt = new System.Text.StringBuilder();
            Texto = texto;
            for (Numero = numero; Numero > 0; Numero--)
            {              
                txt.Append(Texto);
            }

            return txt.ToString();

        }

        public int ImprimirNumero(int numero)
        {
            Numero = numero;
            return Numero;
        }

    }
}
