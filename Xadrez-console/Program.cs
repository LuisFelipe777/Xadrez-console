using System;
using tabuleiro;
using xadrez;
using Xadrez_console.tabuleiro;
namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
                Console.ReadLine();
            }catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
