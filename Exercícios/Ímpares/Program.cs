using System;

/*
    O objetivo do programa abaixo é imprimir apenas os números ímpares de 1 a 10 utilizando a estrutura de repetição for. No entanto, o código contém uma falha no comando de controle de fluxo, que faz com que ele não funcione conforme o esperado.
*/

namespace Ímpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
