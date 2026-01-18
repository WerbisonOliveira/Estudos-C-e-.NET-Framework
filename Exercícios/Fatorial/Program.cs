using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respostaDoUsuario = "s";  

            while (respostaDoUsuario.ToLower() == "s")
            {
                int numeroFatorial = 0;
                bool resultado;

                Console.WriteLine("======== Fatorial ========");            

                do
                {
                    Console.Write("\nInforme um número para saber seu fatorial: ");
                    resultado = int.TryParse(Console.ReadLine(), out numeroFatorial);

                    if(resultado == false)
                        Console.WriteLine("\nValor inválido!");

                } while (resultado == false);

                int contador = numeroFatorial - 1, fatorial = 0;

                while (contador >= 1)
                {              
                    if (fatorial == 0)
                    {
                        Console.WriteLine($"\n{numeroFatorial} * {contador} = {numeroFatorial * contador}");
                        fatorial = numeroFatorial * contador;
                    }

                    else
                    {
                        Console.WriteLine($"\n{fatorial} * {contador} = {fatorial * contador}");
                        fatorial *= contador;
                    }

                    contador--;
                }

                if(numeroFatorial == 0 || numeroFatorial == 1)
                    Console.WriteLine($"\nO fatorial de {numeroFatorial}! é 1");
                else
                    Console.WriteLine($"\nO fatorial de {numeroFatorial}! é {fatorial}");

                do
                {
                    Console.Write("\nDeseja saber o fatorial de outro número? [s - sim / n - não] ");
                    respostaDoUsuario = Console.ReadLine();

                    if(respostaDoUsuario != "s" && respostaDoUsuario != "n")
                        Console.WriteLine("\nInválido!");

                } while (respostaDoUsuario != "s" && respostaDoUsuario != "n");


                if (respostaDoUsuario.ToLower() == "s")
                        Console.Clear();
            }

            Console.WriteLine("\nPressione Enter para encerrar");
            Console.ReadLine();
        }
    }
}
