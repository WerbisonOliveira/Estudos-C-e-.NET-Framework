using System;


namespace Sistema_de_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Livro l1 = new Models.Livro("Aprendendo OO", "Alguém", 2020);
            Models.Livro l2 = new Models.Livro("C#", "Alguém2", 2010);
            Models.Livro l3 = new Models.Livro("Programação", "Alguém3", 1990);
            Models.Livro l4 = new Models.Livro("Programação", "Alguém3", 1990);
            //Console.WriteLine(l1.LivroInfo());

            Models.Usuario u1 = new Models.Usuario("Werbison", "werbison090@gmail.com");
            //Console.WriteLine(u1.UsuarioInfo());

            Models.Emprestimo emprestimo = new Models.Emprestimo(u1);
            emprestimo.EmprestarLivro(l1, l2, l3);
            Console.WriteLine($"{emprestimo.Usuario.UsuarioInfo()} \nLivros: " + emprestimo.ListarEmprestimos());

            Models.Emprestimo emprestimo2 = new Models.Emprestimo(new Models.Usuario("João", "João123@gmail.com"));
            emprestimo2.EmprestarLivro(l1, l2, l3);
            emprestimo2.DevolverLivro(l2, l3);
            Console.WriteLine($"\n{emprestimo2.Usuario.UsuarioInfo()} \nLivros: " + emprestimo2.ListarEmprestimos());
        }
    }
}
