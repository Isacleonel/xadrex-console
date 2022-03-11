using System;
using tabuleiro;
using xadrez;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
            */

            /*
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
            */
            try
            {
                /*
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                Tela.imprimirTabuleiro(tab);
                */
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }               

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
