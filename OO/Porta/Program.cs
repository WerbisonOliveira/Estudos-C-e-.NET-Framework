using System;



namespace Porta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Porta porta = new Models.Porta();
            porta.Abrir();
            porta.Fechar();
        }
    }
}
