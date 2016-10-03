using System;
using tabuleiro;
using xadrez;

namespace aula_vinte_e_nove {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

           }
         }
       }
