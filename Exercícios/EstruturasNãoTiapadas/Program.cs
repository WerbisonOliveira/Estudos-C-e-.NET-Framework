using System;
using System.Collections.Generic;
using System.Collections;


namespace EstruturasNãoTipadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();// Não tipada(não genérica)
            Queue<int> fila2 = new Queue<int>();// Tipada(genérica)

            fila.Enqueue(1);// Conversão ímplicita, ocorre em tempo de execução. Boxing => tipo de dado especifico para object.

            int numero = (int) fila.Dequeue();// Conversão explícita, ocorre em tempo de execução. Unboxing => object para tipo de dado especifico. Casting.

            fila2.Enqueue(1);// Tipada, não precisa de conversão.

            int numero2 = fila2.Dequeue(); // Tipada, não precisa de conversão.

            ArrayList array = new ArrayList();// Utiliza o tipo object, não é recomendado utilizar essa coleção.

            array.Add(3);// Conversão ímplicita, ocorre em tempo de execução. Boxing => tipo de dado especifico para object.

            int numero3 = (int)array[0];// Conversão explícita, ocorre em tempo de execução.Unboxing => object para tipo de dado especifico. Casting.


        }
    }
}
