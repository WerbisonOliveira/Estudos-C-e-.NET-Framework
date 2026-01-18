using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10;

            object y = x; // boxing

            Queue fila = new Queue();
            fila.Enqueue(x); // boxing
            fila.Enqueue("texto");

            foreach (var item in fila) // var => object (compilador)
            {
                Console.WriteLine(item);
            }

            Queue<int> fila2 = new Queue<int>();
            fila2.Enqueue(x);
            fila2.Enqueue(50);

            foreach (var item in fila2) // var => int (compilador)
            {
                Console.WriteLine(item);
            }

        }
    }
}
