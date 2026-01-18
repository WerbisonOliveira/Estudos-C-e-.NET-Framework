using System;
using System.Collections.Generic;

/*
Crie um programa em C# que:

Crie uma fila de inteiros e uma pilha de inteiros.

Permita que o usuário digite 5 números inteiros.

Cada número digitado deve ser inserido na fila e também na pilha.

Exiba o conteúdo da fila (na ordem de inserção).

Exiba o conteúdo da pilha (na ordem inversa de inserção).

Retire um elemento da fila (Dequeue) e um elemento da pilha (Pop), mostrando quais foram removidos.

Mostre novamente o conteúdo atualizado da fila e da pilha.
*/

namespace FilaPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QUANTIDADE = 5;
            Queue<int> fila = new Queue<int>(QUANTIDADE);
            Stack<int> pilha = new Stack<int>(QUANTIDADE);

            int numero = 0;

            for (int i = 0; i < QUANTIDADE; i++)
            {
                Console.Write($"\nDigite o {i + 1}º número: ");
                numero = int.Parse(Console.ReadLine());

                fila.Enqueue(numero);
                pilha.Push(numero);
            }

            Console.Write("\nFila: ");
            foreach (int f in fila) 
            {
                Console.Write($"{f} ");

            }

            Console.Write("\n\nPilha: ");
            foreach (int p in pilha)
            {
                Console.Write($"{p} ");
            }

            Console.WriteLine("\n---------------------------------------------");

            Console.WriteLine($"Valor removido da fila: {fila.Dequeue()}");
            Console.Write("Fila: ");
            foreach (int f in fila)
            {
                Console.Write($"{f} ");

            }

            Console.WriteLine($"\n\nValor removido da pilha: {pilha.Pop()}");
            Console.Write("Pilha: ");
            foreach (int p in pilha)
            {
                Console.Write($"{p} ");
            }
        }
    }
}
