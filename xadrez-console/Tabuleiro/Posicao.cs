using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + coluna;
        }
    }
}
