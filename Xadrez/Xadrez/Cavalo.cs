using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Cavalo:Peca
    {
        public Cavalo (Tabuleiro tab , Cor cor): base (tab , cor)
        {

        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor; // this.cor = se a cor for diferente da cor do player atual (peça adversária)
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna -2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores (pos.linha -1 , pos.coluna -2);
            }

            //abaixo

            pos.definirValores(posicao.linha -2, posicao.coluna -1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 2, pos.coluna -1);
            }

            //direita
            pos.definirValores(posicao.linha -2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linha - 2, pos.coluna + 1);
            }

            //esquerda
            pos.definirValores(posicao.linha -1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //aqui é como se tivesse um else.
                pos.definirValores(pos.linha - 1, pos.coluna + 2);
            }

            //outro1
            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //aqui é como se tivesse um else.
                pos.definirValores(pos.linha + 1, pos.coluna + 2);
            }

            //outro2
            pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //aqui é como se tivesse um else.
                pos.definirValores(pos.linha  + 2, pos.coluna + 1);
            }

            //outro 3
            pos.definirValores(posicao.linha +2, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //aqui é como se tivesse um else.
                pos.definirValores(pos.linha + 2, pos.coluna - 1);
            }

            //outro 4
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //aqui é como se tivesse um else.
                pos.definirValores(pos.linha + 1, pos.coluna - 2);
            }

          

            return mat;
        }

    }
}
