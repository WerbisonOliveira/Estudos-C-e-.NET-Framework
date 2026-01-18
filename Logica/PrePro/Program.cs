using System;

namespace PrePro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Incremento é somente: variável++(pós); (pré)++variável; variável--; --variável;

            int contador = 0;

            int valor = contador++; /* Pós-incremento - atribui e depois incrementa a variável contador. 
                                     * Quando temos um pós-incremento junto de uma outra operação, é primeiro realizado a operação e depois o incremento.
                                     */
            //int valor = contador;
            //contador = contador + 1;
            Console.WriteLine(valor);




            int valor2 = contador += 2; // Não é mais incremento, é uma operação.
            //int valor2 = contador *= 2;
            //int valor2 = contador -= 2;
            //int valor2 = contador /= 2;          
            //int valor = contador = contador + 2;  é a mesma coisa disso: int valor2 = contador += 2;
            Console.WriteLine(valor2);




            int valor3 = ++contador;/*
                                        * Pré-incremento - primeiro é realizado o incremento e depois a atribuição.
                                        * Mesmo que esteja junto de um outro operador.
                                     */
            Console.WriteLine(valor3);




            int valor4 = contador++ * 2 * 30;/* 
                                              * Nessa situação é feito as operações de multiplicação e atribuido o valor a variável valor4 e no final é feito o incremento na variável contador.
                                              */
            Console.WriteLine(valor4);





            int valor5 = ++contador * 2 * 30;/* 
                                              * Nessa situação é feito primeiro o incremento na variável contador, após é realizado as operações de multiplicação e no final é atribuído o resultado a variável valor5.
                                              */
            Console.WriteLine(valor5);

        }
    }
}
