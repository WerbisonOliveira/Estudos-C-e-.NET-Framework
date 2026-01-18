using System;


namespace Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Porta p1 = new Models.Porta(); //A102
            Console.WriteLine($"Cor: {p1.Cor}\n");
            p1.Abrir();
            p1.Fechar();
            p1.Pintar("amarelo");
            p1.Pintar("azul");
            p1.Pintar("vermelho");

            Models.Porta p2 = new Models.Porta(); //B120
            Console.WriteLine($"Cor: {p2.Cor}\n");
            p2.Abrir();
            p2.Pintar("roxo");

            Models.Porta p3 = p1;
            Console.WriteLine($"Cor: {p3.Cor}\n");
            p3.Abrir();

            p1.Pintar("verde");

            Models.Porta p4 = new Models.Porta(); //C200
            Console.WriteLine($"Cor: {p4.Cor}\n");
            p4.Abrir();

            Models.Porta p5 = new Models.Porta("Laranja");
            Console.WriteLine($"Cor: {p5.Cor}\n");


            Models.Porta p6 = new Models.Porta("Laranja", true);
            Console.WriteLine($"Cor: {p6.Cor}");
        }
    }
}
