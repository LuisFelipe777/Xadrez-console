using System;
using tabuleiro;
namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tap = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tap);


            Console.ReadLine();
        }
    }
}
