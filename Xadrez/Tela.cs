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
                for (int j = 0; j<tab.colunas; j++)
                { //Se o tabuleiro não possuir peças...
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }//Se o tabuleiro possuir peças , imprima a peça na posição , e dê um espaço.
                    else
                    {
                        Console.Write(tab.peca(i,j)+" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
