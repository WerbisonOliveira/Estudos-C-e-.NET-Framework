using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SENHACORRETA = "123voltojah";
            const int TAMANHOMINIMODASENHA = 4;
            string senha;

            Console.WriteLine("==== Senha ====");

            do
            {
                Console.Write("\nDigite a senha: ");
                senha = Console.ReadLine();

                if (senha.Length >= TAMANHOMINIMODASENHA)
                {
                    if (senha == SENHACORRETA)
                    {
                        Console.WriteLine("\nAcesso Total.");
                    }
                    else
                    {
                        Console.WriteLine("\nAcesso Negado. Digite a senha correta!");
                    }
                }
                else
                {
                    Console.WriteLine($"\nA senha deve ter mais de {TAMANHOMINIMODASENHA - 1} caracteres.");
                }
            } while (senha != SENHACORRETA );

           

            Console.WriteLine("\nPressione ENTER para sair");
            Console.ReadLine();

        }
    }
}
