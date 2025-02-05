using System;

namespace tabuleiro{
    class Tabuleiro{

        public int linhas {  get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; //matriz 

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //metodo pra pegar a posicao da peça
        public Peca peca (int linha, int coluna){
            return pecas[linha, coluna];
        }

        //sobrecarga
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos){
            validarPosicao(pos);
            return peca(pos) != null;

        }

        public void colocarPeca(Peca p, Posicao pos){
            if (existePeca(pos)){
                throw new TabuleiroException("Já tem uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p; //colocando a peça dentro da matriz
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos){
            if(peca(pos) == null){
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos){
            if(pos.linha <0 || pos.linha>=linhas || pos.coluna < 0 || pos.coluna >= colunas){
                return false;
            }
            else {
                return true;
            }
        }

        public void validarPosicao(Posicao pos){
            if (!posicaoValida(pos)){
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
