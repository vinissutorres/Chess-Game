namespace tabuleiro{
    class Posicao{

        //pode ler e atribuir valor aos atributos
        public int linha { get; set; }
        public int coluna { get; set; }

        //construtor
        public Posicao(int linha, int coluna) {
            this.linha = linha; //atribui os valores p/ novos objetos
            this.coluna = coluna;
        }

        //representa em string um objeto quando convertido implicitamente
        //se nao tiver ele, ele retorna o nome completo da classe
        public override string ToString(){
            return linha + "," + coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna; 
        }
    }
}
