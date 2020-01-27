using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro (Tabuleiro tab)
        {
            for (int i = 0; i<tab.linhas; i++)
            {
                Console.Write(8 -i + " ");
                for (int j = 0; j<tab.colunas; j++)
                { //Se o tabuleiro não possuir peças...
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }//Se o tabuleiro possuir peças , imprima a peça na posição , e dê um espaço.
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine(" ");
                
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
