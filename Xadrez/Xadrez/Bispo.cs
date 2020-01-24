﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Bispo: Peca
    {
        public Bispo (Tabuleiro tab , Cor cor): base (tab , cor)
        {

        }

        public override string ToString()
        {
            return "B";
        }
    }
}
