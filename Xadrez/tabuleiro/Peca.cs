using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab  { get; protected set; }

        public Peca (Tabuleiro tab , Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.QteMovimentos = 0;

        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i<tab.linhas; i++)
            {
                for (int j = 0; j<tab.colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }                   
                }
            }
            return false; // testar depois com um else dentro do for.
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
        

    }
}
