using System;
using tabuleiro;

namespace aula_vinte_e_nove
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}
