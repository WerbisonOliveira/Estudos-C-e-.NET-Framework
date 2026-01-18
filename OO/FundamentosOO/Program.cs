using System;

/*
    Personagem: id, nome, idade, corDoCabelo
    Criar 3 personagens
 */

namespace FundamentosOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region "outros"
            /*
            string x = "faca"; // array char
            x = "garfo";

            char[] y = { 'f', 'a', 'c', 'a' }; // array de char... 64 bits
            //y = { 'g', 'a', 'r', 'f' ?????????? }; // não consigo colocar garfo aqui... 80 bits

            int s = 10;
            s = 32;
            */

            /*
            // criando UM carro
            string cor1;
            int tamanho1;
            int quantidadeDePneus1;
            bool arCondicionado1;
            

            //criando um OUTRO carro
            string cor2;
            int tamanho2;
            int quantidadeDePneus2;
            bool arCondicionado2;

            //criando um OUTRO OUTRO carro
            string cor3;
            int tamanho3;
            int quantidadeDePneus3;
            bool arCondicionado3;
            */
            #endregion


            #region "Sem OO"

            const int QUANTIDADEDECARROS = 3;

            /*
            

            List<string> cor = new List<string>(QUANTIDADEDECARROS);
            string[] cor = new int[QUANTIDADEDECARROS];
            int[] tamanho = new int[QUANTIDADEDECARROS];
            int[] quantidadeDePneus = new int[QUANTIDADEDECARROS];
            bool[] arCondicionado = new bool[QUANTIDADEDECARROS];

            for (int i = 0; i < QUANTIDADEDECARROS; i++)
            {
                cor[i] = "amarelo";
                tamanho[i] = 3;
                quantidadeDePneus[i] = 4;
                arCondicionado[i] = true;
            }

            cor[1] = "azul";

            int x = 10;

            // Consegue imprimir as características do carro1?

            for (int i = 0; i < QUANTIDADEDECARROS; i++)
            {
                Console.WriteLine($"imprimindo carro {i + 1}");
                Console.WriteLine(cor[i]);
                Console.WriteLine(tamanho[i]);
                Console.WriteLine(quantidadeDePneus[i]);
                Console.WriteLine(arCondicionado[i]);
                Console.WriteLine("");
            }
            */
            #endregion


            #region "Com OO"

            // ------------ Orientado para o carro   ----------------------

            //Carro[] carros = new Carro[QUANTIDADEDECARROS];

            //for (int i = 0; i < QUANTIDADEDECARROS; i++)
            //{
            //    carros[i] = new Carro();
            //    carros[i].cor = "amarelo";
            //    carros[i].tamanho = 3;
            //    carros[i].quantidadeDePneus = 4;
            //    carros[i].arCondicionado = true;
            //}

            //carros[1].cor = "azul";

            
            /*
            Models.Moto moto1 = new Models.Moto();

            Models.Moto moto2 = new Models.Moto();

            Models.Moto moto3 = new Models.Moto();


            Models.Personagem p1 = new Models.Personagem();
            p1.nome = "Igor Mendes";
            p1.id = 1;
            p1.idade = 26;
            p1.corDoCabelo = "castanho";

            Models.Personagem p2 = new Models.Personagem();

            Models.Personagem p3 = new Models.Personagem();

            bool saoIguais = p1 == p3; //compara os valores(endereços iniciais)

            p3.nome = "Igor Mendes";
            p3.id = 1;
            p3.idade = 26;
            p3.corDoCabelo = "castanho";

            saoIguais = p1 == p3;

            saoIguais = p1.nome == p3.nome // Compara os valores dos atributos
                && p1.idade == p3.idade
                && p1.corDoCabelo == p3.corDoCabelo
                && p1.id == p3.id;

            p1 = p2;

            saoIguais = p1 == p2;

            p2.nome = "Joca";
            // o nome de p1 será alterado para Joca?
            // Sim

            p1.idade = 85;
            // a idade de p2 será alterada?
            // Sim

            p1 = new Models.Personagem(); // desvinculei p1 de p2 (nova instância de p1)
            p1.nome = "Maria";
            // O nome de p2 será alterado?
            // Não.
            */

            Models.Carro ferrari = new Models.Carro();
            ferrari.Acelerar();

            Models.Carro fusca = new Models.Carro();
            fusca.Acelerar();
            fusca.Acelerar();
            fusca.Acelerar();

            ferrari.Acelerar();
            ferrari.Frear();
            //ferrari.Frear();
            //ferrari.Frear();
            //ferrari.Frear();
            //ferrari.Frear();
            //ferrari.Frear();
            //ferrari.Frear();


            Console.WriteLine($"A ferrari está parada: {(ferrari.EstarParado() ? "Sim" : "Não")}");

            #endregion


            Models.Personagem personagem = new Models.Personagem();
            personagem.id = 1;
            personagem.nome = "Werbison";
            personagem.idade = 23;
            personagem.corDoCabelo = "Castanho";

            Models.Personagem personagem2 = new Models.Personagem();
            personagem2.id = 2;
            personagem2.nome = "Ana";
            personagem2.idade = 21;
            personagem2.corDoCabelo = "Preto";

            Models.Personagem personagem3 = new Models.Personagem();
            personagem3.id = 3;
            personagem3.nome = "João";
            personagem3.idade = 19;
            personagem3.corDoCabelo = "Castanho";

        }
    }
}
