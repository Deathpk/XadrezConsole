﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Torre: Peca
    {
        public Torre (Tabuleiro tab , Cor cor): base (tab , cor)
        {
            
        }

        public override string ToString()
        {
            return "T";
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
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos)!= null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //abaixo

            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.definirValores(posicao.linha , posicao.coluna+1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna+1 ;
            }

            //esquerda
            pos.definirValores(posicao.linha , posicao.coluna -1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {// Enquanto tiver casa livre ou peça adversária posso mover.
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //aqui é como se tivesse um else.
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
    }
}
