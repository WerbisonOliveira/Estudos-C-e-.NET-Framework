using System;
using System.Collections.Generic;



namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------- Array ------------------------

            //int[] numeros = new int[] {1, 2, 3, 4, 5};
            
            //const int TAMANHO = 3;
            //int[] numeros = new int[TAMANHO];
            //int valor = 0, maiorValor = int.MinValue, menorValor = int.MaxValue, soma = 0, numerosPares = 0, numerosImpares = 0;

            //for (int cont = 0; cont < numeros.Length; cont++)
            //{
            //    Console.Write($"\nDigite o {cont + 1}º número: ");
            //    valor = int.Parse(Console.ReadLine());

            //    numeros[cont] = valor;

            //    soma += valor;

            //    if (valor > maiorValor)
            //        maiorValor = valor;

            //    if (valor < menorValor)
            //        menorValor = valor;

            //    if (valor % 2 == 0)
            //        numerosPares++;
            //    else
            //        numerosImpares++; 
   
            //}
            

            //Console.WriteLine($"\nA soma de todos os valores digitados é {soma}");
            //Console.WriteLine($"\nA média de todos os valores digitados é {(double) soma / numeros.Length:0.00}");
            //Console.WriteLine($"\nMaior valor digitado: {maiorValor}");
            //Console.WriteLine($"\nMenor valor digitado: {menorValor}");
            //Console.WriteLine($"\nQuantidade de números pares digitados: {numerosPares}");
            //Console.WriteLine($"\nQuantidade de números impares digitados: {numerosImpares}");

            //Console.Write("\nNúmeros na ordem inversa: ");
            //for (int i = numeros.Length - 1; i > -1; i--)
            //{
            //    Console.Write(numeros[i] + " ");
            //}

            //------------------- List --------------------------

            List<string> nomes = new List<string>();
            HashSet<string> nomesNãoRepetidos = new HashSet<string>();
            int opcaoDoUsuario = 0;
            string nome = "", nomeRemovido = "";
            bool encerrar = false;

            do
            {

                Console.WriteLine("------ Cadastro_de_nomes ------\n");

                Console.WriteLine("1 - Adicionar nome");
                Console.WriteLine("2 - Verificar nome");
                Console.WriteLine("3 - Remover nome");
                Console.WriteLine("4 - Imprimir lista");
                Console.WriteLine("5 - Encerrar o programa");

                Console.Write("\nOpção: ");
                opcaoDoUsuario = int.Parse(Console.ReadLine());

                switch (opcaoDoUsuario)
                {
                    case 1:
                        Console.Write("\nDigite o nome: ");
                        nomes.Add(Console.ReadLine().ToLower());
                        Console.WriteLine("\nNome adicionado com sucesso.");
                        break;
                    case 2:
                        Console.Write("\nDigite o nome: ");
                        nome = Console.ReadLine();

                        if (nomes.Contains(nome.ToLower()))
                            Console.Write("\nO nome está na lista!");
                        else
                            Console.Write("\nO nome não está na lista!");
                        break;
                    case 3:
                        Console.Write("\nDigite o nome: ");
                        nomeRemovido = Console.ReadLine();

                        if (nomes.Contains(nomeRemovido.ToLower()))
                        {
                            nomes.RemoveAt(nomes.IndexOf(nomeRemovido.ToLower()));
                            Console.Write("\nNome removido com sucesso!");
                        }
                        else
                            Console.Write("\nOO nome não está presente na lista.");
                        break;
                    case 4:
                        Console.Write("\nLista: ");
                        foreach (string n in nomes)
                        {
                            Console.Write($"{n} ");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nEncerrando...");
                        encerrar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção escolhida inválida!");
                        break;
                }


                Console.WriteLine("\n\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (!encerrar);

            foreach (string n in nomes) 
            {
                nomesNãoRepetidos.Add(n);
            }

            Console.Write("\nConjunto sem nomes repetidos: ");
            foreach (string n in nomesNãoRepetidos) 
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine("");

        }
    }
}
